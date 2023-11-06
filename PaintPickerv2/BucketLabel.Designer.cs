namespace PaintPickerv2
{
    partial class frmBucket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBucket));
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.cmbSheen = new System.Windows.Forms.ComboBox();
            this.txtColour = new System.Windows.Forms.Label();
            this.txtSheen = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtColourselected = new System.Windows.Forms.Label();
            this.txtSheenselected = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.Label();
            this.txtBaseselected = new System.Windows.Forms.Label();
            this.txtTintneededlist = new System.Windows.Forms.Label();
            this.txtTintneeded = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.txtBrandselected = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColour
            // 
            this.cmbColour.DisplayMember = "Name";
            resources.ApplyResources(this.cmbColour, "cmbColour");
            this.cmbColour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.ValueMember = "Name";
            this.cmbColour.SelectedIndexChanged += new System.EventHandler(this.cmbColour_SelectedIndexChanged);
            // 
            // cmbSheen
            // 
            resources.ApplyResources(this.cmbSheen, "cmbSheen");
            this.cmbSheen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbSheen.FormattingEnabled = true;
            this.cmbSheen.Items.AddRange(new object[] {
            resources.GetString("cmbSheen.Items"),
            resources.GetString("cmbSheen.Items1"),
            resources.GetString("cmbSheen.Items2")});
            this.cmbSheen.Name = "cmbSheen";
            this.cmbSheen.SelectedIndexChanged += new System.EventHandler(this.cmbSheen_SelectedIndexChanged);
            // 
            // txtColour
            // 
            resources.ApplyResources(this.txtColour, "txtColour");
            this.txtColour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtColour.Name = "txtColour";
            // 
            // txtSheen
            // 
            resources.ApplyResources(this.txtSheen, "txtSheen");
            this.txtSheen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtSheen.Name = "txtSheen";
            // 
            // btnContinue
            // 
            resources.ApplyResources(this.btnContinue, "btnContinue");
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtColourselected
            // 
            resources.ApplyResources(this.txtColourselected, "txtColourselected");
            this.txtColourselected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtColourselected.Name = "txtColourselected";
            // 
            // txtSheenselected
            // 
            resources.ApplyResources(this.txtSheenselected, "txtSheenselected");
            this.txtSheenselected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtSheenselected.Name = "txtSheenselected";
            // 
            // txtBase
            // 
            resources.ApplyResources(this.txtBase, "txtBase");
            this.txtBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtBase.Name = "txtBase";
            // 
            // txtBaseselected
            // 
            resources.ApplyResources(this.txtBaseselected, "txtBaseselected");
            this.txtBaseselected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtBaseselected.Name = "txtBaseselected";
            // 
            // txtTintneededlist
            // 
            resources.ApplyResources(this.txtTintneededlist, "txtTintneededlist");
            this.txtTintneededlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtTintneededlist.Name = "txtTintneededlist";
            // 
            // txtTintneeded
            // 
            resources.ApplyResources(this.txtTintneeded, "txtTintneeded");
            this.txtTintneeded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtTintneeded.Name = "txtTintneeded";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblBrand
            // 
            resources.ApplyResources(this.lblBrand, "lblBrand");
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lblBrand.Name = "lblBrand";
            // 
            // cmbBrand
            // 
            resources.ApplyResources(this.cmbBrand, "cmbBrand");
            this.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            resources.GetString("cmbBrand.Items"),
            resources.GetString("cmbBrand.Items1"),
            resources.GetString("cmbBrand.Items2"),
            resources.GetString("cmbBrand.Items3"),
            resources.GetString("cmbBrand.Items4"),
            resources.GetString("cmbBrand.Items5"),
            resources.GetString("cmbBrand.Items6")});
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // txtBrandselected
            // 
            resources.ApplyResources(this.txtBrandselected, "txtBrandselected");
            this.txtBrandselected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtBrandselected.Name = "txtBrandselected";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::PaintPickerv2.Properties.Resources.shieldcoatlogov2;
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // frmBucket
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbSheen);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.txtBrandselected);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTintneeded);
            this.Controls.Add(this.txtTintneededlist);
            this.Controls.Add(this.txtBaseselected);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtSheenselected);
            this.Controls.Add(this.txtColourselected);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtSheen);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBucket";
            this.Load += new System.EventHandler(this.frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.ComboBox cmbSheen;
        private System.Windows.Forms.Label txtColour;
        private System.Windows.Forms.Label txtSheen;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnBack;
        //private _tintformulas_updateDataSet _tintformulas_updateDataSet;
       // private _tintformulas_updateDataSetTableAdapters.tintformulatableTableAdapter tintformulatableTableAdapter;
        private System.Windows.Forms.Label txtColourselected;
        private System.Windows.Forms.Label txtSheenselected;
        private System.Windows.Forms.Label txtBase;
        private System.Windows.Forms.Label txtBaseselected;
        private System.Windows.Forms.Label txtTintneededlist;
        private System.Windows.Forms.Label txtTintneeded;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label txtBrandselected;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}

