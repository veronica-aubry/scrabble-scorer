using System;
using System.Linq;
using System.Collections.Generic;

namespace Scrabbles

{

//   //variables//
//
  public class Scrabble
  {
    // private string _input;
    private char[] _inputArray;
    private int _scrabbleTotal;
    private string _input;
    private static char [] oneScore  = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
    private static char [] twoScore =  {'D', 'G'};
    private static char [] threeScore =  {'B', 'C', 'M', 'P'};
    private static char [] fourScore =  {'F', 'H', 'V', 'W', 'Y'};
    private static char [] fiveScore =  {'K'};
    private static char [] eightScore =  {'J', 'X'};
    private static char [] tenScore =    {'Q', 'Z'};

    public static Dictionary<int,char[]> _scrabbleScores = new Dictionary<int, char[]>
    {
      {1, oneScore},
      {2, twoScore},
      {3, threeScore},
      {4, fourScore},
      {5, fiveScore},
      {8, eightScore},
      {10, tenScore},
    };

    public Scrabble(string input)
    {
      _input = input.ToUpper();
      _inputArray = _input.ToCharArray();
      _scrabbleTotal = 0;
    }

    public int GetTotal()
    {
      return _scrabbleTotal;
    }

    public string GetWord()
    {
      return _input;
    }


    public int Scorer()
    {
      foreach(KeyValuePair<int, char[]> score in _scrabbleScores)
      {
        for (int i = 0; i < score.Value.Length; i++)
        {
          foreach(char letter in _inputArray) {
            if (letter == score.Value[i])
            {
              _scrabbleTotal = _scrabbleTotal + score.Key;
            }
          }
        }
      }
      return _scrabbleTotal;
    }
  }
}
