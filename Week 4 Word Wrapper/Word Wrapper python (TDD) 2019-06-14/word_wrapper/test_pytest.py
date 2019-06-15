import pytest
from main import *


def test_WithEmptyString_Returns_EmptyString():
    assert wrapper.wrap("", 1) == ""


def test_WithTwoWordsAndLEqualsToLenghtOfOneOfTheTwoLength_Returns_TwoWordsSeparetedbyNewline():
    assert wrapper.wrap("sol luna", 4) == "sol \nluna"


def test_WithWordsAndALength_Returns_TheWordsCorrectlySeparatedByNewlines():
    assert wrapper.wrap("sol luna cielo", 5) == "sol  \nluna \ncielo"
