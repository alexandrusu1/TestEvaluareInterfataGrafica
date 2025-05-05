// Form1.Designer.cs
namespace QuizAppGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxQuizTypes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBoxQuiz;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBoxImagine;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxQuizTypes = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
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

            this.groupBoxQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagine)).BeginInit();
            this.SuspendLayout();

            void StyleButton(System.Windows.Forms.Button btn)
            {
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btn.FlatAppearance.BorderSize = 0;
                btn.Height = 35;
            }

            // comboBoxQuizTypes
            this.comboBoxQuizTypes.Location = new System.Drawing.Point(30, 30);
            this.comboBoxQuizTypes.Size = new System.Drawing.Size(200, 24);
            this.comboBoxQuizTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(250, 30);
            this.btnStart.Size = new System.Drawing.Size(130, 35);
            this.btnStart.Text = "Start Quiz";
            this.btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            StyleButton(this.btnStart);

            // btnAddQuestion
            this.btnAddQuestion.Location = new System.Drawing.Point(390, 30);
            this.btnAddQuestion.Size = new System.Drawing.Size(150, 35);
            this.btnAddQuestion.Text = "Adaugă întrebare";
            this.btnAddQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            StyleButton(this.btnAddQuestion);

            // textBoxSearch
            this.textBoxSearch.Location = new System.Drawing.Point(30, 75);
            this.textBoxSearch.Size = new System.Drawing.Size(300, 22);
            this.textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(340, 70);
            this.btnSearch.Size = new System.Drawing.Size(130, 35);
            this.btnSearch.Text = "Caută întrebare";
            this.btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            StyleButton(this.btnSearch);

            // groupBoxQuiz
            this.groupBoxQuiz.Controls.Add(this.lblQuestion);
            this.groupBoxQuiz.Controls.Add(this.radioButtonA);
            this.groupBoxQuiz.Controls.Add(this.radioButtonB);
            this.groupBoxQuiz.Controls.Add(this.radioButtonC);
            this.groupBoxQuiz.Controls.Add(this.radioButtonD);
            this.groupBoxQuiz.Controls.Add(this.btnSubmit);
            this.groupBoxQuiz.Controls.Add(this.pictureBoxImagine);
            this.groupBoxQuiz.Location = new System.Drawing.Point(30, 120);
            this.groupBoxQuiz.Size = new System.Drawing.Size(740, 300);
            this.groupBoxQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.groupBoxQuiz.Visible = false;

            // lblQuestion
            this.lblQuestion.Location = new System.Drawing.Point(20, 20);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(640, 0);
            this.lblQuestion.Size = new System.Drawing.Size(640, 40);
            this.lblQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // radioButtons
            this.radioButtonA.Location = new System.Drawing.Point(20, 70);
            this.radioButtonB.Location = new System.Drawing.Point(20, 110);
            this.radioButtonC.Location = new System.Drawing.Point(20, 150);
            this.radioButtonD.Location = new System.Drawing.Point(20, 190);
            this.radioButtonA.Size = this.radioButtonB.Size = this.radioButtonC.Size = this.radioButtonD.Size = new System.Drawing.Size(300, 24);
            this.radioButtonA.Anchor = this.radioButtonB.Anchor = this.radioButtonC.Anchor = this.radioButtonD.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(20, 230);
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.Text = "Răspunde";
            this.btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            StyleButton(this.btnSubmit);

            // pictureBoxImagine
            this.pictureBoxImagine.Location = new System.Drawing.Point(350, 70);
            this.pictureBoxImagine.Size = new System.Drawing.Size(360, 160);
            this.pictureBoxImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagine.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // lblTimer
            this.lblTimer.Location = new System.Drawing.Point(600, 30);
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblTimer.Text = "Timp rămas:";

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.comboBoxQuizTypes);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBoxQuiz);
            this.Name = "Form1";
            this.Text = "Quiz App";
            this.groupBoxQuiz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
