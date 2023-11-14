using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Score21
{
    public class Banker
    {
        private Control.ControlCollection Controls;
        private PictureBox[] pictureBoxes = new PictureBox[0];
        public bool Agreed { get; private set; }
        private Player[] PlayerCollection;
        public ulong Score { get; private set; }
        public List<string> CardsPlayer { get; private set; } = new List<string>();
        public byte ScoreCards { get; private set; }
        public bool Next = true;
        private int X { get; set; }
        private int Y = 440;

        public Banker(bool agreed, ref Player[] playCollection, ulong score, Control.ControlCollection controls) 
        {
            Controls = controls;
            Agreed = agreed;
            PlayerCollection = playCollection;
            Score = score;
        }

        public void TakeCard(byte numberCard)
        {
            CardsPlayer.Add(Cards.CardsName[numberCard]);
            if (ScoreCards > 11 && Agreed == true)
                ScoreCards += (byte)Cards.ArrayCardsAgreed[numberCard];
            else
                ScoreCards += (byte)Cards.ArrayCards[numberCard];

            if (ScoreCards >= 17)
                Next = false;

            AddPictureBox(Cards.CardsName[numberCard]);
        }

        public void CheckWinner()
        {
            for (int i = 0; i < PlayerCollection.Length; i++)
            {
                if (!PlayerCollection[i].Winner && PlayerCollection[i].ScoreCards > ScoreCards && PlayerCollection[i].ScoreCards < 21)
                {
                        PlayerCollection[i].Winner = true;
                }
            }
        }

        public void Payment()
        {
            for (int i = 0; i < PlayerCollection.Length; i++)
            {
                if (PlayerCollection[i].Winner)
                {
                    PlayerCollection[i].Score += PlayerCollection[i].Bid;
                    try 
                    { 
                        Score = checked(Score - PlayerCollection[i].Bid); 
                    }
                    catch
                    {
                        Score = 0;
                    }
                }
                else
                {
                    PlayerCollection[i].Score = PlayerCollection[i].Score - PlayerCollection[i].Bid;
                    Score += PlayerCollection[i].Bid;
                }
            }
        }

        private void AddPictureBox(string nameCard)
        {
            X = 420 + pictureBoxes.Length * 70;

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

        public void NewStep()
        {
            Next = true;
            ScoreCards = 0;
            CardsPlayer.Clear();
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Dispose();
            }
        }
    }
}
