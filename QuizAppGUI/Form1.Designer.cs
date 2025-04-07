namespace QuizAppGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBoxQuizTypes;
        private Button btnStart;
        private GroupBox groupBoxQuiz;
        private Label lblQuestion;
        private RadioButton radioButtonA;
        private RadioButton radioButtonB;
        private RadioButton radioButtonC;
        private RadioButton radioButtonD;
        private Button btnSubmit;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddQuestion;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxQuizTypes = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBoxQuiz = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxQuiz.SuspendLayout();
            this.SuspendLayout();

            // comboBoxQuizTypes
            this.comboBoxQuizTypes.FormattingEnabled = true;
            this.comboBoxQuizTypes.Location = new System.Drawing.Point(50, 50);
            this.comboBoxQuizTypes.Name = "comboBoxQuizTypes";
            this.comboBoxQuizTypes.Size = new System.Drawing.Size(200, 24);
            this.comboBoxQuizTypes.TabIndex = 0;

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(50, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // groupBoxQuiz
            this.groupBoxQuiz.Controls.Add(this.lblQuestion);
            this.groupBoxQuiz.Controls.Add(this.radioButtonA);
            this.groupBoxQuiz.Controls.Add(this.radioButtonB);
            this.groupBoxQuiz.Controls.Add(this.radioButtonC);
            this.groupBoxQuiz.Controls.Add(this.radioButtonD);
            this.groupBoxQuiz.Controls.Add(this.btnSubmit);
            this.groupBoxQuiz.Location = new System.Drawing.Point(50, 160);
            this.groupBoxQuiz.Name = "groupBoxQuiz";
            this.groupBoxQuiz.Size = new System.Drawing.Size(500, 300);
            this.groupBoxQuiz.TabIndex = 2;
            this.groupBoxQuiz.TabStop = false;
            this.groupBoxQuiz.Visible = false;

            // lblQuestion
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(20, 30);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(70, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Întrebarea";

            // radioButtonA-D
            this.radioButtonA.Location = new System.Drawing.Point(20, 70);
            this.radioButtonB.Location = new System.Drawing.Point(20, 110);
            this.radioButtonC.Location = new System.Drawing.Point(20, 150);
            this.radioButtonD.Location = new System.Drawing.Point(20, 190);
            // ... (setări similare pentru toate RadioButton-urile)

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(20, 240);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Răspunde";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion.Location = new System.Drawing.Point(250, 30); // Poți ajusta poziția după preferință
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(120, 30);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Adaugă întrebare";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            this.Controls.Add(this.btnAddQuestion);

            // lblTimer
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTimer.Location = new System.Drawing.Point(300, 120);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 20);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Timp rămas:";

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBoxQuiz);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.comboBoxQuizTypes);
            this.Name = "Form1";
            this.Text = "Quiz App";
            this.groupBoxQuiz.ResumeLayout(false);
            this.groupBoxQuiz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}