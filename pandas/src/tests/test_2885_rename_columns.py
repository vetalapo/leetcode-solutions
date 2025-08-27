import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2885-rename-columns")

sample_df = pd.DataFrame({
    "id": [1, 2, 3, 4, 5],
    "first": ["Mason", "Ava", "Taylor", "Georgia", "Thomas"],
    "last": ["King", "Wright", "Hall", "Thompson", "Moore"],
    "age": [6, 7, 16, 18, 10]
})

expected_df = pd.DataFrame({
    "student_id": [1, 2, 3, 4, 5],
    "first_name": ["Mason", "Ava", "Taylor", "Georgia", "Thomas"],
    "last_name": ["King", "Wright", "Hall", "Thompson", "Moore"],
    "age_in_years": [6, 7, 16, 18, 10]
})

class TestRenameColumns(unittest.TestCase):
    def test_renameColumns(self):
        actual_df = unit.renameColumns(sample_df)
        pd.testing.assert_frame_equal(actual_df, expected_df)

if __name__ == "__main__":
    unittest.main()
