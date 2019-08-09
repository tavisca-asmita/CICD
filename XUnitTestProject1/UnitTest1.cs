using System;
using Xunit;
using CommandLineExecution;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program program = new Program();
            Assert.Equal(8, program.Add());
            
        }
    }
}
