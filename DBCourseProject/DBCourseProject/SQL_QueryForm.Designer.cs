namespace DBCourseProject
{
    partial class SQL_QueryForm
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
            this.sqlQuery_button = new System.Windows.Forms.Button();
            this.sqlQuery_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sqlQuery_button
            // 
            this.sqlQuery_button.Location = new System.Drawing.Point(185, 272);
            this.sqlQuery_button.Name = "sqlQuery_button";
            this.sqlQuery_button.Size = new System.Drawing.Size(106, 46);
            this.sqlQuery_button.TabIndex = 0;
            this.sqlQuery_button.Text = "Query";
            this.sqlQuery_button.UseVisualStyleBackColor = true;
            this.sqlQuery_button.Click += new System.EventHandler(this.sqlQuery_button_Click);
            // 
            // sqlQuery_textBox
            // 
            this.sqlQuery_textBox.Location = new System.Drawing.Point(13, 13);
            this.sqlQuery_textBox.Multiline = true;
            this.sqlQuery_textBox.Name = "sqlQuery_textBox";
            this.sqlQuery_textBox.Size = new System.Drawing.Size(459, 200);
            this.sqlQuery_textBox.TabIndex = 1;
            // 
            // SQL_QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.sqlQuery_textBox);
            this.Controls.Add(this.sqlQuery_button);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "SQL_QueryForm";
            this.Text = "SQL_QueryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sqlQuery_button;
        private System.Windows.Forms.TextBox sqlQuery_textBox;
    }
}