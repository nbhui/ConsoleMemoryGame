using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MemoryGameProj
{
    public class GameBoardInterface
    {
        private int m_clickCounter;
        Button m_FirstBtnClick;
        Button m_SecondBtnClick;
        MemoryGameBoard m_CurrGameBoard = new MemoryGameBoard();
        Timer m_timeHolder = new Timer();
        MemoryGameLogics m_GameLogics = new MemoryGameLogics();
        Random m_Random = new Random();
        List<Button> m_Btns;


        public GameBoardInterface()
        {
            m_Btns = new List<Button> (m_CurrGameBoard.BtnList) ;
            CreateClickAndTimerEvent();
            m_CurrGameBoard.ShowDialog();
        }


        private void CreateClickAndTimerEvent()
        {
            foreach (Button Btn in m_CurrGameBoard.BtnList)
            {
                Btn.Click += new EventHandler(LB_Click);
            }

            m_timeHolder.Interval = 1000;
            m_timeHolder.Tick += new EventHandler(TimeHolder_Tick);
        }

        public void LB_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            
            if (m_clickCounter == 0)
            {
                m_FirstBtnClick = clickedBtn;
                m_FirstBtnClick.Text = m_FirstBtnClick.Name;
                m_FirstBtnClick.Enabled = false;
                m_clickCounter++;
                m_Btns.Remove(m_FirstBtnClick);
                if (m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerName.Equals("-computer-") &&
                     m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerTurn == true)
                {
                    computerTurn(m_Btns);
                    return;
                }
            }
            else if (m_clickCounter == 1)
            {
                m_SecondBtnClick = clickedBtn;
                m_SecondBtnClick.Text = m_SecondBtnClick.Name;
                m_SecondBtnClick.Enabled = false;
                m_CurrGameBoard.FormEnabler(false);
                m_timeHolder.Start();

            }
        }

        private void TimeHolder_Tick(object sender, EventArgs e)
        {
            m_timeHolder.Stop();
            m_clickCounter = 0;
            if (m_GameLogics.CheckIfEql(m_FirstBtnClick.Name, m_SecondBtnClick.Name))
            {
                MemoryGameLogics.AddScore(m_CurrGameBoard.GameBoardSettings.PlayerOne, m_CurrGameBoard.GameBoardSettings.PlayerTwo);
                ColoredIfCurrect();
                m_Btns.Remove(m_FirstBtnClick);
                m_Btns.Remove(m_SecondBtnClick);
                CheckIfEndGame();
            }
            else
            {
                m_Btns.Add(m_FirstBtnClick);
                m_FirstBtnClick.Text = null;
                m_SecondBtnClick.Text = null;
                m_FirstBtnClick.Enabled = true;
                m_SecondBtnClick.Enabled = true;
                MemoryGameLogics.SetPlayerTurn(m_CurrGameBoard.GameBoardSettings.PlayerOne,
                m_CurrGameBoard.GameBoardSettings.PlayerTwo);
            }
            m_FirstBtnClick = null;
            m_SecondBtnClick = null;               
            m_CurrGameBoard.FormEnabler(true);
            
            
            if (m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerName.Equals("-computer-") &&
                     m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerTurn == true)
            {
                computerTurn(m_Btns);
                return;
            }
            ShowScoreOnBoard();
            CurrentTurnLblModifier();
        }

        private void computerTurn(List<Button> btnList)
        {
            int currRand = m_Random.Next(0, btnList.Count);
            btnList[currRand].PerformClick();

        }

        private void CurrentTurnLblModifier()
        {
            if (m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerTurn == false)
            {
                m_CurrGameBoard.PlayerTurn.Text = string.Format("Current Player: {0}", m_CurrGameBoard.GameBoardSettings.PlayerOne.PlayerName);
                m_CurrGameBoard.PlayerTurn.BackColor = m_CurrGameBoard.CurrentPlayer.ElementAt(0).BackColor;
                
            }
            else if (m_CurrGameBoard.GameBoardSettings.PlayerOne.PlayerTurn == false)
            {
                m_CurrGameBoard.PlayerTurn.Text = string.Format("Current Player: {0}", m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerName);
                m_CurrGameBoard.PlayerTurn.BackColor = m_CurrGameBoard.CurrentPlayer.ElementAt(1).BackColor;               
            }
        }

        private void ShowScoreOnBoard()
        {
            m_CurrGameBoard.CurrentPlayer.ElementAt(0).Text = string.Format("{0}: {1} Pairs", m_CurrGameBoard.CurrentPlayer.ElementAt(0).Name, m_CurrGameBoard.GameBoardSettings.PlayerOne.PlayerScore);
            m_CurrGameBoard.CurrentPlayer.ElementAt(1).Text = string.Format("{0}: {1} Pairs", m_CurrGameBoard.CurrentPlayer.ElementAt(1).Name, m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerScore);
        }
       
        private void CheckIfEndGame()
        {
            if (m_CurrGameBoard.GameBoardSettings.PlayerOne.PlayerScore + m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerScore == (m_CurrGameBoard.BtnList.Count / 2))
            {
                m_CurrGameBoard.EndGameMsgBox(m_CurrGameBoard.GameBoardSettings.PlayerOne, m_CurrGameBoard.GameBoardSettings.PlayerTwo);                
            }
        }

        private void ColoredIfCurrect()
        {
            if (m_CurrGameBoard.GameBoardSettings.PlayerOne.PlayerTurn == true)
            {
                m_FirstBtnClick.BackColor = Color.LightGreen;
                m_SecondBtnClick.BackColor = Color.LightGreen;
            }
            else if (m_CurrGameBoard.GameBoardSettings.PlayerTwo.PlayerTurn == true)
            {
                m_FirstBtnClick.BackColor = Color.LightBlue;
                m_SecondBtnClick.BackColor = Color.LightBlue;
            }
        }
    }
}
