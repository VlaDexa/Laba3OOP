using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Laba3OOP
{
    internal class Athlete
    {
        readonly string Surname;
        readonly IEnumerable<int> FirstJump;
        readonly IEnumerable<int> SecondJump;

        public Athlete(DataGridViewRow row)
        {
            Surname = (string)row.Cells[0].Value;
            FirstJump = ((string)row.Cells[1].Value).Split(" ").Select(x => int.Parse(x));
            SecondJump = ((string)row.Cells[2].Value).Split(" ").Select(x => int.Parse(x));
        }

        public void PopulateResultRow(int place, DataGridViewRow row)
        {
            row.Cells[0].Value = place;
            row.Cells[1].Value = Surname;
            row.Cells[2].Value = string.Join(" ", FirstJump);
            row.Cells[3].Value = string.Join(" ", SecondJump);
        }

        public double CalculateAveragePoints()
        {
            return (FirstJump.Average() + SecondJump.Average()) / 2;
        }
    }
}
