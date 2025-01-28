namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void FalseisFalse()
    {
        // this was stupid 
        Assert.False(false);
        Assert.true(!false);
    }
}
