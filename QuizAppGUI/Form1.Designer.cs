namespace QuizAppGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ComboBox comboBoxQuizTypes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.GroupBox groupBoxQuiz;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxImagine;
        private System.Windows.Forms.Button btnLeaderboard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.comboBoxQuizTypes = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.groupBoxQuiz = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxImagine = new System.Windows.Forms.PictureBox();
            this.btnLeaderboard = new System.Windows.Forms.Button();

            this.groupBoxQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagine)).BeginInit();
            this.SuspendLayout();

            void StyleMinimalButton(System.Windows.Forms.Button btn)
            {
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
                btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.Height = 40;
                btn.Width = 170;
            }

            // pictureBoxLogo
            this.pictureBoxLogo.Location = new System.Drawing.Point(250, 40);
            this.pictureBoxLogo.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.Image = System.Drawing.Image.FromFile("Resources/logo.png");
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // comboBoxQuizTypes
            this.comboBoxQuizTypes.Location = new System.Drawing.Point(300, 350);
            this.comboBoxQuizTypes.Size = new System.Drawing.Size(200, 24);
            this.comboBoxQuizTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(300, 450);
            this.btnStart.Text = "Start Quiz";
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            StyleMinimalButton(this.btnStart);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnAddQuestion
            this.btnAddQuestion.Location = new System.Drawing.Point(300, 550);
            this.btnAddQuestion.Text = "Adaugă întrebare";
            this.btnAddQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            StyleMinimalButton(this.btnAddQuestion);
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);

            // textBoxSearch
            this.textBoxSearch.Location = new System.Drawing.Point(30, 75);
            this.textBoxSearch.Size = new System.Drawing.Size(300, 22);
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSearch.Visible = false;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(340, 70);
            this.btnSearch.Size = new System.Drawing.Size(130, 35);
            this.btnSearch.Text = "Caută întrebare";
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Visible = false;
            StyleMinimalButton(this.btnSearch);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnUpdateQuestion
            this.btnUpdateQuestion.Location = new System.Drawing.Point(520, 70);
            this.btnUpdateQuestion.Size = new System.Drawing.Size(170, 35);
            this.btnUpdateQuestion.Text = "Actualizează întrebare";
            this.btnUpdateQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdateQuestion.Visible = false;
            StyleMinimalButton(this.btnUpdateQuestion);
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);

            // btnLeaderboard
            this.btnLeaderboard.Location = new System.Drawing.Point(300, 650);
            this.btnLeaderboard.Size = new System.Drawing.Size(200, 40);
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            StyleMinimalButton(this.btnLeaderboard);
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);

            // groupBoxQuiz
            this.groupBoxQuiz.Controls.Add(this.lblQuestion);
            this.groupBoxQuiz.Controls.Add(this.radioButtonA);
            this.groupBoxQuiz.Controls.Add(this.radioButtonB);
            this.groupBoxQuiz.Controls.Add(this.radioButtonC);
            this.groupBoxQuiz.Controls.Add(this.radioButtonD);
            this.groupBoxQuiz.Controls.Add(this.btnSubmit);
            this.groupBoxQuiz.Controls.Add(this.pictureBoxImagine);
            this.groupBoxQuiz.Location = new System.Drawing.Point(30, 120);
            this.groupBoxQuiz.Size = new System.Drawing.Size(740, 500); 
            this.groupBoxQuiz.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxQuiz.Visible = false;

            // lblQuestion
            this.lblQuestion.Location = new System.Drawing.Point(20, 20);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblQuestion.Size = new System.Drawing.Size(700, 40);
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // radioButtonA
            this.radioButtonA.Location = new System.Drawing.Point(20, 80);
            this.radioButtonA.Size = new System.Drawing.Size(700, 30);
            this.radioButtonA.Font = new System.Drawing.Font("Segoe UI", 10F);

            // radioButtonB
            this.radioButtonB.Location = new System.Drawing.Point(20, 120);
            this.radioButtonB.Size = new System.Drawing.Size(700, 30);
            this.radioButtonB.Font = new System.Drawing.Font("Segoe UI", 10F);

            // radioButtonC
            this.radioButtonC.Location = new System.Drawing.Point(20, 160);
            this.radioButtonC.Size = new System.Drawing.Size(700, 30);
            this.radioButtonC.Font = new System.Drawing.Font("Segoe UI", 10F);

            // radioButtonD
            this.radioButtonD.Location = new System.Drawing.Point(20, 200);
            this.radioButtonD.Size = new System.Drawing.Size(700, 30);
            this.radioButtonD.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(20, 250);
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.Text = "Răspunde";
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.groupBoxQuiz.Controls.Add(this.btnSubmit);

            // pictureBoxImagine
            this.pictureBoxImagine.Location = new System.Drawing.Point(350, 300);
            this.pictureBoxImagine.Size = new System.Drawing.Size(360, 180);
            this.pictureBoxImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;


            // lblTimer
            this.lblTimer.Location = new System.Drawing.Point(600, 30);
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Text = "Timp rămas:";
            this.lblTimer.Visible = false;

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.comboBoxQuizTypes);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdateQuestion);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBoxQuiz);
            this.Controls.Add(this.btnLeaderboard);
            this.Name = "Form1";
            this.Text = "Quiz App";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.groupBoxQuiz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

