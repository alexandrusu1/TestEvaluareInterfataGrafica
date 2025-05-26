namespace QuizAppGUI
{
    partial class LeaderboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewLeaderboard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listViewLeaderboard = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewLeaderboard
            // 
            this.listViewLeaderboard.Location = new System.Drawing.Point(12, 12);
            this.listViewLeaderboard.Size = new System.Drawing.Size(560, 337);
            this.listViewLeaderboard.View = System.Windows.Forms.View.Details;
            this.listViewLeaderboard.FullRowSelect = true;
            this.listViewLeaderboard.Columns.Add("Nume", 120);
            this.listViewLeaderboard.Columns.Add("Quiz", 100);
            this.listViewLeaderboard.Columns.Add("Scor", 100);
            this.listViewLeaderboard.Columns.Add("Timp", 100);
            // 
            // LeaderboardForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.listViewLeaderboard);
            this.Name = "LeaderboardForm";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.LeaderboardForm_Load);
            this.ResumeLayout(false);
        }
    }
}
