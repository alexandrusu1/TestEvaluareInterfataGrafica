namespace QuizAppGUI
{
    partial class FormAddQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTip = new System.Windows.Forms.Label();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.textBoxIntrebare = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.lblRaspunsCorect = new System.Windows.Forms.Label();
            this.comboBoxRaspunsCorect = new System.Windows.Forms.ComboBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(12, 15);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(74, 13);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Tipul quiz-ului:";
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(120, 12);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTip.TabIndex = 1;
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.AutoSize = true;
            this.lblIntrebare.Location = new System.Drawing.Point(12, 45);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(54, 13);
            this.lblIntrebare.TabIndex = 2;
            this.lblIntrebare.Text = "Întrebare:";
            // 
            // textBoxIntrebare
            // 
            this.textBoxIntrebare.Location = new System.Drawing.Point(120, 42);
            this.textBoxIntrebare.Name = "textBoxIntrebare";
            this.textBoxIntrebare.Size = new System.Drawing.Size(400, 20);
            this.textBoxIntrebare.TabIndex = 3;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 75);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(69, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Varianta A:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(120, 72);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(400, 20);
            this.textBoxA.TabIndex = 5;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 105);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(69, 13);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "Varianta B:";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(120, 102);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(400, 20);
            this.textBoxB.TabIndex = 7;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 135);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(69, 13);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "Varianta C:";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(120, 132);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(400, 20);
            this.textBoxC.TabIndex = 9;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(12, 165);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(70, 13);
            this.lblD.TabIndex = 10;
            this.lblD.Text = "Varianta D:";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(120, 162);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(400, 20);
            this.textBoxD.TabIndex = 11;
            // 
            // lblRaspunsCorect
            // 
            this.lblRaspunsCorect.AutoSize = true;
            this.lblRaspunsCorect.Location = new System.Drawing.Point(12, 195);
            this.lblRaspunsCorect.Name = "lblRaspunsCorect";
            this.lblRaspunsCorect.Size = new System.Drawing.Size(91, 13);
            this.lblRaspunsCorect.TabIndex = 12;
            this.lblRaspunsCorect.Text = "Răspuns corect:";

            // 
            // comboBoxRaspunsCorect
            // 
            this.comboBoxRaspunsCorect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaspunsCorect.FormattingEnabled = true;
            this.comboBoxRaspunsCorect.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxRaspunsCorect.Location = new System.Drawing.Point(120, 192);
            this.comboBoxRaspunsCorect.Name = "comboBoxRaspunsCorect";
            this.comboBoxRaspunsCorect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRaspunsCorect.TabIndex = 13;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(120, 230);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(121, 30);
            this.btnSalveaza.TabIndex = 14;
            this.btnSalveaza.Text = "Salvează";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 281);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.comboBoxRaspunsCorect);
            this.Controls.Add(this.lblRaspunsCorect);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.textBoxIntrebare);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.lblTip);
            this.Name = "FormAddQuestion";
            this.Text = "Adaugă întrebare nouă";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.TextBox textBoxIntrebare;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label lblRaspunsCorect;
        private System.Windows.Forms.ComboBox comboBoxRaspunsCorect;
        private System.Windows.Forms.Button btnSalveaza;
        

    }
}
