using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Laba3OOP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var results = new DataGridView[3] { FirstResults, SecondResults, ThirdResults };
            var answers = new SurveyAnswer[Survey.Rows.Count];
            for (int i = 0; i < answers.Length; i++)
                answers[i] = SurveyAnswer.FromRow(Survey.Rows[i]);
            var dict = new Dictionary<string, int>();
            for (int j = 0; j < 3; ++j)
            {
                foreach (var answer in answers)
                    if (answer.HasAnswer(j))
                    {
                        var znach = answer.GetAnswer(j)!;
                        if (dict.ContainsKey(znach))
                            dict[znach] += 1;
                        else
                            dict.Add(znach, 1);
                    }
                var all = dict.Values.Sum();
                var pairs = dict.AsEnumerable().OrderByDescending(x => x.Value);
                foreach (var pair in pairs)
                    results[j].Rows.Add(pair.Key, pair.Value / (double)all * 100);
                dict.Clear();
            }
        }
    }
}
