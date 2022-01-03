namespace DataScriptGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.ScriptTable = new System.Windows.Forms.Button();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.DbTextBox = new System.Windows.Forms.TextBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ListTableTextBox = new System.Windows.Forms.TextBox();
            this.ScriptMultiTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Location = new System.Drawing.Point(12, 41);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.PlaceholderText = "Table";
            this.TableNameTextBox.Size = new System.Drawing.Size(338, 23);
            this.TableNameTextBox.TabIndex = 0;
            this.TableNameTextBox.Validated += new System.EventHandler(this.DbServerTextBox_Validated);
            // 
            // ScriptTable
            // 
            this.ScriptTable.Location = new System.Drawing.Point(12, 70);
            this.ScriptTable.Name = "ScriptTable";
            this.ScriptTable.Size = new System.Drawing.Size(338, 23);
            this.ScriptTable.TabIndex = 1;
            this.ScriptTable.Text = "Script A Table";
            this.ScriptTable.UseVisualStyleBackColor = true;
            this.ScriptTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptTextBox.Location = new System.Drawing.Point(356, 13);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ScriptTextBox.Size = new System.Drawing.Size(379, 417);
            this.ScriptTextBox.TabIndex = 2;
            // 
            // DbTextBox
            // 
            this.DbTextBox.Location = new System.Drawing.Point(12, 12);
            this.DbTextBox.Name = "DbTextBox";
            this.DbTextBox.PlaceholderText = "Database";
            this.DbTextBox.Size = new System.Drawing.Size(169, 23);
            this.DbTextBox.TabIndex = 3;
            this.DbTextBox.Validated += new System.EventHandler(this.DbServerTextBox_Validated);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(187, 12);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.PlaceholderText = "Server";
            this.ServerTextBox.Size = new System.Drawing.Size(163, 23);
            this.ServerTextBox.TabIndex = 4;
            this.ServerTextBox.Validated += new System.EventHandler(this.DbServerTextBox_Validated);
            // 
            // ListTableTextBox
            // 
            this.ListTableTextBox.Location = new System.Drawing.Point(12, 131);
            this.ListTableTextBox.Multiline = true;
            this.ListTableTextBox.Name = "ListTableTextBox";
            this.ListTableTextBox.PlaceholderText = "Table List";
            this.ListTableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ListTableTextBox.Size = new System.Drawing.Size(338, 270);
            this.ListTableTextBox.TabIndex = 5;
            // 
            // ScriptMultiTableButton
            // 
            this.ScriptMultiTableButton.Location = new System.Drawing.Point(12, 407);
            this.ScriptMultiTableButton.Name = "ScriptMultiTableButton";
            this.ScriptMultiTableButton.Size = new System.Drawing.Size(338, 23);
            this.ScriptMultiTableButton.TabIndex = 6;
            this.ScriptMultiTableButton.Text = "Script Multi Tables";
            this.ScriptMultiTableButton.UseVisualStyleBackColor = true;
            this.ScriptMultiTableButton.Click += new System.EventHandler(this.ScriptMultiTableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.ScriptMultiTableButton);
            this.Controls.Add(this.ListTableTextBox);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.DbTextBox);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.ScriptTable);
            this.Controls.Add(this.TableNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TableNameTextBox;
        private Button ScriptTable;
        private TextBox ScriptTextBox;
        private TextBox DbTextBox;
        private TextBox ServerTextBox;
        private TextBox ListTableTextBox;
        private Button ScriptMultiTableButton;
    }
}