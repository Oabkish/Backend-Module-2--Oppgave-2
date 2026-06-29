namespace Tests;

public class ContainerTests
{
  [Fact]
  public void TestName()
  {
    // Given
  
    // When
  
    // Then
  }
    public void Store_AddsItem_GetItem_ReturnsLastItem()
    {
    var box = new Core.Container<string>();
        box.Store("Hello");
        box.Store("World");
        var result = box.GetItem();
        Assert.Equal("World", result);

    }   

[Fact]
    public void Store_IncreasesCount()
    {  var box = new Core.Container<string>();
        box.Store("Hello");
        var result = box.Count;
        Assert.Equal(1, result);
    }

[Fact]
    public void Pop_OnEmptyContainer_ThrowsException()
    {   var box = new Core.Container<string>();
        Assert.Throws<IndexOutOfRangeException>(box.Pop);
    }
[Theory]
    [InlineData("Hello")]
    [InlineData("World")]
    [InlineData("Test")]
    public void Store_ThenGetItem_ReturnsCorrectItem(string input)
    {
    var box = new Core.Container<string>();
    box.Store(input);
    var result = box.GetItem();
    Assert.Equal(input, result);
    }
}