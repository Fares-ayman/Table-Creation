namespace Table_Creation
{
    partial class AddTable
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
            this.TblNameLbl = new System.Windows.Forms.Label();
            this.TblNameTxt = new System.Windows.Forms.TextBox();
            this.CNameLbl = new System.Windows.Forms.Label();
            this.CNameTxt = new System.Windows.Forms.TextBox();
            this.DTypeLbl = new System.Windows.Forms.Label();
            this.DTypeCBox = new System.Windows.Forms.ComboBox();
            this.PKCheckBox = new System.Windows.Forms.CheckBox();
            this.AddColBtn = new System.Windows.Forms.Button();
            this.TConsLbl = new System.Windows.Forms.Label();
            this.ConsCBox = new System.Windows.Forms.ComboBox();
            this.ConsLbl = new System.Windows.Forms.Label();
            this.ConsTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TblNameLbl
            // 
            this.TblNameLbl.AutoSize = true;
            this.TblNameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblNameLbl.Location = new System.Drawing.Point(598, 168);
            this.TblNameLbl.Name = "TblNameLbl";
            this.TblNameLbl.Size = new System.Drawing.Size(118, 24);
            this.TblNameLbl.TabIndex = 0;
            this.TblNameLbl.Text = "Table Name";
            // 
            // TblNameTxt
            // 
            this.TblNameTxt.Location = new System.Drawing.Point(762, 168);
            this.TblNameTxt.Name = "TblNameTxt";
            this.TblNameTxt.Size = new System.Drawing.Size(143, 24);
            this.TblNameTxt.TabIndex = 1;
            // 
            // CNameLbl
            // 
            this.CNameLbl.AutoSize = true;
            this.CNameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNameLbl.Location = new System.Drawing.Point(598, 241);
            this.CNameLbl.Name = "CNameLbl";
            this.CNameLbl.Size = new System.Drawing.Size(135, 24);
            this.CNameLbl.TabIndex = 2;
            this.CNameLbl.Text = "Column Name";
            // 
            // CNameTxt
            // 
            this.CNameTxt.Location = new System.Drawing.Point(762, 241);
            this.CNameTxt.Name = "CNameTxt";
            this.CNameTxt.Size = new System.Drawing.Size(143, 24);
            this.CNameTxt.TabIndex = 3;
            // 
            // DTypeLbl
            // 
            this.DTypeLbl.AutoSize = true;
            this.DTypeLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTypeLbl.Location = new System.Drawing.Point(598, 318);
            this.DTypeLbl.Name = "DTypeLbl";
            this.DTypeLbl.Size = new System.Drawing.Size(103, 24);
            this.DTypeLbl.TabIndex = 4;
            this.DTypeLbl.Text = "Data Type";
            // 
            // DTypeCBox
            // 
            this.DTypeCBox.FormattingEnabled = true;
            this.DTypeCBox.Items.AddRange(new object[] {
            "Int64",
            "Decimal",
            "Char",
            "String",
            "Boolean",
            "DateTime"});
            this.DTypeCBox.Location = new System.Drawing.Point(762, 318);
            this.DTypeCBox.Name = "DTypeCBox";
            this.DTypeCBox.Size = new System.Drawing.Size(143, 24);
            this.DTypeCBox.TabIndex = 7;
            // 
            // PKCheckBox
            // 
            this.PKCheckBox.AutoSize = true;
            this.PKCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PKCheckBox.Location = new System.Drawing.Point(602, 612);
            this.PKCheckBox.Name = "PKCheckBox";
            this.PKCheckBox.Size = new System.Drawing.Size(139, 28);
            this.PKCheckBox.TabIndex = 8;
            this.PKCheckBox.Text = "Primary Key";
            this.PKCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddColBtn
            // 
            this.AddColBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.AddColBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddColBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddColBtn.Location = new System.Drawing.Point(712, 702);
            this.AddColBtn.Name = "AddColBtn";
            this.AddColBtn.Size = new System.Drawing.Size(97, 40);
            this.AddColBtn.TabIndex = 9;
            this.AddColBtn.Text = "Add";
            this.AddColBtn.UseVisualStyleBackColor = false;
            this.AddColBtn.Click += new System.EventHandler(this.AddColBtn_Click);
            // 
            // TConsLbl
            // 
            this.TConsLbl.AutoSize = true;
            this.TConsLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TConsLbl.Location = new System.Drawing.Point(598, 402);
            this.TConsLbl.Name = "TConsLbl";
            this.TConsLbl.Size = new System.Drawing.Size(160, 24);
            this.TConsLbl.TabIndex = 10;
            this.TConsLbl.Text = "Type Constraints";
            // 
            // ConsCBox
            // 
            this.ConsCBox.FormattingEnabled = true;
            this.ConsCBox.Items.AddRange(new object[] {
            "Greater than ",
            "Smaller than",
            "Not NULL",
            "None"});
            this.ConsCBox.Location = new System.Drawing.Point(762, 402);
            this.ConsCBox.Name = "ConsCBox";
            this.ConsCBox.Size = new System.Drawing.Size(143, 24);
            this.ConsCBox.TabIndex = 11;
            // 
            // ConsLbl
            // 
            this.ConsLbl.AutoSize = true;
            this.ConsLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsLbl.Location = new System.Drawing.Point(598, 485);
            this.ConsLbl.Name = "ConsLbl";
            this.ConsLbl.Size = new System.Drawing.Size(110, 24);
            this.ConsLbl.TabIndex = 12;
            this.ConsLbl.Text = "Constraints";
            // 
            // ConsTxt
            // 
            this.ConsTxt.Location = new System.Drawing.Point(762, 485);
            this.ConsTxt.Name = "ConsTxt";
            this.ConsTxt.Size = new System.Drawing.Size(143, 24);
            this.ConsTxt.TabIndex = 13;
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.ConsTxt);
            this.Controls.Add(this.ConsLbl);
            this.Controls.Add(this.ConsCBox);
            this.Controls.Add(this.TConsLbl);
            this.Controls.Add(this.AddColBtn);
            this.Controls.Add(this.PKCheckBox);
            this.Controls.Add(this.DTypeCBox);
            this.Controls.Add(this.DTypeLbl);
            this.Controls.Add(this.CNameTxt);
            this.Controls.Add(this.CNameLbl);
            this.Controls.Add(this.TblNameTxt);
            this.Controls.Add(this.TblNameLbl);
            this.Name = "AddTable";
            this.Size = new System.Drawing.Size(453, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CNameLbl;
        private System.Windows.Forms.TextBox CNameTxt;
        private System.Windows.Forms.Label DTypeLbl;
        private System.Windows.Forms.ComboBox DTypeCBox;
        private System.Windows.Forms.Button AddColBtn;
        private System.Windows.Forms.Label TConsLbl;
        private System.Windows.Forms.ComboBox ConsCBox;
        private System.Windows.Forms.Label ConsLbl;
        private System.Windows.Forms.TextBox ConsTxt;
        public System.Windows.Forms.Label TblNameLbl;
        public System.Windows.Forms.TextBox TblNameTxt;
        public System.Windows.Forms.CheckBox PKCheckBox;
    }
}
