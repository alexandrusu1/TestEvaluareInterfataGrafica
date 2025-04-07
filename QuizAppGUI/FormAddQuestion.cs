using QuizAppGUI.Models;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizAppGUI
{
    public partial class FormAddQuestion : Form
    {
        private const int LungimeMinimaIntrebare = 5;
        private const int LungimeMinimaRaspuns = 1;

        public FormAddQuestion()
        {
            InitializeComponent();
            comboBoxTip.DataSource = Enum.GetValues(typeof(TipQuiz));
            comboBoxRaspunsCorect.SelectedIndex = 0;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool valid = ValidareCampuri();

            if (!valid)
            {
                MessageBox.Show("Te rog corectează câmpurile evidențiate!", "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
