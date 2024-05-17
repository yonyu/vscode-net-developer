namespace tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void Test2()
    {
        var value1 = 2;
        var value2 = 3;
        var result = value1 + value2;
        Assert.Equal(5, result);
    }
}