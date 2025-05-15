using QuizAppGUI.Models;
using QuizAppGUI.Services;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuizAppGUI
{
    public partial class Form1 : Form
    {
        private Chestionar chestionar;
        private int intrebareIndex = 0;
        private int timpRamas = Chestionar.TimpLimita;

        public Form1()
        {
            InitializeComponent();
            comboBoxQuizTypes.DataSource = Enum.GetValues(typeof(TipQuiz));
            this.BackgroundImage = Image.FromFile("Resources/gg.jpg");

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = new Icon("Resources/logo.ico");


            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            textBoxSearch.Visible = false;
            btnSearch.Visible = false;
            btnUpdateQuestion.Visible = false;
            lblTimer.Visible = false; // Ascunde timerul la pornire
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<TipQuiz>(comboBoxQuizTypes.SelectedItem.ToString(), out TipQuiz tip))
            {
                chestionar = new Chestionar(tip);
                intrebareIndex = 0;
                timpRamas = Chestionar.TimpLimita;
                comboBoxQuizTypes.Enabled = false;

                comboBoxQuizTypes.Visible = false;
                btnStart.Visible = false;
                btnAddQuestion.Visible = false;

                textBoxSearch.Visible = true;
                btnSearch.Visible = true;
                btnUpdateQuestion.Visible = true;
                lblTimer.Visible = true;
                pictureBoxLogo.Visible = false; 

                lblTimer.Text = $"Timp rămas: {FormatTimp(timpRamas)}";
                timer1.Start();

                groupBoxQuiz.Visible = true;
                AfiseazaIntrebareCurenta();
            }
        }


        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            if (chestionar == null || chestionar.Intrebari == null || chestionar.Intrebari.Count == 0)
            {
                MessageBox.Show("Nu există întrebări disponibile pentru actualizare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var intrebareDeActualizat = chestionar.Intrebari[intrebareIndex];

            FormAddQuestion formUpdate = new FormAddQuestion(intrebareDeActualizat);
            if (formUpdate.ShowDialog() == DialogResult.OK)
            {
                chestionar.Intrebari[intrebareIndex] = formUpdate.IntrebareActualizata;
                AfiseazaIntrebareCurenta();
            }
        }

        private void AfiseazaIntrebareCurenta()
        {
            if (intrebareIndex >= chestionar.Intrebari.Count)
                return;

            var intrebare = chestionar.Intrebari[intrebareIndex];
            lblQuestion.Text = intrebare.Text;
            radioButtonA.Text = intrebare.Optiuni[0];
            radioButtonB.Text = intrebare.Optiuni[1];
            radioButtonC.Text = intrebare.Optiuni[2];
            radioButtonD.Text = intrebare.Optiuni[3];

            pictureBoxImagine.ImageLocation = !string.IsNullOrEmpty(intrebare.Imagine)
                ? Path.Combine("Resources", intrebare.Imagine)
                : null;

            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;

            groupBoxQuiz.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (intrebareIndex >= chestionar.Intrebari.Count)
                return;

            OptiuniRaspuns raspunsAles;

            if (radioButtonA.Checked) raspunsAles = OptiuniRaspuns.A;
            else if (radioButtonB.Checked) raspunsAles = OptiuniRaspuns.B;
            else if (radioButtonC.Checked) raspunsAles = OptiuniRaspuns.C;
            else if (radioButtonD.Checked) raspunsAles = OptiuniRaspuns.D;
            else return;

            var intrebare = chestionar.Intrebari[intrebareIndex];
            if (intrebare.VerificaRaspuns(raspunsAles))
            {
                chestionar.IncrementareScor();
            }

            intrebareIndex++;
            if (intrebareIndex < chestionar.Intrebari.Count)
            {
                AfiseazaIntrebareCurenta();
            }
            else
            {
                FinalizeazaQuiz("Quiz finalizat!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timpRamas--;

            if (timpRamas >= 0)
            {
                lblTimer.Text = $"Timp rămas: {FormatTimp(timpRamas)}";
            }

            if (timpRamas <= 0)
            {
                timer1.Stop();
                FinalizeazaQuiz("Timpul a expirat!");
            }
        }

        private string FormatTimp(int secunde)
        {
            int minute = secunde / 60;
            int sec = secunde % 60;
            return $"{minute:D2}:{sec:D2}";
        }

        private void FinalizeazaQuiz(string mesaj)
        {
            timer1.Stop();
            MessageBox.Show($"{mesaj}\nScor final: {chestionar.Scor}/{chestionar.Intrebari.Count}", "Rezultat");
            chestionar.SalvareRezultat(chestionar.Scor);
            groupBoxQuiz.Visible = false;
            comboBoxQuizTypes.Enabled = true;

            comboBoxQuizTypes.Visible = true;
            btnStart.Visible = true;
            btnAddQuestion.Visible = true;

            textBoxSearch.Visible = false;
            btnSearch.Visible = false;
            btnUpdateQuestion.Visible = false;
            lblTimer.Visible = false; 
            pictureBoxLogo.Visible = true;

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            FormAddQuestion formAdd = new FormAddQuestion();
            formAdd.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chestionar == null || chestionar.Intrebari == null)
            {
                MessageBox.Show("Te rog pornește mai întâi un quiz.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string keyword = textBoxSearch.Text.Trim().ToLower();
            var rezultat = chestionar.Intrebari
                .FirstOrDefault(i => i.Text.ToLower().Contains(keyword));

            if (rezultat != null)
            {
                MessageBox.Show($"Întrebare găsită:\n{rezultat.Text}\n\nA) {rezultat.Optiuni[0]}\nB) {rezultat.Optiuni[1]}\nC) {rezultat.Optiuni[2]}\nD) {rezultat.Optiuni[3]}", "Rezultat căutare");
            }
            else
            {
                MessageBox.Show("Nicio întrebare găsită cu cuvântul introdus.", "Căutare eşuată");
            }
        }
    }
}
