namespace QueryBooks_Q2
{
    partial class Books_Q2
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.searchAgainButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(2);
            this.titleLabel.Size = new System.Drawing.Size(174, 33);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Books Catalog";
            // 
            // queryComboBox
            // 
            this.queryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Items.AddRange(new object[] {
            "Sort the result by title",
            "Sort the result by title, author\'s last name, first name",
            "Sort titles grouped by author"});
            this.queryComboBox.Location = new System.Drawing.Point(538, 68);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(150, 21);
            this.queryComboBox.TabIndex = 3;
            this.queryComboBox.Text = "Choose an option";
            this.queryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(535, 38);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(62, 13);
            this.queryLabel.TabIndex = 4;
            this.queryLabel.Text = "Search for: ";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(13, 68);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(495, 235);
            this.resultTextBox.TabIndex = 5;
            // 
            // searchAgainButton
            // 
            this.searchAgainButton.BackColor = System.Drawing.Color.Black;
            this.searchAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchAgainButton.Location = new System.Drawing.Point(538, 127);
            this.searchAgainButton.Name = "searchAgainButton";
            this.searchAgainButton.Size = new System.Drawing.Size(100, 30);
            this.searchAgainButton.TabIndex = 6;
            this.searchAgainButton.Text = "Search Again";
            this.searchAgainButton.UseVisualStyleBackColor = false;
            this.searchAgainButton.Click += new System.EventHandler(this.searchAgainButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(13, 364);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(202, 13);
            this.copyrightLabel.TabIndex = 7;
            this.copyrightLabel.Text = "Copyright : 300931676 : Gursharan Singh";
            // 
            // Books_Q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(714, 381);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.searchAgainButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.queryComboBox);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Books_Q2";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Q2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox queryComboBox;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.DataGridView authorDataGridView;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyrightDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button searchAgainButton;
        private System.Windows.Forms.Label copyrightLabel;
    }
}

