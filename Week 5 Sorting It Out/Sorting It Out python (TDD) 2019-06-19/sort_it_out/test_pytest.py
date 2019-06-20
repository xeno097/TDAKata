import pytest
from main import *


def test_WithEmptyList_returns_EmptyList():
    rack = Rack()
    test_list = list()
    assert rack.Balls == test_list


def test_WithOneNumber_returns_OneNumberList():
    rack = Rack()
    rack.Add(10)
    test_list = list()
    test_list.append(10)
    assert rack.Balls == test_list


def test_WithTwoNumbers_returns_TwoNumberList():
    rack = Rack()
    rack.Add(20)
    rack.Add(2)
    test_list = list()
    test_list.append(20)
    test_list.append(2)
    test_list.sort()
    assert rack.Balls == test_list


def test_WithThreeNumbers_returns_SortedNumberList():
    rack = Rack()
    rack.Add(20)
    rack.Add(2)
    rack.Add(7)
    test_list = list()
    test_list.append(20)
    test_list.append(2)
    test_list.append(7)
    test_list.sort()
    assert rack.Balls == test_list


def test_WithEmptyString_Return_EmptyString():
    rack = StringRack('')
    test_string = ''
    assert rack.SortedString == test_string


def test_WithOneChar_Return_OneChar():
    rack = StringRack('a')
    test_string = 'a'
    assert rack.SortedString == test_string


def test_WithStringChar_Returns_SortedStringChar():
    rack = StringRack(
        'When not studying nuclear physics, Bambi likes to play beach volleyball.')
    test_string = 'aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy'
    assert rack.SortedString == test_string
