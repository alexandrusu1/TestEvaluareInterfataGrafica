namespace QuizAppGUI
{
    partial class FormAddQuestion
    {
        private System.ComponentModel.IContainer components = null;

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
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Label lblImagine;
        private System.Windows.Forms.TextBox textBoxImagine;
        private System.Windows.Forms.Button btnSalveaza;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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
            this.lblTip = new System.Windows.Forms.Label();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.lblImagine = new System.Windows.Forms.Label();
            this.textBoxImagine = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.AutoSize = true;
            this.lblIntrebare.Location = new System.Drawing.Point(20, 60);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(54, 13);
            this.lblIntrebare.TabIndex = 0;
            this.lblIntrebare.Text = "Întrebare:";
            // 
            // textBoxIntrebare
            // 
            this.textBoxIntrebare.Location = new System.Drawing.Point(120, 57);
            this.textBoxIntrebare.Name = "textBoxIntrebare";
            this.textBoxIntrebare.Size = new System.Drawing.Size(300, 20);
            this.textBoxIntrebare.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 100);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A):";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(120, 97);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(300, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(20, 140);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B):";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(120, 137);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(300, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(20, 180);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "C):";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(120, 177);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(300, 20);
            this.textBoxC.TabIndex = 7;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(20, 220);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(27, 13);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "D):";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(120, 217);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(300, 20);
            this.textBoxD.TabIndex = 9;
            // 
            // lblRaspunsCorect
            // 
            this.lblRaspunsCorect.AutoSize = true;
            this.lblRaspunsCorect.Location = new System.Drawing.Point(20, 260);
            this.lblRaspunsCorect.Name = "lblRaspunsCorect";
            this.lblRaspunsCorect.Size = new System.Drawing.Size(88, 13);
            this.lblRaspunsCorect.TabIndex = 10;
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
            this.comboBoxRaspunsCorect.Location = new System.Drawing.Point(120, 257);
            this.comboBoxRaspunsCorect.Name = "comboBoxRaspunsCorect";
            this.comboBoxRaspunsCorect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRaspunsCorect.TabIndex = 11;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(20, 300);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(25, 13);
            this.lblTip.TabIndex = 12;
            this.lblTip.Text = "Tip:";
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(120, 297);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTip.TabIndex = 13;
            // 
            // lblImagine
            // 
            this.lblImagine.AutoSize = true;
            this.lblImagine.Location = new System.Drawing.Point(20, 340);
            this.lblImagine.Name = "lblImagine";
            this.lblImagine.Size = new System.Drawing.Size(48, 13);
            this.lblImagine.TabIndex = 14;
            this.lblImagine.Text = "Imagine:";
            // 
            // textBoxImagine
            // 
            this.textBoxImagine.Location = new System.Drawing.Point(120, 337);
            this.textBoxImagine.Name = "textBoxImagine";
            this.textBoxImagine.Size = new System.Drawing.Size(300, 20);
            this.textBoxImagine.TabIndex = 15;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(500, 100);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(110, 35);
            this.btnSalveaza.TabIndex = 16;
            this.btnSalveaza.Text = "Actualizează";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);

            // 
            // FormAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400); // păstrează dimensiunea
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.textBoxIntrebare);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.lblRaspunsCorect);
            this.Controls.Add(this.comboBoxRaspunsCorect);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.lblImagine);
            this.Controls.Add(this.textBoxImagine);
            this.Controls.Add(this.btnSalveaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adaugă/Actualizează întrebare";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}