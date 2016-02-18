using Xunit;
namespace  Scrabbles
{
  public class ScrabbleTest
  {

    [Fact]
    public void ScoreString_ForConditionQueen_tochararray()
    {
      Scrabble newScrabble = new Scrabble("queen");
      Assert.Equal(14, newScrabble.Scorer());
    }

    [Fact]
    public void ScoreString_ForConditionDog_tochararray()
    {
      Scrabble newScrabble = new Scrabble("dog");
      Assert.Equal(5, newScrabble.Scorer());
    }

    [Fact]
    public void ScoreString_ForConditionJester_tochararray()
    {
      Scrabble newScrabble = new Scrabble("jester");
      Assert.Equal(13, newScrabble.Scorer());
    }
  }
}
