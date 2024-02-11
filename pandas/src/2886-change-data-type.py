﻿##
# 2886
# Change Data Type
##
# DataFrame students
# +-------------+--------+
# | Column Name | Type   |
# +-------------+--------+
# | student_id  | int    |
# | name        | object |
# | age         | int    |
# | grade       | float  |
# +-------------+--------+
# Write a solution to correct the errors:
#   The grade column is stored as floats, convert it to integers.
#   The result format is in the following example.
#
# Example 1:
#   Input:
#   DataFrame students:
#   +------------+------+-----+-------+
#   | student_id | name | age | grade |
#   +------------+------+-----+-------+
#   | 1          | Ava  | 6   | 73.0  |
#   | 2          | Kate | 15  | 87.0  |
#   +------------+------+-----+-------+
#   Output:
#   +------------+------+-----+-------+
#   | student_id | name | age | grade |
#   +------------+------+-----+-------+
#   | 1          | Ava  | 6   | 73    |
#   | 2          | Kate | 15  | 87    |
#   +------------+------+-----+-------+
#   
#   Explanation: The data types of the column grade is converted to int.
#
# Hint 1
# Consider using a build-in function in pandas library with a dictionary to convert the datatype of columns as specified.
##
# https://leetcode.com/problems/change-data-type/
##

import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import pandas as pd

def changeDatatype(students: pd.DataFrame) -> pd.DataFrame:
    students.grade = students.grade.astype(int)
    return students
