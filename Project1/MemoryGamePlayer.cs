using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGameProj
{
    public class MemoryGamePlayer
    {
        private string m_PlayerName;
        private int m_PlayerScore = 0;
        private bool m_PlayerTurn = false;

        public MemoryGamePlayer(string playerName)
        {
            this.m_PlayerName = playerName;
        }

        public string PlayerName
        {
            get { return m_PlayerName; }
            set { m_PlayerName = value; }
        }

        public int PlayerScore
        {
            get { return m_PlayerScore; }
            set { m_PlayerScore += value; }
        }

        public bool PlayerTurn
        {
            get { return m_PlayerTurn; }
            set
            {
                m_PlayerTurn = value;
            }
        }
    }
}
