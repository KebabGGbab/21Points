namespace Score21
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AgreedGame = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.CountPlayer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BankGameLabel = new System.Windows.Forms.Label();
            this.BankGame = new System.Windows.Forms.NumericUpDown();
            this.ScoreNowLabel = new System.Windows.Forms.Label();
            this.ScoreNow = new System.Windows.Forms.Label();
            this.PlayACard = new System.Windows.Forms.Button();
            this.BidOnMoveFirstLabel = new System.Windows.Forms.Label();
            this.FirstPlayer = new System.Windows.Forms.Label();
            this.SecondPlayer = new System.Windows.Forms.Label();
            this.ThirdPlayer = new System.Windows.Forms.Label();
            this.NowBankFirst = new System.Windows.Forms.Label();
            this.NowBankSecond = new System.Windows.Forms.Label();
            this.NowBankThird = new System.Windows.Forms.Label();
            this.BankFirstPlayeer = new System.Windows.Forms.Label();
            this.BankSecondPlayeer = new System.Windows.Forms.Label();
            this.BankThirdPlayeer = new System.Windows.Forms.Label();
            this.YouBanker = new System.Windows.Forms.Label();
            this.BidMoveFirst = new System.Windows.Forms.Label();
            this.ScoreCardsYouLabel = new System.Windows.Forms.Label();
            this.ScoreCardsYou = new System.Windows.Forms.Label();
            this.NowScoreSecond = new System.Windows.Forms.Label();
            this.NowScoreSecondLabel = new System.Windows.Forms.Label();
            this.NowScoreFirst = new System.Windows.Forms.Label();
            this.NowScoreFirstLabel = new System.Windows.Forms.Label();
            this.NowScoreThird = new System.Windows.Forms.Label();
            this.NowScoreThirdLabel = new System.Windows.Forms.Label();
            this.BidMoveSecond = new System.Windows.Forms.Label();
            this.BidOnMoveSecondLabel = new System.Windows.Forms.Label();
            this.BidMoveThird = new System.Windows.Forms.Label();
            this.BidOnMoveThirdLabel = new System.Windows.Forms.Label();
            this.StopGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankGame)).BeginInit();
            this.SuspendLayout();
            // 
            // AgreedGame
            // 
            this.AgreedGame.AutoSize = true;
            this.AgreedGame.Location = new System.Drawing.Point(2, 12);
            this.AgreedGame.Name = "AgreedGame";
            this.AgreedGame.Size = new System.Drawing.Size(126, 17);
            this.AgreedGame.TabIndex = 1;
            this.AgreedGame.Text = "Договорённая игра";
            this.AgreedGame.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(2, 113);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Играть";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CountPlayer
            // 
            this.CountPlayer.Location = new System.Drawing.Point(2, 48);
            this.CountPlayer.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CountPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPlayer.Name = "CountPlayer";
            this.CountPlayer.Size = new System.Drawing.Size(120, 20);
            this.CountPlayer.TabIndex = 3;
            this.CountPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество игроков:";
            // 
            // BankGameLabel
            // 
            this.BankGameLabel.AutoSize = true;
            this.BankGameLabel.Location = new System.Drawing.Point(-1, 71);
            this.BankGameLabel.Name = "BankGameLabel";
            this.BankGameLabel.Size = new System.Drawing.Size(98, 13);
            this.BankGameLabel.TabIndex = 5;
            this.BankGameLabel.Text = "Ваш банк на игру:";
            // 
            // BankGame
            // 
            this.BankGame.Location = new System.Drawing.Point(2, 87);
            this.BankGame.Maximum = new decimal(new int[] {
            -164888576,
            698491930,
            0,
            0});
            this.BankGame.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BankGame.Name = "BankGame";
            this.BankGame.Size = new System.Drawing.Size(120, 20);
            this.BankGame.TabIndex = 6;
            this.BankGame.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ScoreNowLabel
            // 
            this.ScoreNowLabel.AutoSize = true;
            this.ScoreNowLabel.Location = new System.Drawing.Point(582, 582);
            this.ScoreNowLabel.Name = "ScoreNowLabel";
            this.ScoreNowLabel.Size = new System.Drawing.Size(82, 13);
            this.ScoreNowLabel.TabIndex = 7;
            this.ScoreNowLabel.Text = "Текущий банк:";
            this.ScoreNowLabel.Visible = false;
            // 
            // ScoreNow
            // 
            this.ScoreNow.AutoSize = true;
            this.ScoreNow.Location = new System.Drawing.Point(671, 582);
            this.ScoreNow.Name = "ScoreNow";
            this.ScoreNow.Size = new System.Drawing.Size(0, 13);
            this.ScoreNow.TabIndex = 8;
            // 
            // PlayACard
            // 
            this.PlayACard.Location = new System.Drawing.Point(501, 577);
            this.PlayACard.Name = "PlayACard";
            this.PlayACard.Size = new System.Drawing.Size(75, 23);
            this.PlayACard.TabIndex = 9;
            this.PlayACard.Text = "Разыграть";
            this.PlayACard.UseVisualStyleBackColor = true;
            this.PlayACard.Visible = false;
            this.PlayACard.Click += new System.EventHandler(this.PlayACard_Click);
            // 
            // BidOnMoveFirstLabel
            // 
            this.BidOnMoveFirstLabel.AutoSize = true;
            this.BidOnMoveFirstLabel.Location = new System.Drawing.Point(528, 85);
            this.BidOnMoveFirstLabel.Name = "BidOnMoveFirstLabel";
            this.BidOnMoveFirstLabel.Size = new System.Drawing.Size(81, 13);
            this.BidOnMoveFirstLabel.TabIndex = 13;
            this.BidOnMoveFirstLabel.Text = "Ставка на ход:";
            this.BidOnMoveFirstLabel.Visible = false;
            // 
            // FirstPlayer
            // 
            this.FirstPlayer.AutoSize = true;
            this.FirstPlayer.Location = new System.Drawing.Point(568, 46);
            this.FirstPlayer.Name = "FirstPlayer";
            this.FirstPlayer.Size = new System.Drawing.Size(79, 13);
            this.FirstPlayer.TabIndex = 14;
            this.FirstPlayer.Text = "Первый игрок";
            this.FirstPlayer.Visible = false;
            // 
            // SecondPlayer
            // 
            this.SecondPlayer.AutoSize = true;
            this.SecondPlayer.Location = new System.Drawing.Point(315, 166);
            this.SecondPlayer.Name = "SecondPlayer";
            this.SecondPlayer.Size = new System.Drawing.Size(75, 13);
            this.SecondPlayer.TabIndex = 15;
            this.SecondPlayer.Text = "Второй игрок";
            this.SecondPlayer.Visible = false;
            // 
            // ThirdPlayer
            // 
            this.ThirdPlayer.AutoSize = true;
            this.ThirdPlayer.Location = new System.Drawing.Point(855, 166);
            this.ThirdPlayer.Name = "ThirdPlayer";
            this.ThirdPlayer.Size = new System.Drawing.Size(75, 13);
            this.ThirdPlayer.TabIndex = 16;
            this.ThirdPlayer.Text = "Третий игрок";
            this.ThirdPlayer.Visible = false;
            // 
            // NowBankFirst
            // 
            this.NowBankFirst.AutoSize = true;
            this.NowBankFirst.Location = new System.Drawing.Point(528, 59);
            this.NowBankFirst.Name = "NowBankFirst";
            this.NowBankFirst.Size = new System.Drawing.Size(82, 13);
            this.NowBankFirst.TabIndex = 17;
            this.NowBankFirst.Text = "Текущий банк:";
            this.NowBankFirst.Visible = false;
            // 
            // NowBankSecond
            // 
            this.NowBankSecond.AutoSize = true;
            this.NowBankSecond.Location = new System.Drawing.Point(273, 179);
            this.NowBankSecond.Name = "NowBankSecond";
            this.NowBankSecond.Size = new System.Drawing.Size(82, 13);
            this.NowBankSecond.TabIndex = 18;
            this.NowBankSecond.Text = "Текущий банк:";
            this.NowBankSecond.Visible = false;
            // 
            // NowBankThird
            // 
            this.NowBankThird.AutoSize = true;
            this.NowBankThird.Location = new System.Drawing.Point(809, 179);
            this.NowBankThird.Name = "NowBankThird";
            this.NowBankThird.Size = new System.Drawing.Size(82, 13);
            this.NowBankThird.TabIndex = 19;
            this.NowBankThird.Text = "Текущий банк:";
            this.NowBankThird.Visible = false;
            // 
            // BankFirstPlayeer
            // 
            this.BankFirstPlayeer.AutoSize = true;
            this.BankFirstPlayeer.Location = new System.Drawing.Point(616, 59);
            this.BankFirstPlayeer.Name = "BankFirstPlayeer";
            this.BankFirstPlayeer.Size = new System.Drawing.Size(0, 13);
            this.BankFirstPlayeer.TabIndex = 20;
            // 
            // BankSecondPlayeer
            // 
            this.BankSecondPlayeer.AutoSize = true;
            this.BankSecondPlayeer.Location = new System.Drawing.Point(361, 179);
            this.BankSecondPlayeer.Name = "BankSecondPlayeer";
            this.BankSecondPlayeer.Size = new System.Drawing.Size(0, 13);
            this.BankSecondPlayeer.TabIndex = 21;
            // 
            // BankThirdPlayeer
            // 
            this.BankThirdPlayeer.AutoSize = true;
            this.BankThirdPlayeer.Location = new System.Drawing.Point(898, 179);
            this.BankThirdPlayeer.Name = "BankThirdPlayeer";
            this.BankThirdPlayeer.Size = new System.Drawing.Size(0, 13);
            this.BankThirdPlayeer.TabIndex = 22;
            // 
            // YouBanker
            // 
            this.YouBanker.AutoSize = true;
            this.YouBanker.Location = new System.Drawing.Point(505, 561);
            this.YouBanker.Name = "YouBanker";
            this.YouBanker.Size = new System.Drawing.Size(68, 13);
            this.YouBanker.TabIndex = 23;
            this.YouBanker.Text = "Вы - Банкир";
            this.YouBanker.Visible = false;
            // 
            // BidMoveFirst
            // 
            this.BidMoveFirst.AutoSize = true;
            this.BidMoveFirst.Location = new System.Drawing.Point(616, 85);
            this.BidMoveFirst.Name = "BidMoveFirst";
            this.BidMoveFirst.Size = new System.Drawing.Size(0, 13);
            this.BidMoveFirst.TabIndex = 24;
            // 
            // ScoreCardsYouLabel
            // 
            this.ScoreCardsYouLabel.AutoSize = true;
            this.ScoreCardsYouLabel.Location = new System.Drawing.Point(582, 561);
            this.ScoreCardsYouLabel.Name = "ScoreCardsYouLabel";
            this.ScoreCardsYouLabel.Size = new System.Drawing.Size(81, 13);
            this.ScoreCardsYouLabel.TabIndex = 25;
            this.ScoreCardsYouLabel.Text = "Текущие очки:";
            this.ScoreCardsYouLabel.Visible = false;
            // 
            // ScoreCardsYou
            // 
            this.ScoreCardsYou.AutoSize = true;
            this.ScoreCardsYou.Location = new System.Drawing.Point(671, 561);
            this.ScoreCardsYou.Name = "ScoreCardsYou";
            this.ScoreCardsYou.Size = new System.Drawing.Size(0, 13);
            this.ScoreCardsYou.TabIndex = 26;
            // 
            // NowScoreSecond
            // 
            this.NowScoreSecond.AutoSize = true;
            this.NowScoreSecond.Location = new System.Drawing.Point(361, 192);
            this.NowScoreSecond.Name = "NowScoreSecond";
            this.NowScoreSecond.Size = new System.Drawing.Size(0, 13);
            this.NowScoreSecond.TabIndex = 28;
            // 
            // NowScoreSecondLabel
            // 
            this.NowScoreSecondLabel.AutoSize = true;
            this.NowScoreSecondLabel.Location = new System.Drawing.Point(273, 192);
            this.NowScoreSecondLabel.Name = "NowScoreSecondLabel";
            this.NowScoreSecondLabel.Size = new System.Drawing.Size(81, 13);
            this.NowScoreSecondLabel.TabIndex = 27;
            this.NowScoreSecondLabel.Text = "Текущие очки:";
            this.NowScoreSecondLabel.Visible = false;
            // 
            // NowScoreFirst
            // 
            this.NowScoreFirst.AutoSize = true;
            this.NowScoreFirst.Location = new System.Drawing.Point(616, 71);
            this.NowScoreFirst.Name = "NowScoreFirst";
            this.NowScoreFirst.Size = new System.Drawing.Size(0, 13);
            this.NowScoreFirst.TabIndex = 30;
            // 
            // NowScoreFirstLabel
            // 
            this.NowScoreFirstLabel.AutoSize = true;
            this.NowScoreFirstLabel.Location = new System.Drawing.Point(528, 72);
            this.NowScoreFirstLabel.Name = "NowScoreFirstLabel";
            this.NowScoreFirstLabel.Size = new System.Drawing.Size(81, 13);
            this.NowScoreFirstLabel.TabIndex = 29;
            this.NowScoreFirstLabel.Text = "Текущие очки:";
            this.NowScoreFirstLabel.Visible = false;
            // 
            // NowScoreThird
            // 
            this.NowScoreThird.AutoSize = true;
            this.NowScoreThird.Location = new System.Drawing.Point(898, 192);
            this.NowScoreThird.Name = "NowScoreThird";
            this.NowScoreThird.Size = new System.Drawing.Size(0, 13);
            this.NowScoreThird.TabIndex = 32;
            // 
            // NowScoreThirdLabel
            // 
            this.NowScoreThirdLabel.AutoSize = true;
            this.NowScoreThirdLabel.Location = new System.Drawing.Point(809, 192);
            this.NowScoreThirdLabel.Name = "NowScoreThirdLabel";
            this.NowScoreThirdLabel.Size = new System.Drawing.Size(81, 13);
            this.NowScoreThirdLabel.TabIndex = 31;
            this.NowScoreThirdLabel.Text = "Текущие очки:";
            this.NowScoreThirdLabel.Visible = false;
            // 
            // BidMoveSecond
            // 
            this.BidMoveSecond.AutoSize = true;
            this.BidMoveSecond.Location = new System.Drawing.Point(361, 205);
            this.BidMoveSecond.Name = "BidMoveSecond";
            this.BidMoveSecond.Size = new System.Drawing.Size(0, 13);
            this.BidMoveSecond.TabIndex = 34;
            // 
            // BidOnMoveSecondLabel
            // 
            this.BidOnMoveSecondLabel.AutoSize = true;
            this.BidOnMoveSecondLabel.Location = new System.Drawing.Point(273, 205);
            this.BidOnMoveSecondLabel.Name = "BidOnMoveSecondLabel";
            this.BidOnMoveSecondLabel.Size = new System.Drawing.Size(81, 13);
            this.BidOnMoveSecondLabel.TabIndex = 33;
            this.BidOnMoveSecondLabel.Text = "Ставка на ход:";
            this.BidOnMoveSecondLabel.Visible = false;
            // 
            // BidMoveThird
            // 
            this.BidMoveThird.AutoSize = true;
            this.BidMoveThird.Location = new System.Drawing.Point(898, 205);
            this.BidMoveThird.Name = "BidMoveThird";
            this.BidMoveThird.Size = new System.Drawing.Size(0, 13);
            this.BidMoveThird.TabIndex = 36;
            // 
            // BidOnMoveThirdLabel
            // 
            this.BidOnMoveThirdLabel.AutoSize = true;
            this.BidOnMoveThirdLabel.Location = new System.Drawing.Point(810, 205);
            this.BidOnMoveThirdLabel.Name = "BidOnMoveThirdLabel";
            this.BidOnMoveThirdLabel.Size = new System.Drawing.Size(81, 13);
            this.BidOnMoveThirdLabel.TabIndex = 35;
            this.BidOnMoveThirdLabel.Text = "Ставка на ход:";
            this.BidOnMoveThirdLabel.Visible = false;
            // 
            // StopGame
            // 
            this.StopGame.Location = new System.Drawing.Point(2, 142);
            this.StopGame.Name = "StopGame";
            this.StopGame.Size = new System.Drawing.Size(120, 23);
            this.StopGame.TabIndex = 37;
            this.StopGame.Text = "Остановить";
            this.StopGame.UseVisualStyleBackColor = true;
            this.StopGame.Click += new System.EventHandler(this.StopGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 689);
            this.Controls.Add(this.StopGame);
            this.Controls.Add(this.BidMoveThird);
            this.Controls.Add(this.BidOnMoveThirdLabel);
            this.Controls.Add(this.BidMoveSecond);
            this.Controls.Add(this.BidOnMoveSecondLabel);
            this.Controls.Add(this.NowScoreThird);
            this.Controls.Add(this.NowScoreThirdLabel);
            this.Controls.Add(this.NowScoreFirst);
            this.Controls.Add(this.NowScoreFirstLabel);
            this.Controls.Add(this.NowScoreSecond);
            this.Controls.Add(this.NowScoreSecondLabel);
            this.Controls.Add(this.ScoreCardsYou);
            this.Controls.Add(this.ScoreCardsYouLabel);
            this.Controls.Add(this.BidMoveFirst);
            this.Controls.Add(this.YouBanker);
            this.Controls.Add(this.BankThirdPlayeer);
            this.Controls.Add(this.BankSecondPlayeer);
            this.Controls.Add(this.BankFirstPlayeer);
            this.Controls.Add(this.NowBankThird);
            this.Controls.Add(this.NowBankSecond);
            this.Controls.Add(this.NowBankFirst);
            this.Controls.Add(this.ThirdPlayer);
            this.Controls.Add(this.SecondPlayer);
            this.Controls.Add(this.FirstPlayer);
            this.Controls.Add(this.BidOnMoveFirstLabel);
            this.Controls.Add(this.PlayACard);
            this.Controls.Add(this.ScoreNow);
            this.Controls.Add(this.ScoreNowLabel);
            this.Controls.Add(this.BankGame);
            this.Controls.Add(this.BankGameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountPlayer);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.AgreedGame);
            this.Name = "Form1";
            this.Text = "21 очко";
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox AgreedGame;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.NumericUpDown CountPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BankGameLabel;
        private System.Windows.Forms.NumericUpDown BankGame;
        private System.Windows.Forms.Label ScoreNowLabel;
        private System.Windows.Forms.Label ScoreNow;
        private System.Windows.Forms.Button PlayACard;
        private System.Windows.Forms.Label BidOnMoveFirstLabel;
        private System.Windows.Forms.Label FirstPlayer;
        private System.Windows.Forms.Label SecondPlayer;
        private System.Windows.Forms.Label ThirdPlayer;
        private System.Windows.Forms.Label NowBankFirst;
        private System.Windows.Forms.Label NowBankSecond;
        private System.Windows.Forms.Label NowBankThird;
        private System.Windows.Forms.Label BankFirstPlayeer;
        private System.Windows.Forms.Label BankSecondPlayeer;
        private System.Windows.Forms.Label BankThirdPlayeer;
        private System.Windows.Forms.Label YouBanker;
        private System.Windows.Forms.Label BidMoveFirst;
        private System.Windows.Forms.Label ScoreCardsYouLabel;
        private System.Windows.Forms.Label ScoreCardsYou;
        private System.Windows.Forms.Label NowScoreSecond;
        private System.Windows.Forms.Label NowScoreSecondLabel;
        private System.Windows.Forms.Label NowScoreFirst;
        private System.Windows.Forms.Label NowScoreFirstLabel;
        private System.Windows.Forms.Label NowScoreThird;
        private System.Windows.Forms.Label NowScoreThirdLabel;
        private System.Windows.Forms.Label BidMoveSecond;
        private System.Windows.Forms.Label BidOnMoveSecondLabel;
        private System.Windows.Forms.Label BidMoveThird;
        private System.Windows.Forms.Label BidOnMoveThirdLabel;
        private System.Windows.Forms.Button StopGame;
    }
}

