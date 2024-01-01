namespace BulkFileRename
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.lblBrowseFolder = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalFiles = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtFileExt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBrowseFolder
            // 
            this.lblBrowseFolder.AutoSize = true;
            this.lblBrowseFolder.Location = new System.Drawing.Point(8, 128);
            this.lblBrowseFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrowseFolder.Name = "lblBrowseFolder";
            this.lblBrowseFolder.Size = new System.Drawing.Size(166, 21);
            this.lblBrowseFolder.TabIndex = 0;
            this.lblBrowseFolder.Text = "Select Product Folder...";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 152);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 37);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse[F2]...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Images/Products";
            // 
            // txtTotalFiles
            // 
            this.txtTotalFiles.Enabled = false;
            this.txtTotalFiles.Location = new System.Drawing.Point(12, 231);
            this.txtTotalFiles.Name = "txtTotalFiles";
            this.txtTotalFiles.Size = new System.Drawing.Size(57, 29);
            this.txtTotalFiles.TabIndex = 50002;
            this.txtTotalFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(12, 87);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(341, 29);
            this.txtNewName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter SKU/Barcode/Product Code";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter only product SKU do not enter variant SKU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Finaly Rename Images";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(12, 299);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(116, 37);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtFileExt
            // 
            this.txtFileExt.Enabled = false;
            this.txtFileExt.Location = new System.Drawing.Point(174, 203);
            this.txtFileExt.Name = "txtFileExt";
            this.txtFileExt.Size = new System.Drawing.Size(179, 29);
            this.txtFileExt.TabIndex = 50002;
            this.txtFileExt.Text = "*.jpg,*.jpeg,*.png";
            this.txtFileExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 409);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtFileExt);
            this.Controls.Add(this.txtTotalFiles);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBrowseFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Image Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrowseFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalFiles;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtFileExt;
    }
}

