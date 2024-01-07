﻿##
# 2884
# Modify Columns
##
# DataFrame employees
#   +-------------+--------+
#   | Column Name | Type   |
#   +-------------+--------+
#   | name        | object |
#   | salary      | int    |
#   +-------------+--------+
#
# A company intends to give its employees a pay rise.
# Write a solution to modify the salary column by multiplying each salary by 2.
# 
# The result format is in the following example.
# 
# Example 1:
#   Input:
#   DataFrame employees
#   +---------+--------+
#   | name    | salary |
#   +---------+--------+
#   | Jack    | 19666  |
#   | Piper   | 74754  |
#   | Mia     | 62509  |
#   | Ulysses | 54866  |
#   +---------+--------+
#
#   Output:
#   +---------+--------+
#   | name    | salary |
#   +---------+--------+
#   | Jack    | 39332  |
#   | Piper   | 149508 |
#   | Mia     | 125018 |
#   | Ulysses | 109732 |
#   +---------+--------+
#
#   Explanation:
#   Every salary has been doubled.
##
# https://leetcode.com/problems/modify-columns/
##

import sys

# Preventing creation of __pycache__
sys.dont_write_bytecode = True

import pandas as pd

def multiplyByTwo(num):
    return num * 2

def modifySalaryColumn(employees: pd.DataFrame) -> pd.DataFrame:
    employees.salary = employees.salary.apply(multiplyByTwo)
    return employees
