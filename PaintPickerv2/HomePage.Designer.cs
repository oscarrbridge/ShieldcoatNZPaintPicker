namespace PaintPickerv2
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnPrintLabel = new System.Windows.Forms.Button();
            this.btnPrintBatch = new System.Windows.Forms.Button();
            this.btnPrintCustom = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::PaintPickerv2.Properties.Resources.shieldcoatlogov2;
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(411, 95);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.AutoSize = true;
            this.btnPrintLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.btnPrintLabel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnPrintLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnPrintLabel.Location = new System.Drawing.Point(40, 156);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Size = new System.Drawing.Size(195, 43);
            this.btnPrintLabel.TabIndex = 1;
            this.btnPrintLabel.Text = "Bucket Label";
            this.btnPrintLabel.UseVisualStyleBackColor = false;
            this.btnPrintLabel.Click += new System.EventHandler(this.btnPrintLabel_Click);
            // 
            // btnPrintBatch
            // 
            this.btnPrintBatch.AutoSize = true;
            this.btnPrintBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.btnPrintBatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnPrintBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnPrintBatch.Location = new System.Drawing.Point(40, 205);
            this.btnPrintBatch.Name = "btnPrintBatch";
            this.btnPrintBatch.Size = new System.Drawing.Size(195, 43);
            this.btnPrintBatch.TabIndex = 2;
            this.btnPrintBatch.Text = "Batch Label";
            this.btnPrintBatch.UseVisualStyleBackColor = false;
            this.btnPrintBatch.Click += new System.EventHandler(this.btnPrintBatch_Click);
            // 
            // btnPrintCustom
            // 
            this.btnPrintCustom.AutoSize = true;
            this.btnPrintCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.btnPrintCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnPrintCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnPrintCustom.Location = new System.Drawing.Point(40, 254);
            this.btnPrintCustom.Name = "btnPrintCustom";
            this.btnPrintCustom.Size = new System.Drawing.Size(195, 43);
            this.btnPrintCustom.TabIndex = 3;
            this.btnPrintCustom.Text = "Custom Label";
            this.btnPrintCustom.UseVisualStyleBackColor = false;
            this.btnPrintCustom.Click += new System.EventHandler(this.btnPrintCustom_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnSearch.Location = new System.Drawing.Point(40, 331);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 43);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnExit.Location = new System.Drawing.Point(723, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lblTitle.Location = new System.Drawing.Point(34, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(388, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Label Creator and Colour Picker";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrintCustom);
            this.Controls.Add(this.btnPrintBatch);
            this.Controls.Add(this.btnPrintLabel);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.Button btnPrintBatch;
        private System.Windows.Forms.Button btnPrintCustom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}