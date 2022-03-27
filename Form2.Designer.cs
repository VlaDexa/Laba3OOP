namespace Laba3OOP
{
    partial class Form2
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
            this.Contestants = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstJump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondJump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Results = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultFirstJump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultSecondJump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Contestants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.SuspendLayout();
            // 
            // Contestants
            // 
            this.Contestants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contestants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.FirstJump,
            this.SecondJump});
            this.Contestants.Location = new System.Drawing.Point(12, 12);
            this.Contestants.Name = "Contestants";
            this.Contestants.RowHeadersWidth = 62;
            this.Contestants.RowTemplate.Height = 33;
            this.Contestants.Size = new System.Drawing.Size(516, 801);
            this.Contestants.TabIndex = 0;
            this.Contestants.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Contestants_RowValidating);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 8;
            this.Surname.Name = "Surname";
            this.Surname.Width = 150;
            // 
            // FirstJump
            // 
            this.FirstJump.HeaderText = "Прыжок 1";
            this.FirstJump.MinimumWidth = 8;
            this.FirstJump.Name = "FirstJump";
            this.FirstJump.Width = 150;
            // 
            // SecondJump
            // 
            this.SecondJump.HeaderText = "Прыжок 2";
            this.SecondJump.MinimumWidth = 8;
            this.SecondJump.Name = "SecondJump";
            this.SecondJump.Width = 150;
            // 
            // Results
            // 
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.ResultSurname,
            this.ResultFirstJump,
            this.ResultSecondJump});
            this.Results.Location = new System.Drawing.Point(846, 12);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RowHeadersWidth = 62;
            this.Results.RowTemplate.Height = 33;
            this.Results.Size = new System.Drawing.Size(665, 801);
            this.Results.TabIndex = 1;
            // 
            // Place
            // 
            this.Place.HeaderText = "№";
            this.Place.MinimumWidth = 8;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Width = 150;
            // 
            // ResultSurname
            // 
            this.ResultSurname.HeaderText = "Фамилия";
            this.ResultSurname.MinimumWidth = 8;
            this.ResultSurname.Name = "ResultSurname";
            this.ResultSurname.ReadOnly = true;
            this.ResultSurname.Width = 150;
            // 
            // ResultFirstJump
            // 
            this.ResultFirstJump.HeaderText = "Прыжок 1";
            this.ResultFirstJump.MinimumWidth = 8;
            this.ResultFirstJump.Name = "ResultFirstJump";
            this.ResultFirstJump.ReadOnly = true;
            this.ResultFirstJump.Width = 150;
            // 
            // ResultSecondJump
            // 
            this.ResultSecondJump.HeaderText = "Прыжок 2";
            this.ResultSecondJump.MinimumWidth = 8;
            this.ResultSecondJump.Name = "ResultSecondJump";
            this.ResultSecondJump.ReadOnly = true;
            this.ResultSecondJump.Width = 150;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(630, 380);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(112, 34);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Посчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 825);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Contestants);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Contestants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Contestants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstJump;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondJump;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultFirstJump;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultSecondJump;
        private System.Windows.Forms.Button Calculate;
    }
}