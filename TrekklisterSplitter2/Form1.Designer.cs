namespace TrekklisterSplitter2
{
    partial class frmMainWindow
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
            this.TxtSourceFile = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPasswordString = new System.Windows.Forms.TextBox();
            this.BtnBrowseFilePath = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSavePath = new System.Windows.Forms.TextBox();
            this.BtnBrowseSavePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSourceFile
            // 
            this.TxtSourceFile.Location = new System.Drawing.Point(99, 42);
            this.TxtSourceFile.Name = "TxtSourceFile";
            this.TxtSourceFile.Size = new System.Drawing.Size(282, 20);
            this.TxtSourceFile.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(185, 168);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fil:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passord:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPasswordString
            // 
            this.TxtPasswordString.Location = new System.Drawing.Point(99, 111);
            this.TxtPasswordString.Name = "TxtPasswordString";
            this.TxtPasswordString.Size = new System.Drawing.Size(282, 20);
            this.TxtPasswordString.TabIndex = 4;
            // 
            // BtnBrowseFilePath
            // 
            this.BtnBrowseFilePath.BackColor = System.Drawing.Color.Transparent;
            this.BtnBrowseFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBrowseFilePath.FlatAppearance.BorderSize = 0;
            this.BtnBrowseFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseFilePath.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBrowseFilePath.Image = global::TrekklisterSplitter2.Properties.Resources.Folder_16x;
            this.BtnBrowseFilePath.Location = new System.Drawing.Point(384, 39);
            this.BtnBrowseFilePath.Name = "BtnBrowseFilePath";
            this.BtnBrowseFilePath.Size = new System.Drawing.Size(24, 23);
            this.BtnBrowseFilePath.TabIndex = 6;
            this.BtnBrowseFilePath.UseVisualStyleBackColor = false;
            this.BtnBrowseFilePath.Click += new System.EventHandler(this.BtnBrowseFilePath_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(286, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lagre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtSavePath
            // 
            this.TxtSavePath.Location = new System.Drawing.Point(99, 68);
            this.TxtSavePath.Name = "TxtSavePath";
            this.TxtSavePath.Size = new System.Drawing.Size(282, 20);
            this.TxtSavePath.TabIndex = 9;
            this.TxtSavePath.TextChanged += new System.EventHandler(this.TxtSavePath_TextChanged);
            // 
            // BtnBrowseSavePath
            // 
            this.BtnBrowseSavePath.BackColor = System.Drawing.Color.Transparent;
            this.BtnBrowseSavePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBrowseSavePath.FlatAppearance.BorderSize = 0;
            this.BtnBrowseSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseSavePath.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBrowseSavePath.Image = global::TrekklisterSplitter2.Properties.Resources.Folder_16x;
            this.BtnBrowseSavePath.Location = new System.Drawing.Point(384, 68);
            this.BtnBrowseSavePath.Name = "BtnBrowseSavePath";
            this.BtnBrowseSavePath.Size = new System.Drawing.Size(24, 23);
            this.BtnBrowseSavePath.TabIndex = 11;
            this.BtnBrowseSavePath.UseVisualStyleBackColor = false;
            this.BtnBrowseSavePath.Click += new System.EventHandler(this.BtnBrowseSavePath_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 213);
            this.Controls.Add(this.BtnBrowseSavePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSavePath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnBrowseFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPasswordString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.TxtSourceFile);
            this.Name = "frmMainWindow";
            this.Text = "Trekklister Splitter 2";
            this.Load += new System.EventHandler(this.FrmMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSourceFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPasswordString;
        private System.Windows.Forms.Button BtnBrowseFilePath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSavePath;
        private System.Windows.Forms.Button BtnBrowseSavePath;
    }
}

