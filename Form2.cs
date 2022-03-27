using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*
Протокол соревнований по прыжкам в воду содержит список фамилий спортсменов и баллы,
выставленные 5 судьями по результатам 2 прыжков.
Получить итоговый протокол, содержащий фамилии и результаты,
в порядке занятых спортсменами мест по результатам 2 прыжков.
*/

namespace Laba3OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            new Form3().Show();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var athletes = new Athlete[Contestants.Rows.Count - 1];
            for (int i = 0; i < Contestants.Rows.Count - 1; i++)
            {
                DataGridViewRow row = Contestants.Rows[i];
                athletes[i] = new Athlete(row);
            }
            for (int i = 0; i < athletes.Length; i++)
                Results.Rows.Add();
            int place = 1;
            foreach ((Athlete athlete, int position) in athletes.OrderByDescending(x => x.CalculateAveragePoints()).Select(x => (x, place++)))
                athlete.PopulateResultRow(position, Results.Rows[position - 1]);
        }

        private void Contestants_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (Contestants.Rows.Count == 1 && Contestants.Rows[0].Cells[0].Value is null) return;
            var row = Contestants.Rows[e.RowIndex];
            try
            {
                if (row is null || row.Cells[0] is null || row.Cells[1] is null || row.Cells[2] is null || row.Cells[0].Value is null || row.Cells[1].Value is null || row.Cells[2].Value is null) throw new ArgumentNullException(nameof(e));
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Style.BackColor = Color.White;
                var first = ((string)row.Cells[1].Value).Split(" ");
                if (first.Length != 5) throw new ArgumentException("");
                var second = ((string)row.Cells[2].Value).Split(" ");
                if (second.Length != 5) throw new ArgumentException("");
                foreach (var x in first)
                    int.Parse(x);
                foreach (var x in second)
                    int.Parse(x);
            }
            catch
            {
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Style.BackColor = Color.Red;
                e.Cancel = true;
            }
        }
    }
}
