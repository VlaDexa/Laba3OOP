using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laba3OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Form2().Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Results.Rows.Clear();
            var contestants = new Contestant[Contestants.Rows.Count - 1];
            for (var i = 0; i < Contestants.Rows.Count - 1; ++i)
            {
                var row = Contestants.Rows[i];
                contestants[i] = new Contestant(row.Cells);
            };
            int ind = 0;
            foreach (var contestant in contestants.OrderByDescending((cont) => cont.GetResult()))
            {
                Results.Rows.Add(ind + 1, null);
                contestant.PopulateRow(Results.Rows[ind]);
                ++ind;
            }
        }

        private void Contestants_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (Contestants.Rows.Count == 1 && Contestants.Rows[0].Cells[0].Value is null) return;
            try
            {
                foreach (DataGridViewCell cell in Contestants.Rows[e.RowIndex].Cells)
                    cell.Style.BackColor = Color.White;
                var human = new Contestant(Contestants.Rows[e.RowIndex].Cells);
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
