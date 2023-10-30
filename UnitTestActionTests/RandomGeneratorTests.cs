namespace UnitTestActionTests
{
  using UnitTestAction;


  public class RandomGeneratorTests
  {
    [Fact]
    public void GenerateRandomNumber_ReturnNumberWithinSpecifiedRange()
    {
      // Arrange
      var min = 1;
      var max = 10;

      // Act
      var result = RandomGenerator.GenerateRandomNumber(min, max);

      // Assert
      Assert.InRange(result, min, max);
    }
  }
}
