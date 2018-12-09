using System;
using System.Threading.Tasks;
using Xunit;

namespace BeerApp.UnitTests{
    public class UnitTests{

        [Fact]
        public void TestName()
        {
        //Given
        int x = 4;
        //When
        
        //Then
        Assert.Equal(4, x);
        }
    }
}