﻿using System;
using DataStructures;
using Challenges;
using Xunit;

namespace Challenges.Tests
{
    public class LL_ChallengesTests
    {
        [Fact]
        public void Merge2ListsSameLengthTest()
        {
            LinkedList list1 = new LinkedList();

            list1.Append(4);
            list1.Append(5);
            list1.Append(6);

            LinkedList list2 = new LinkedList();

            list2.Append(1);
            list2.Append(2);
            list2.Append(3);

            Assert.Equal("{ 4 } -> { 1 } -> { 5 } -> { 2 } -> { 6 } -> { 3 } -> NULL", LL_Challenges.mergeLists(list1, list2).ToString());
        }

        [Fact]
        public void MergeList2ShorterTest()
        {
            LinkedList list1 = new LinkedList();

            list1.Append(4);
            list1.Append(5);
            list1.Append(6);

            LinkedList list2 = new LinkedList();

            list2.Append(7);
            list2.Append(9);

            Assert.Equal("{ 4 } -> { 7 } -> { 5 } -> { 9 } -> { 6 } -> NULL", LL_Challenges.mergeLists(list1, list2).ToString());
        }

        [Fact]
        public void MergeList1ShorterTest()
        {
            LinkedList list1 = new LinkedList();

            list1.Append(4);
            list1.Append(5);

            LinkedList list2 = new LinkedList();

            list2.Append(7);
            list2.Append(9);
            list2.Append(10);

            Assert.Equal("{ 4 } -> { 7 } -> { 5 } -> { 9 } -> { 10 } -> NULL", LL_Challenges.mergeLists(list1, list2).ToString());
        }

        [Fact]
        public void MergeList1EmptyTest()
        {
            LinkedList list1 = new LinkedList();


            LinkedList list2 = new LinkedList();

            list2.Append(7);
            list2.Append(9);

            Assert.Equal("{ 7 } -> { 9 } -> NULL", LL_Challenges.mergeLists(list1, list2).ToString());
        }
    }
}
