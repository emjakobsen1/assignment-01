using Xunit;

namespace Assignment1.Tests;

public class GreaterCountTests
{
    [Fact]
    public void List_With_123456789_Greater_Than_4_Should_Return_5() {
        List<int> list = new List<int> {1,2,3,4,5,6,7,8,9};
        int output = GreaterCountMethods.GreaterCount<int,int>(list,4);
        Assert.Equal(5,output);
     }
    [Fact]
    public void List_With_123456789_Greater_Than_5_Should_Return_4() {
        List<string> list = new List<string> {"1","2","3","4","5","6","7","8","9"};
        int output = GreaterCountMethods.GreaterCountWithNakedTypeConstraint<string,string>(list,("5"));
        Assert.Equal(4,output);
     }
    
    
    
    /*
    [Theory]
    [InlineData(new List<int> {1,2,3,4,5,6,7,8,9}, (int)4, (int)5)]
    public void List_With_Arguments_Greater_Than_4_Should_Return_5(IEnumerable<T> someEnumerable, T x, int shouldBe) {
        
        int output = GreaterCountMethods.GreaterCount<T,T>(someEnumerable,x);
        Assert.Equal(shouldBe,output);
     }*/
}

