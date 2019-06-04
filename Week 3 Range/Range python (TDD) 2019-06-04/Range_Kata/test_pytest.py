import pytest
from main import *

def test_withrange26_and_24_return_true():
    assert Range("[2,6)","{2,4}")==True

def test_withrange26_and_list11610_return_false():
    assert Range("[2,6)","{-1,1,6,10}")==False

def test_withrange26_orint2345():
    assert Range("[2,6)")=="{2,3,4,5}"

def test_containsrange():
    assert Range("[2,5)","[3,5)") == True

def test_endpoints():
    assert Range("[2,6)",'ep') == "{2,5}"

def test_overlaps():
    assert Range("[2,6)","[7,10)",'op') == False

def test_equals():
    assert Range("[3,5)","[3,5)",'eq') == True

def test_arenotequals():
    assert Range("[2,5)","[1,10)",'nq') == True