import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import importlib
import unittest
import pandas as pd

# Python really doesn't like paths with "-" and "/"
# I don't like Python not liking it so
# have to use importlib to import modules
unit = importlib.import_module("src.2891-method-chaining")

sample_df = pd.DataFrame({
    "name": ["Tatiana", "Khaled", "Alex", "Jonathan", "Stefan", "Tommy"],
    "species": ["Snake", "Giraffe", "Leopard", "Monkey", "Bear", "Panda"],
    "age": [98, 50, 6, 45, 100, 26],
    "weight": [464, 41, 328, 463, 50, 349]
})

expected_df = pd.DataFrame({
    "name": ["Tatiana", "Jonathan", "Tommy", "Alex"]
})

class TestFindHeavyAnimals(unittest.TestCase):
    def test_findHeavyAnimals(self):
        actual_df = unit.findHeavyAnimals(sample_df).reset_index(drop=True)
        
        pd.testing.assert_frame_equal(actual_df, expected_df)

if __name__ == "__main__":
    unittest.main()
