namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        Assert.Equal(16, Solution.IslandPerimeter([[0,1,0,0], [1,1,1,0], [0,1,0,0], [1,1,0,0]]));
        Assert.Equal(4, Solution.IslandPerimeter([[1]]));
        Assert.Equal(4, Solution.IslandPerimeter([[1,0]]));
    }
}