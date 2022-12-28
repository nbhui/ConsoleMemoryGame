using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameProj
{
    public partial class MemoryGameSettings : Form
    {
        private int m_width = 4;      
        public int GameBoardWidth
        {
            get { return m_width; }
            set { m_width = value; }
        }

        private int m_height = 4;
        public int GameBoardHeight
        {
            get { return m_height; }
            set { m_height = value; }
        }



        private MemoryGamePlayer m_PlayerOne = new MemoryGamePlayer("Player1");
        public MemoryGamePlayer PlayerOne
        {
            get { return m_PlayerOne; }
            set
            {
                m_PlayerOne = value;
            }
        }

        private MemoryGamePlayer m_PlayerTwo = new MemoryGamePlayer("-computer-");
        public MemoryGamePlayer PlayerTwo
        {
            get { return m_PlayerTwo; }
            set
            {
                m_PlayerTwo = value;
            }
        }

        public MemoryGameSettings()
        {
            InitializeComponent();
        }

        
        private void boardSize_Click(object sender, EventArgs e)
        {
            m_height++;
            if (m_height == 7)
            {
                m_width++;
                m_height = 4;

                if (m_width == 7)
                {
                    m_width = 4;  
                }
            }
            if ((m_width * m_height) % 2 == 1)
            {
                m_height++;
            }
            boardSize.Text = String.Format("{0}x{1}", m_width, m_height);
        }

        private void firstPlayerNameBox_TextChanged(object sender, EventArgs e)
        {
            m_PlayerOne.PlayerName = firstPlayerNameBox.Text;
            if(m_PlayerOne.PlayerName == null)
            {
                m_PlayerOne.PlayerName = "Player1";
            }
        }

        private void secondPlayerNameBox_TextChanged(object sender, EventArgs e)
        {
            m_PlayerTwo.PlayerName = secondPlayerNameBox.Text;
            if (m_PlayerOne.PlayerName == null)
            {
                m_PlayerTwo.PlayerName = "Player2";
            }
        }

        private void pickOpponent_Click(object sender, EventArgs e)
        {
            if (secondPlayerNameBox.Enabled)
            {
                secondPlayerNameBox.Enabled = false;
                m_PlayerTwo.PlayerName = "-computer-";
                secondPlayerNameBox.Text = String.Format("{0}", m_PlayerTwo.PlayerName);
                pickOpponent.Text = "Against a Friend";
            }
            else
            {
                secondPlayerNameBox.Text = null;
                pickOpponent.Text = "Against Computer";
                secondPlayerNameBox.Enabled = true;
                m_PlayerTwo.PlayerName = "Player2";               
            }
        }


        private void startGame_Click(object sender, EventArgs e)
        {
            m_PlayerOne.PlayerTurn = true;
            this.Close();        
        }
       
    }
}
