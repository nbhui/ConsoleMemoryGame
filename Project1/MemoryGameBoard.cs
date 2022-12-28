using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameProj
{
    public partial class MemoryGameBoard : Form
    {
        private List<String> BtnInfo = new List<String>();
        private bool m_IsNewGameFlag = true;
        public bool IsNewGame
        {
            get { return m_IsNewGameFlag; }
            set { m_IsNewGameFlag = value; }
        }

        private List<Button> l_BtnList = new List<Button>();
        public List<Button> BtnList
        {
            get { return l_BtnList; }
        }
                
        private Label m_PlayerTurn = new Label();
        public Label PlayerTurn
        {
            get { return m_PlayerTurn;}
        } 

        private Label m_PlayerScoreLb = new Label();
        public Label PlayerScoreLb
        {
            get { return m_PlayerScoreLb;}
        }
        
        private MemoryGameSettings m_GameBoardSettings = new MemoryGameSettings();
        public MemoryGameSettings GameBoardSettings
        {
            get { return m_GameBoardSettings; }
        }

        private List<Label> currPlayer = new List<Label>();
        public List<Label> CurrentPlayer
        {
            get { return currPlayer; }
        }                 

        public MemoryGameBoard()
        {
            Application.EnableVisualStyles();
            if (IsNewGame == true)
            {
                m_GameBoardSettings.ShowDialog();
            }
            else
            {
                this.Close();
            }
            InitializeComponent();
            CreateGameBoard();
        }

        private void CreateGameBoard()
        {
            InitButtons();
            InitPlayerTurnLabel();
            PlaceButtonsOnBoard();
            InitPlayersLabels();
            CreateBoardBySize();
        }

        private void InitButtons()
        {
            GameBoardSymbolsFiller();
            for (int i = 0; i < m_GameBoardSettings.GameBoardHeight*m_GameBoardSettings.GameBoardWidth; i++)
            {
                BtnList.Add(new Button()
                {
                    Name = BtnInfo[i],
                    Font = new Font("Arial", 14),
                });
            }
        }

        private void InitPlayerTurnLabel()
        {
            PlayerTurn.Top = (m_GameBoardSettings.GameBoardHeight) * 110 + 10;
            PlayerTurn.Left = 10;
            PlayerTurn.Height = 15;
            PlayerTurn.Name = "Turn:";
            PlayerTurn.Text = string.Format("Current Player: {0}", m_GameBoardSettings.PlayerOne.PlayerName);
            PlayerTurn.BackColor = Color.LightGreen;
            PlayerTurn.Width = PlayerTurn.Text.Length * 3 + 100;
            this.Controls.Add(PlayerTurn);
        }

        private void InitPlayersLabels()
        {
            currPlayer.Add(new Label() { Name = m_GameBoardSettings.PlayerOne.PlayerName });
            currPlayer.Add(new Label() { Name = m_GameBoardSettings.PlayerTwo.PlayerName });
    
            for (int i = 0; i < 2; i++)
            {
                this.currPlayer[i].Top = PlayerTurn.Top + 20+i*20;
                this.currPlayer[i].Left = 10;
                this.currPlayer[i].Text = this.currPlayer[i].Text = string.Format("{0}: 0 Pairs", currPlayer[i].Name);
                this.currPlayer[i].Width = this.currPlayer[i].Text.Length * 2 + 70;
                this.currPlayer[i].Height = 15;
                if (i == 0)
                {
                    this.currPlayer[i].BackColor = Color.LightGreen;
                }
                else if (i == 1)
                {
                    this.currPlayer[i].BackColor = Color.LightBlue;
                }
                this.Controls.Add(this.currPlayer[i]);
            }
            
        }

        private void CreateBoardBySize()
        {
            this.Bounds = new Rectangle(0, 0, this.Width + 10, this.Height + 10);
            this.CenterToScreen();

        }

        private void PlaceButtonsOnBoard()
        {           
            for (int col = 0; col < m_GameBoardSettings.GameBoardHeight; col++)
            {
                for (int row = 0; row < m_GameBoardSettings.GameBoardWidth; row++)
                {
                    BtnList[col * m_GameBoardSettings.GameBoardWidth + row].Left = col * 110 + 10;
                    BtnList[col * m_GameBoardSettings.GameBoardWidth + row].Top = row * 110 + 10;
                    BtnList[col * m_GameBoardSettings.GameBoardWidth + row].Width = 100;
                    BtnList[col * m_GameBoardSettings.GameBoardWidth + row].Height = 100;
                    //BtnList[col * m_GameBoardSettings.GameBoardWidth + row].Click += new EventHandler(LB_Click); //assign click handler
                    this.Controls.Add(BtnList[col * m_GameBoardSettings.GameBoardWidth + row]);                  
                }
            }            
        }

        private void GameBoardSymbolsFiller()
        {
            Random randomizer = new Random();
            int symbolAmount = (m_GameBoardSettings.GameBoardHeight * m_GameBoardSettings.GameBoardWidth) / 2;
            int[] symbolsLimitCounter = new int[symbolAmount];
            int randomSymbol;
            for (int i = 0; i < m_GameBoardSettings.GameBoardHeight * m_GameBoardSettings.GameBoardWidth; i++)
            {
                randomSymbol = randomizer.Next('A', 'A' + symbolAmount);
                while (symbolsLimitCounter[randomSymbol - 'A'] > 1)
                {
                    randomSymbol = randomizer.Next('A', 'A' + symbolAmount);
                }
                BtnInfo.Insert(i, string.Format("{0}", (char)randomSymbol));
                symbolsLimitCounter[randomSymbol - 'A']++;
            }
        }

        public void FormEnabler(bool i_IsAble)
        {
            this.Enabled = i_IsAble;
        }

        public void EndGameMsgBox(MemoryGamePlayer i_PlayerOne, MemoryGamePlayer i_PlayerTwo)
        {
            string msg = string.Format("{0} with {1} Pairs{4}{2} with {3} Pairs{5} Start a new game?",
                i_PlayerOne.PlayerName, i_PlayerOne.PlayerScore, i_PlayerTwo.PlayerName,
                i_PlayerTwo.PlayerScore, Environment.NewLine, Environment.NewLine);
            DialogResult result = MessageBox.Show(msg, "Congrats", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                this.Close();
            }
            else if (result == DialogResult.OK)
            {
                this.Close();
                new GameBoardInterface();
            }
        }

        

        //////////////////////////////

        //public void LB_Click(object sender, EventArgs e)
        //{
        //    Button clickedBtn = sender as Button;
        //    if (m_clickCounter == 0)
        //    {
        //        FirstBtnClick = clickedBtn;
        //        FirstBtnClick.Text = FirstBtnClick.Name;
        //        FirstBtnClick.Enabled = false;
        //        m_clickCounter++;
        //    }
        //    else if (m_clickCounter == 1)
        //    {
        //        SecondBtnClick = clickedBtn;
        //        SecondBtnClick.Text = SecondBtnClick.Name;
        //        SecondBtnClick.Enabled = false;
        //        this.Enabled = false;
        //        timer1.Start();
        //    }
        //}

        //private void MakeBtnImgs()
        //{
        //    for (int i = 0; i < BtnList.Count; i++)
        //    {
        //        BtnList[i].ImageList = new ImageList();
        //        BtnList[i].ImageList.ImageSize = new Size(100, 100);
        //        BtnList[i].ImageList.TransparentColor = Color.Orange;
        //        BtnList[i].ImageList.Images.Add(Image.FromFile("C:\\Users\\97252\\Pictures\\1.jpg"));
        //        BtnList[i].ImageList.Images.Add(Image.FromFile("C:\\Users\\97252\\Pictures\\2.jpg"));
        //        BtnList[i].ImageIndex = 0;
        //    }
        //}










    }
}
