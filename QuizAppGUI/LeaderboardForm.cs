using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuizAppGUI
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm()
        {
            InitializeComponent();
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            string file = Path.Combine("FisiereQuiz", "rezultate.txt");
            if (!File.Exists(file))
                return;

            var lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
               
                var parts = line.Split(',');
                if (parts.Length < 5) continue;

                string nume = parts.FirstOrDefault(p => p.Trim().StartsWith("Nume:"))?.Split(':')[1].Trim() ?? "";
                string quiz = parts.FirstOrDefault(p => p.Trim().StartsWith("Quiz:"))?.Split(':')[1].Trim() ?? "";
                string scor = parts.FirstOrDefault(p => p.Trim().StartsWith("Scor:"))?.Split(':')[1].Trim() ?? "";
                string timp = parts.FirstOrDefault(p => p.Trim().StartsWith("Timp:"))?.Split(':')[1].Trim() ?? "";

                var item = new ListViewItem(new[] { nume, quiz, scor, timp + " minute"});
                listViewLeaderboard.Items.Add(item);
            }
        }
    }
}
