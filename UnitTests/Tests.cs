using System;
using System.Threading.Tasks;
using Xunit;

namespace BeerApp.UnitTests{
    public class UnitTests{

        [Fact] //will always succeed
        public void TestPass()
        {
        int x = 4;
        Assert.Equal(4, x);
        }

        [Fact] //will always Fail
        public void TestFail()
        {
        int x = 5;
        Assert.Equal(4, x);
        }
    }
}