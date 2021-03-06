using System.Windows.Forms;

namespace Laba3OOP
{
    internal class Contestant
    {
        private readonly string Surname;
        private readonly string Community;
        private readonly double First;
        private readonly double Second;

        public Contestant(DataGridViewCellCollection cells)
        {
            Surname = cells[0].Value.ToString()!;
            Community = cells[1].Value.ToString()!;
            First = double.Parse(cells[2].Value.ToString()!);
            Second = double.Parse(cells[3].Value.ToString()!);
        }

        public double GetResult()
        {
            return First + Second;
        }

        public void PopulateRow(DataGridViewRow row)
        {
            row.Cells[1].Value = Surname;
            row.Cells[2].Value = Community;
            row.Cells[3].Value = First.ToString();
            row.Cells[4].Value = Second.ToString();
        }
    }
}
