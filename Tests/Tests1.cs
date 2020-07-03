using System;
using System.Collections.Generic;
using Xunit;
using static GitHub_App.Solution;

namespace Tests
{
    public class Tests1
    {
        [Fact]
        public void Test1()
        {
            List<int> data = new List<int>() {0, 0, 1, 1, 3, 4, 6, 7, 8, 9, 9};
            string H = GetHours(ref data);
            string M = GetMinutes(ref data);
            string S = GetSeconds(ref data);

            Assert.Equal("19:49:38", $"{H}:{M}:{S}");
        }

        [Fact]
        public void Test2()
        {
            List<int> data = new List<int>() {0, 0, 1, 3, 4, 6, 7, 8, 9};
            string H = GetHours(ref data);
            string M = GetMinutes(ref data);
            string S = GetSeconds(ref data);

            Assert.Equal("19:47:37", $"{H}:{M}:{S}");
        }
    }
}
