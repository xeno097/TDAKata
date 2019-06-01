import pytest
from main import *
from errors import *

def test_with012_return6():
    assert string_add("1,2,3") == str(6) #the method must return a string

def test_empty_return0():
    assert string_add("") == str(0)

def test_withmanynums_returnsum():
    assert string_add("1,2,3,4,5,6") == str(21)

def test_withnewline_and_manynumbers_returnsum():
    assert string_add("1\n2,3\n4,5,6") == str(21)

def test_withseparatorafterseparator_givesanerror():
    with pytest.raises(Exception):
        assert string_add("1\n2,3,\n4,5,6")

def test_withseparatorattheend_givesaneeror():
    with pytest.raises(Exception):
        assert string_add("1,2,")

def test_withnewseparator_returnsum():
    assert string_add("//;\n1;2") == str(3)

def test_withnegatives_throwsvalueerror():
    with pytest.raises(Exception):
        assert string_add("-1,-6,7")

def test_withnegatives_throwsvalueerror():
    with pytest.raises(Exception):
        assert string_add("-1,-6,7")