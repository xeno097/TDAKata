import pytest
from main import *


def test_With1_returns_OneDollar():
    assert Nums_toString(1) == "one dollar"


def test_With2_returns_TwoDollars():
    assert Nums_toString(2) == "two dollars"


def test_With15_returns_FifteenDollars():
    assert Nums_toString(15) == "fifteen dollars"


def test_With23_returns_TwentyThreeDollars():
    assert Nums_toString(23) == "twenty three dollars"


def test_With123_returns_OneHundredTwentyThreeDollars():
    assert Nums_toString(123) == "one hundred twenty three dollars"


def test_With573_returns_FiveHundredSeventyThreeDollars():
    assert Nums_toString(573) == "five hundred seventy three dollars"


def test_With1573_returns_FiveHundredSeventyThreeDollars():
    assert Nums_toString(
        1573) == "one thousand five hundred seventy three dollars"
