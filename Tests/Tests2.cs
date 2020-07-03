using System;
using System.Collections.Generic;
using Xunit;
using static GitHub_App.Solution;

namespace Tests
{
    public class Tests2
    {
        [Fact]
        public void Test3()
        {
            List<int> data = new List<int>() {0, 0, 1, 1, 3, 5, 6, 7, 7};
            string H = GetHours(ref data);
            string M = GetMinutes(ref data);
            string S = GetSeconds(ref data);

            Assert.Equal("17:57:36", $"{H}:{M}:{S}");
        }
    }
}