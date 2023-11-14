using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Score21
{
    public class Player
    {
        private Random random;
        public Control.ControlCollection Controls { get; set; }
        private PictureBox[] pictureBoxes = new PictureBox[0];
        private Label labelBank { get; set; }
        private Label labelScore { get; set; }
        private Label labelBid { get; set; }
        private bool Agreed { get; set; }
        public ulong Score { get; set; }
        public List<string> CardsPlayer { get; private set; } = new List<string>();
        public byte ScoreCards { get; private set; }
        public ulong StartScoreBanker { get; private set; }
        public ulong Bid { get; private set; }
        public bool Winner { get; set; }
        public bool Next = true;
        private int X { get; set; }
        private int Y { get; set; }

        public Player(ulong startScoreBanker, ref Random random, bool agreed, Label labelBank, Label labelScore, Label labelBid, Control.ControlCollection controls) 
        {
            Agreed = agreed;
            StartScoreBanker = startScoreBanker;
            this.random = random;
            Score = (ulong)this.random.Next((int)(0.5 * startScoreBanker), (int)(1.5 * startScoreBanker));
            labelBank.Text = Score.ToString();
            Controls = controls;
            this.labelBank = labelBank;
            this.labelScore = labelScore;
            this.labelBid = labelBid;
        }

        public void AddCards(byte numberCard)
        {
            CardsPlayer.Add(Cards.CardsName[numberCard]);
            if (ScoreCards > 11 && Agreed == true)
                ScoreCards += (byte)Cards.ArrayCardsAgreed[numberCard];
            else
                ScoreCards += (byte)Cards.ArrayCards[numberCard];

            if (ScoreCards > 11 && Agreed == false && ScoreCards < 19)
                Next = random.Next(0, 5) <= 1 ? true : false;
            else if (ScoreCards > 12 && Agreed == true && ScoreCards < 19)
                Next = random.Next(0, 5) <= 1 ? true : false;
            else if (ScoreCards >= 19 && ScoreCards < 21)
                Next = false;
            else if (ScoreCards == 21)
            {
                Next = false;
                Winner = true;
            }
            else if (CardsPlayer.Count == 2 && Cards.AceCards.Contains(CardsPlayer[0]) && Cards.AceCards.Contains(CardsPlayer[1]))
            {
                ScoreCards = 22;
                Next = false;
                Winner = true;
            }
            else if (CardsPlayer.Count == 3 && Cards.SevensCards.Contains(CardsPlayer[0]) && Cards.SevensCards.Contains(CardsPlayer[1]) && Cards.SevensCards.Contains(CardsPlayer[2]))
            {
                Next = false;
                Winner = true;
            }
            else if (CardsPlayer.Count == 5 && Cards.CanvasCards.Contains(CardsPlayer[0]) && Cards.CanvasCards.Contains(CardsPlayer[1]) && Cards.CanvasCards.Contains(CardsPlayer[2]) && Cards.CanvasCards.Contains(CardsPlayer[3]) && Cards.CanvasCards.Contains(CardsPlayer[4]))
            {
                Bid *= 2;
                Next = false;
                Winner = true;
            }
            else if (ScoreCards > 21)
            {
                Next = false;
                Winner = false;
            }
            else
                Next = true;

            if (!Next)
            {
                labelScore.Text = ScoreCards.ToString();
                ScoreCards = 0;
            }

            AddPictureBox(Cards.CardsName[numberCard]);
        }

        public void MakeBid()
        {
            if (Score > 0.2 * StartScoreBanker)
                Bid = (ulong)random.Next((int)(0.15 * StartScoreBanker), (int)(0.2 * StartScoreBanker));
            else
                Bid = Score;

            labelBid.Text = Bid.ToString();
        }

        public void NewStep()
        {
            if (Score > 0)
                Next = true;
            Winner = false;
            Bid = 0;
            ScoreCards = 0;
            CardsPlayer.Clear();
            X = 0;
            Y = 0;
            labelScore.Text = null;
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Dispose();
            }
        }

        private void AddPictureBox(string nameCard)
        {
            if (labelBank.Name == "BankFirstPlayeer")
            {
                X = (458 + pictureBoxes.Length * 70);
                Y = 100;
            }
            else if (labelBank.Name == "BankSecondPlayeer")
            {
                X = (166 + pictureBoxes.Length * 70);
                Y = 220;
            }
            else if (labelBank.Name == "BankThirdPlayeer")
            {
                X = (717 + pictureBoxes.Length * 70);
                Y = 220;
            }

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile($"Images\\{nameCard}.jpg");
            pictureBox.Location = new Point(X, Y);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new Size(68, 119);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(pictureBox);

            byte countCards = (byte)CardsPlayer.Count;
            Array.Resize(ref pictureBoxes, countCards);
            pictureBoxes[countCards - 1] = pictureBox;
        }
    }
}
