using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsTestDemoSln.Models;
using Xunit;

namespace VsTechDemoSln.Tests
{
    public class MathTest
    {
        [Fact]
        public void AddTest()
        {
            var model = new Calculate();
            var result = model.add(10, 10);
            Assert.True(result == 20);
        }

        [Fact]
        public void SubtractTest()
        {
            var model = new Calculate();
            var result = model.subtract(100, 10);
            Assert.True(result == 90);
        }

    }
}
