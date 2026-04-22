import sys
import importlib
import unittest
import pandas as pd

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2880-select-data")

df = pd.DataFrame({
    "student_id": [101, 53, 128, 3],
    "name": ["Ulysses", "William", "Henry", "Henry"],
    "age": [13, 10, 6, 11]
})

expected_df = pd.DataFrame({
    "name": ["Ulysses"],
    "age": [13]
})

class TestSelectData(unittest.TestCase):
    def test_selectData(self):
        actual_df = unit.selectData(df)
        actual_df.reset_index(drop=True, inplace=True)
        
        pd.testing.assert_frame_equal(actual_df, expected_df)

if __name__ == "__main__":
    unittest.main()
