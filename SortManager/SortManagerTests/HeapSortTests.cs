﻿using SortManagerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerTests;

internal class HeapSortTests
{
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.PosArrays))]
    public void GivenAnArrayof1Integers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new HeapSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.EmptArray))]
    public void GivenAnEmptyArray_returnsAnEmptyArray(int[] input, int[] expected)
    {
        var sorter = new HeapSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [TestCaseSource(typeof(SortTestData), nameof(SortTestData.NegandPosArrays))]
    public void GivenAnArrayofMixedIntegers_ReturnsMergeSortedArray(int[] input, int[] expected)
    {
        var sorter = new HeapSort();
        var actual = sorter.Sort(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void TestNullCaseThrowsexception()
    {
        int[] input = null!;
        var sorter = new HeapSort();
        Assert.That(() => sorter.Sort(input), Throws.TypeOf<ArgumentNullException>());
    }
}
