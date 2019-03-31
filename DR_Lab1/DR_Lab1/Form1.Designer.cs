namespace DR_Lab1
{
    partial class SearchForm
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
            this.luceneButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxLucene = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // luceneButton
            // 
            this.luceneButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.luceneButton.Location = new System.Drawing.Point(534, 26);
            this.luceneButton.Name = "luceneButton";
            this.luceneButton.Size = new System.Drawing.Size(210, 45);
            this.luceneButton.TabIndex = 13;
            this.luceneButton.Text = "Upload";
            this.luceneButton.UseVisualStyleBackColor = true;
            this.luceneButton.Click += new System.EventHandler(this.luceneButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(534, 77);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(210, 45);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result:";
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.HorizontalScrollbar = true;
            this.ResultBox.ItemHeight = 22;
            this.ResultBox.Location = new System.Drawing.Point(115, 187);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(627, 268);
            this.ResultBox.TabIndex = 10;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchLabel.Location = new System.Drawing.Point(23, 82);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(85, 32);
            this.SearchLabel.TabIndex = 9;
            this.SearchLabel.Text = "Query:";
            // 
            // TextSearch
            // 
            this.TextSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextSearch.Location = new System.Drawing.Point(115, 82);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(410, 39);
            this.TextSearch.TabIndex = 8;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Upload from DB to Lucene:";
            // 
            // checkBoxLucene
            // 
            this.checkBoxLucene.AutoSize = true;
            this.checkBoxLucene.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLucene.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxLucene.Location = new System.Drawing.Point(534, 132);
            this.checkBoxLucene.Name = "checkBoxLucene";
            this.checkBoxLucene.Size = new System.Drawing.Size(185, 36);
            this.checkBoxLucene.TabIndex = 15;
            this.checkBoxLucene.Text = "Lucene search";
            this.checkBoxLucene.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.checkBoxLucene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.luceneButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.TextSearch);
            this.Name = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button luceneButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ResultBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxLucene;
    }
}

