using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsConsole2
{
    public class Round
  {
    public string P1Choice { get; set; } // User choice

    public string P2Choice { get; set; } // Computer choice

    public int player1wins
    {
      get
      {
        return player1wins;
      }
     set
      {
        player1wins++;
      }
    }

    public int computerWins
    {
      get
      {
        return computerWins;
      }
      set
      {
        computerWins++;
      }
    }

  }

}
