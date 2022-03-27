namespace Laba3OOP
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Survey = new System.Windows.Forms.DataGridView();
            this.FirstQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstResults = new System.Windows.Forms.DataGridView();
            this.FAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Survey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Survey
            // 
            this.Survey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Survey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstQuestion,
            this.SecondQuestion,
            this.ThirdQuestion});
            this.Survey.Location = new System.Drawing.Point(12, 12);
            this.Survey.Name = "Survey";
            this.Survey.RowHeadersWidth = 62;
            this.Survey.RowTemplate.Height = 33;
            this.Survey.Size = new System.Drawing.Size(514, 426);
            this.Survey.TabIndex = 0;
            // 
            // FirstQuestion
            // 
            this.FirstQuestion.HeaderText = "Первый вопрос";
            this.FirstQuestion.MinimumWidth = 8;
            this.FirstQuestion.Name = "FirstQuestion";
            this.FirstQuestion.Width = 150;
            // 
            // SecondQuestion
            // 
            this.SecondQuestion.HeaderText = "Второй вопрос";
            this.SecondQuestion.MinimumWidth = 8;
            this.SecondQuestion.Name = "SecondQuestion";
            this.SecondQuestion.Width = 150;
            // 
            // ThirdQuestion
            // 
            this.ThirdQuestion.HeaderText = "Третий вопрос";
            this.ThirdQuestion.MinimumWidth = 8;
            this.ThirdQuestion.Name = "ThirdQuestion";
            this.ThirdQuestion.Width = 150;
            // 
            // FirstResults
            // 
            this.FirstResults.AllowUserToAddRows = false;
            this.FirstResults.AllowUserToDeleteRows = false;
            this.FirstResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FAnswer,
            this.FPerc});
            this.FirstResults.Location = new System.Drawing.Point(785, 12);
            this.FirstResults.Name = "FirstResults";
            this.FirstResults.ReadOnly = true;
            this.FirstResults.RowHeadersWidth = 62;
            this.FirstResults.RowTemplate.Height = 33;
            this.FirstResults.Size = new System.Drawing.Size(365, 426);
            this.FirstResults.TabIndex = 1;
            // 
            // FAnswer
            // 
            this.FAnswer.HeaderText = "Ответ";
            this.FAnswer.MinimumWidth = 8;
            this.FAnswer.Name = "FAnswer";
            this.FAnswer.ReadOnly = true;
            this.FAnswer.Width = 150;
            // 
            // FPerc
            // 
            this.FPerc.HeaderText = "Доля";
            this.FPerc.MinimumWidth = 8;
            this.FPerc.Name = "FPerc";
            this.FPerc.ReadOnly = true;
            this.FPerc.Width = 150;
            // 
            // SecondResults
            // 
            this.SecondResults.AllowUserToAddRows = false;
            this.SecondResults.AllowUserToDeleteRows = false;
            this.SecondResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.SecondResults.Location = new System.Drawing.Point(1195, 12);
            this.SecondResults.Name = "SecondResults";
            this.SecondResults.ReadOnly = true;
            this.SecondResults.RowHeadersWidth = 62;
            this.SecondResults.RowTemplate.Height = 33;
            this.SecondResults.Size = new System.Drawing.Size(365, 426);
            this.SecondResults.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ответ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Доля";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // ThirdResults
            // 
            this.ThirdResults.AllowUserToAddRows = false;
            this.ThirdResults.AllowUserToDeleteRows = false;
            this.ThirdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThirdResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ThirdResults.Location = new System.Drawing.Point(1583, 12);
            this.ThirdResults.Name = "ThirdResults";
            this.ThirdResults.ReadOnly = true;
            this.ThirdResults.RowHeadersWidth = 62;
            this.ThirdResults.RowTemplate.Height = 33;
            this.ThirdResults.Size = new System.Drawing.Size(365, 426);
            this.ThirdResults.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ответ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Доля";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(608, 215);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(112, 34);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Посчитать";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1953, 451);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ThirdResults);
            this.Controls.Add(this.SecondResults);
            this.Controls.Add(this.FirstResults);
            this.Controls.Add(this.Survey);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Survey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Survey;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdQuestion;
        private System.Windows.Forms.DataGridView FirstResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPerc;
        private System.Windows.Forms.DataGridView SecondResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView ThirdResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Submit;
    }
}