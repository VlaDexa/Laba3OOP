using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Laba3OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Results.Rows.Clear();
            var contestants = new FirstContestant[Contestants.Rows.Count - 1];
            for (var i = 0; i < Contestants.Rows.Count - 1; ++i)
            {
                var row = Contestants.Rows[i];
                contestants[i] = new FirstContestant(row.Cells);
            };
            int ind = 0;
            foreach (var contestant in contestants.OrderBy((cont) => -cont.GetResult()))
            {
                Results.Rows.Add(ind + 1, null);
                contestant.PopulateRow(Results.Rows[ind]);
                ++ind;
            }
        }

        private void Contestants_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (Contestants.Rows.Count == 1) return;
            try
            {
                foreach (DataGridViewCell cell in Contestants.Rows[e.RowIndex].Cells)
                    cell.Style.BackColor = Color.White;
                var human = new FirstContestant(Contestants.Rows[e.RowIndex].Cells);
            }
            catch
            {
                foreach (DataGridViewCell cell in Contestants.Rows[e.RowIndex].Cells)
                    cell.Style.BackColor = Color.Red;
                e.Cancel = true;
            }
        }
    }
}
