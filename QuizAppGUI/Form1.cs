using QuizAppGUI.Models;
using QuizAppGUI.Services;
using System;
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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<TipQuiz>(comboBoxQuizTypes.SelectedItem.ToString(), out TipQuiz tip))
            {
                chestionar = new Chestionar(tip);
                intrebareIndex = 0;
                timpRamas = Chestionar.TimpLimita;

                lblTimer.Text = $"Timp rãmas: {FormatTimp(timpRamas)}";
                timer1.Start();

                groupBoxQuiz.Visible = true;
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

            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
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
                lblTimer.Text = $"Timp rãmas: {FormatTimp(timpRamas)}";
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
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            FormAddQuestion formAdd = new FormAddQuestion();
            formAdd.ShowDialog();
        }
    }
}
