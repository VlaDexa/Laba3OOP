using System.Collections.Generic;
using System.Windows.Forms;

namespace Laba3OOP
{
    internal class SurveyAnswer
    {
        readonly Dictionary<int, string> answers;

        public SurveyAnswer(string? first, string? second, string? third)
        {
            answers = new Dictionary<int, string>();
            if (first != null)
                answers.Add(0, first);
            if (second != null)
                answers.Add(1, second);
            if (third != null)
                answers.Add(2, third);
        }

        public static SurveyAnswer FromRow(DataGridViewRow row) => new(row.Cells[0].Value as string, row.Cells[1].Value as string, row.Cells[2].Value as string);

        public bool HasAnswer(int numb) => answers.ContainsKey(numb);

        public string? GetAnswer(int numb) => answers.GetValueOrDefault(numb);
    }
}
