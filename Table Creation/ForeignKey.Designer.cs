namespace Table_Creation
{
    partial class ForeignKey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.RTableCBox = new System.Windows.Forms.ComboBox();
            this.AddFkBtn = new System.Windows.Forms.Button();
            this.CurrCol = new System.Windows.Forms.ComboBox();
            this.RColCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FkTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primary Key Table";
            // 
            // RTableCBox
            // 
            this.RTableCBox.FormattingEnabled = true;
            this.RTableCBox.Location = new System.Drawing.Point(548, 416);
            this.RTableCBox.Name = "RTableCBox";
            this.RTableCBox.Size = new System.Drawing.Size(162, 24);
            this.RTableCBox.TabIndex = 3;
            this.RTableCBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // AddFkBtn
            // 
            this.AddFkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.AddFkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFkBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFkBtn.Location = new System.Drawing.Point(755, 547);
            this.AddFkBtn.Name = "AddFkBtn";
            this.AddFkBtn.Size = new System.Drawing.Size(97, 40);
            this.AddFkBtn.TabIndex = 10;
            this.AddFkBtn.Text = "Add";
            this.AddFkBtn.UseVisualStyleBackColor = false;
            this.AddFkBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddColBtn_MouseClick);
            // 
            // CurrCol
            // 
            this.CurrCol.FormattingEnabled = true;
            this.CurrCol.Location = new System.Drawing.Point(888, 472);
            this.CurrCol.Name = "CurrCol";
            this.CurrCol.Size = new System.Drawing.Size(172, 24);
            this.CurrCol.TabIndex = 14;
            // 
            // RColCBox
            // 
            this.RColCBox.FormattingEnabled = true;
            this.RColCBox.Location = new System.Drawing.Point(548, 472);
            this.RColCBox.Name = "RColCBox";
            this.RColCBox.Size = new System.Drawing.Size(166, 24);
            this.RColCBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(884, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Foreign Key Table";
            // 
            // FkTxt
            // 
            this.FkTxt.Location = new System.Drawing.Point(888, 415);
            this.FkTxt.Name = "FkTxt";
            this.FkTxt.Size = new System.Drawing.Size(172, 24);
            this.FkTxt.TabIndex = 19;
            // 
            // ForeignKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.FkTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RColCBox);
            this.Controls.Add(this.CurrCol);
            this.Controls.Add(this.AddFkBtn);
            this.Controls.Add(this.RTableCBox);
            this.Controls.Add(this.label2);
            this.Name = "ForeignKey";
            this.Size = new System.Drawing.Size(1257, 770);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RTableCBox;
        private System.Windows.Forms.Button AddFkBtn;
        private System.Windows.Forms.ComboBox CurrCol;
        private System.Windows.Forms.ComboBox RColCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FkTxt;
    }
}
