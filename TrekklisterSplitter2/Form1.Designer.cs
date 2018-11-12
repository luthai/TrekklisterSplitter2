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
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordString = new System.Windows.Forms.TextBox();
            this.btnBrowseFilePath = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnBrowseSavePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(99, 42);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(282, 20);
            this.txtSourceFile.TabIndex = 0;
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
            // txtPasswordString
            // 
            this.txtPasswordString.Location = new System.Drawing.Point(99, 111);
            this.txtPasswordString.Name = "txtPasswordString";
            this.txtPasswordString.Size = new System.Drawing.Size(282, 20);
            this.txtPasswordString.TabIndex = 4;
            // 
            // btnBrowseFilePath
            // 
            this.btnBrowseFilePath.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseFilePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowseFilePath.FlatAppearance.BorderSize = 0;
            this.btnBrowseFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFilePath.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowseFilePath.Image = global::TrekklisterSplitter2.Properties.Resources.Folder_16x;
            this.btnBrowseFilePath.Location = new System.Drawing.Point(384, 39);
            this.btnBrowseFilePath.Name = "btnBrowseFilePath";
            this.btnBrowseFilePath.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseFilePath.TabIndex = 6;
            this.btnBrowseFilePath.UseVisualStyleBackColor = false;
            this.btnBrowseFilePath.Click += new System.EventHandler(this.btnBrowseFilePath_Click);
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
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(99, 68);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(282, 20);
            this.txtSavePath.TabIndex = 9;
            this.txtSavePath.TextChanged += new System.EventHandler(this.txtSavePath_TextChanged);
            // 
            // btnBrowseSavePath
            // 
            this.btnBrowseSavePath.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseSavePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBrowseSavePath.FlatAppearance.BorderSize = 0;
            this.btnBrowseSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSavePath.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowseSavePath.Image = global::TrekklisterSplitter2.Properties.Resources.Folder_16x;
            this.btnBrowseSavePath.Location = new System.Drawing.Point(384, 68);
            this.btnBrowseSavePath.Name = "btnBrowseSavePath";
            this.btnBrowseSavePath.Size = new System.Drawing.Size(24, 23);
            this.btnBrowseSavePath.TabIndex = 11;
            this.btnBrowseSavePath.UseVisualStyleBackColor = false;
            this.btnBrowseSavePath.Click += new System.EventHandler(this.btnBrowseSavePath_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 213);
            this.Controls.Add(this.btnBrowseSavePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowseFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasswordString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSourceFile);
            this.Name = "frmMainWindow";
            this.Text = "Trekklister Splitter 2";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordString;
        private System.Windows.Forms.Button btnBrowseFilePath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnBrowseSavePath;
    }
}

