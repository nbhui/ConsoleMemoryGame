using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGameProj
{
    class MemoryGameLogics
    {
        public bool CheckIfEql(string i_FirstCard, string i_SecondCard)
        {
            bool equalizer = false;
            if(i_FirstCard == i_SecondCard)
            {
                equalizer = true;
            }
            return equalizer;
        }
        public static void SetPlayerTurn( MemoryGamePlayer o_PlayerOne, MemoryGamePlayer o_PlayerTwo)
        {
            if (o_PlayerOne.PlayerTurn == true && o_PlayerTwo.PlayerTurn == false)
            {
                o_PlayerOne.PlayerTurn = false;
                o_PlayerTwo.PlayerTurn = true;
            }
            else if (o_PlayerOne.PlayerTurn == false && o_PlayerTwo.PlayerTurn == true)
            {
                o_PlayerOne.PlayerTurn = true;
                o_PlayerTwo.PlayerTurn = false;
            }
            else
            {
                o_PlayerOne.PlayerTurn = true;
                o_PlayerTwo.PlayerTurn = false;
            }
        }

        public static void AddScore(MemoryGamePlayer o_PlayerOne, MemoryGamePlayer o_PlayerTwo)
        {
            if (o_PlayerOne.PlayerTurn == true)
            {               
                o_PlayerOne.PlayerScore = 1;
            }
            else if (o_PlayerTwo.PlayerTurn == true)
            {            
                o_PlayerTwo.PlayerScore = 1;
            }
        }
    }
}
