using System;
using System.Windows.Forms;

namespace Score21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Random = new Random();
        public byte CountPlayers { get; private set; }
        public bool Agreed { get; private set; }
        public ulong Score { get; private set; }

        public Player firstPlayer = null;
        public Player secondPlayer = null;
        public Player thirdPlayer = null;

        public Banker banker;

        public Player[] playersCollection;

        private sbyte NowPlayer { get; set; } = 0;

        private void Start_Click(object sender, EventArgs e)
        {
            PlayACard.Visible = true;
            ScoreNowLabel.Visible = true;
            BidMoveFirst.Visible = true;
            ScoreCardsYouLabel.Visible = true;
            YouBanker.Visible = true;
            AgreedGame.Enabled = false;
            CountPlayer.Enabled = false;
            BankGame.Enabled = false;
            PlayACard.Enabled = true;
            Start.Enabled = false;
            StopGame.Enabled = true;

            Agreed = AgreedGame.Checked;
            Score = (ulong)BankGame.Value;
            CountPlayers = (byte)CountPlayer.Value;

            ScoreNow.Text = BankGame.Value.ToString();


            playersCollection = new Player[CountPlayers];

            switch (CountPlayers)
            {
                case 1:
                    FirstPlayer.Visible = true;
                    SecondPlayer.Visible = false;
                    ThirdPlayer.Visible = false;
                    firstPlayer = new Player(Score, ref Random, Agreed, BankFirstPlayeer, NowScoreFirst, BidMoveFirst, Controls);
                    playersCollection[0] = firstPlayer;
                    NowBankFirst.Visible = true;
                    NowBankSecond.Visible = false;
                    NowBankThird.Visible = false;
                    NowScoreFirstLabel.Visible = true;
                    NowScoreSecondLabel.Visible = false;
                    NowScoreThirdLabel.Visible = false;
                    BidOnMoveFirstLabel.Visible = true;
                    BidOnMoveSecondLabel.Visible = false;
                    BidOnMoveThirdLabel.Visible = false;
                    break;
                case 2:
                    FirstPlayer.Visible = true;
                    SecondPlayer.Visible = true;
                    ThirdPlayer.Visible = false;
                    firstPlayer = new Player(Score, ref Random, Agreed, BankFirstPlayeer, NowScoreFirst, BidMoveFirst, Controls);
                    secondPlayer = new Player(Score, ref Random, Agreed, BankSecondPlayeer, NowScoreSecond, BidMoveSecond, Controls);
                    playersCollection[0] = firstPlayer;
                    playersCollection[1] = secondPlayer;
                    NowBankFirst.Visible = true;
                    NowBankSecond.Visible = true;
                    NowBankThird.Visible = false;
                    NowScoreFirstLabel.Visible = true;
                    NowScoreSecondLabel.Visible = true;
                    NowScoreThirdLabel.Visible = false;
                    BidOnMoveFirstLabel.Visible = true;
                    BidOnMoveSecondLabel.Visible = true;
                    BidOnMoveThirdLabel.Visible = false;
                    break;
                case 3:
                    FirstPlayer.Visible = true;
                    SecondPlayer.Visible = true;
                    ThirdPlayer.Visible = true;
                    firstPlayer = new Player(Score, ref Random, Agreed, BankFirstPlayeer, NowScoreFirst, BidMoveFirst, Controls);
                    secondPlayer = new Player(Score, ref Random, Agreed, BankSecondPlayeer, NowScoreSecond, BidMoveSecond, Controls);
                    thirdPlayer = new Player(Score, ref Random, Agreed, BankThirdPlayeer, NowScoreThird, BidMoveThird, Controls);
                    playersCollection[0] = firstPlayer;
                    playersCollection[1] = secondPlayer;
                    playersCollection[2] = thirdPlayer;
                    NowBankFirst.Visible = true;
                    NowBankSecond.Visible = true;
                    NowBankThird.Visible = true;
                    NowScoreFirstLabel.Visible = true;
                    NowScoreSecondLabel.Visible = true;
                    NowScoreThirdLabel.Visible = true;
                    BidOnMoveFirstLabel.Visible = true;
                    BidOnMoveSecondLabel.Visible = true;
                    BidOnMoveThirdLabel.Visible = true;
                    break;
            }

            banker = new Banker(Agreed, ref playersCollection, Score, Controls);
        }

        private void PlayACard_Click(object sender, EventArgs e)
        {
            if (NowPlayer > -1 && playersCollection[NowPlayer].Next == false)
            {
                if (NowPlayer < playersCollection.Length - 1)
                    NowPlayer++;
                else
                {
                    NowPlayer = -1;
                }
            }
            if (NowPlayer != -1 && playersCollection[NowPlayer].Next)
            {
                if (playersCollection[NowPlayer].Bid == 0)
                {
                    playersCollection[NowPlayer].MakeBid();
                }

                byte nextCard = (byte)Random.Next(1, 37);
                playersCollection[NowPlayer].AddCards((byte)(nextCard - 1));
            }
            else if (NowPlayer == -1)
            {
                if (banker.Next)
                {
                    byte nextCard = (byte)Random.Next(1, 37);
                    banker.TakeCard((byte)(nextCard - 1));
                    ScoreCardsYou.Text = banker.ScoreCards.ToString();
                }
                else
                {
                    NowPlayer = 0;

                    banker.CheckWinner();
                    banker.Payment();

                    for (int i = 0; i < playersCollection.Length; i++)
                    {
                        playersCollection[i].NewStep();
                    }

                    banker.NewStep();

                    ScoreCardsYou.Text = null;

                    Score = banker.Score;
                    ScoreNow.Text = Score.ToString();

                    if (playersCollection.Length >= 1)
                        BankFirstPlayeer.Text = playersCollection[0].Score.ToString();
                    if (playersCollection.Length >= 2)
                        BankSecondPlayeer.Text = playersCollection[1].Score.ToString();
                    if (playersCollection.Length == 3)
                        BankThirdPlayeer.Text = playersCollection[2].Score.ToString();

                    if (Score <= 0)
                        MessageBox.Show("Игра закончена! Вы проиграли!");
                    else if ((CountPlayers == 1 && playersCollection[0].Score == 0) || (CountPlayers == 2 && playersCollection[0].Score == 0 && playersCollection[1].Score == 0) || (CountPlayers == 3 && playersCollection[0].Score == 0 && playersCollection[1].Score == 0 && playersCollection[2].Score == 0))
                    {
                        if (DialogResult.OK == MessageBox.Show("Игра закончена! Ура! Вы выиграли!", "Выигрыш", MessageBoxButtons.OK, MessageBoxIcon.Error))
                        {
                            banker.NewStep();
                        }
                    }
                }
            }
        }

        private void StopGame_Click(object sender, EventArgs e)
        {
            StopGame.Enabled = false;
            AgreedGame.Enabled = true;
            CountPlayer.Enabled = true;
            BankGame.Enabled = true;
            PlayACard.Enabled = false;
            Start.Text = "Начать заново";
            Start.Enabled = true;
            BankFirstPlayeer.Text = null;
            BankSecondPlayeer.Text = null;
            BankThirdPlayeer.Text = null;
            NowScoreFirst.Text = null;
            NowScoreSecond.Text = null;
            NowScoreThird.Text = null;
            BidMoveFirst.Text = null;
            BidMoveSecond.Text = null;
            BidMoveThird.Text = null;
            for (int i = 0; i < playersCollection.Length; i++)
            {
                playersCollection[i].NewStep();
                playersCollection[i] = null;
            }
            banker.NewStep();
        }
    }
}
