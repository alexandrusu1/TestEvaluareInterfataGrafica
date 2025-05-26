using QuizAppGUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuizAppGUI
{
    public partial class FormAddQuestion : Form
    {
        private const int LungimeMinimaIntrebare = 5;
        private const int LungimeMinimaRaspuns = 1;

   
        private readonly bool isEditMode = false;
        private Intrebare intrebareEditata;
        public Intrebare IntrebareActualizata => intrebareEditata;

        public FormAddQuestion()
        {
            InitializeComponent();
            comboBoxTip.DataSource = Enum.GetValues(typeof(TipQuiz));
            comboBoxRaspunsCorect.SelectedIndex = 0;
        }

        public FormAddQuestion(Intrebare intrebareExistenta)
        {
            InitializeComponent();
            comboBoxTip.DataSource = Enum.GetValues(typeof(TipQuiz));
            comboBoxRaspunsCorect.SelectedIndex = 0;

            isEditMode = true;

           
            textBoxIntrebare.Text = intrebareExistenta.Text;
            textBoxA.Text = intrebareExistenta.Optiuni[0];
            textBoxB.Text = intrebareExistenta.Optiuni[1];
            textBoxC.Text = intrebareExistenta.Optiuni[2];
            textBoxD.Text = intrebareExistenta.Optiuni[3];
            comboBoxRaspunsCorect.SelectedIndex = (int)intrebareExistenta.RaspunsCorect - 1;
            textBoxImagine.Text = intrebareExistenta.Imagine ?? "";
        
            comboBoxTip.Enabled = false;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool valid = ValidareCampuri();

            if (!valid)
            {
                MessageBox.Show("Te rog corectează câmpurile evidențiate!", "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditMode)
            {
                intrebareEditata = new Intrebare(
                    textBoxIntrebare.Text.Trim(),
                    new List<string>
                    {
                        textBoxA.Text.Trim(),
                        textBoxB.Text.Trim(),
                        textBoxC.Text.Trim(),
                        textBoxD.Text.Trim()
                    },
                    (OptiuniRaspuns)(comboBoxRaspunsCorect.SelectedIndex + 1),
                    textBoxImagine.Text.Trim()
                );
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            TipQuiz tipSelectat = (TipQuiz)comboBoxTip.SelectedItem;
            string path = Path.Combine("FisiereQuiz", $"{tipSelectat.ToString().ToLower()}.txt");

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(textBoxIntrebare.Text.Trim());
                sw.WriteLine(textBoxA.Text.Trim());
                sw.WriteLine(textBoxB.Text.Trim());
                sw.WriteLine(textBoxC.Text.Trim());
                sw.WriteLine(textBoxD.Text.Trim());
                sw.WriteLine(comboBoxRaspunsCorect.SelectedIndex + 1);
                sw.WriteLine(textBoxImagine.Text.Trim());
            }

            MessageBox.Show("Întrebare adăugată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidareCampuri()
        {
            bool valid = true;

            // Resetăm culorile
            lblIntrebare.ForeColor = System.Drawing.Color.Black;
            lblA.ForeColor = System.Drawing.Color.Black;
            lblB.ForeColor = System.Drawing.Color.Black;
            lblC.ForeColor = System.Drawing.Color.Black;
            lblD.ForeColor = System.Drawing.Color.Black;

            if (textBoxIntrebare.Text.Trim().Length < LungimeMinimaIntrebare)
            {
                lblIntrebare.ForeColor = System.Drawing.Color.Red;
                valid = false;
            }

            if (textBoxA.Text.Trim().Length < LungimeMinimaRaspuns)
            {
                lblA.ForeColor = System.Drawing.Color.Red;
                valid = false;
            }

            if (textBoxB.Text.Trim().Length < LungimeMinimaRaspuns)
            {
                lblB.ForeColor = System.Drawing.Color.Red;
                valid = false;
            }

            if (textBoxC.Text.Trim().Length < LungimeMinimaRaspuns)
            {
                lblC.ForeColor = System.Drawing.Color.Red;
                valid = false;
            }

            if (textBoxD.Text.Trim().Length < LungimeMinimaRaspuns)
            {
                lblD.ForeColor = System.Drawing.Color.Red;
                valid = false;
            }

            return valid;
        }
    }
}

