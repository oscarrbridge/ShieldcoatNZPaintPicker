namespace PaintPickerv2
{
    partial class frmBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBatch));
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtTintneeded = new System.Windows.Forms.Label();
            this.txtTintNeededList = new System.Windows.Forms.Label();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.cmbSheen = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.Label();
            this.txtSheen = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColour
            // 
            this.cmbColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Location = new System.Drawing.Point(37, 205);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(137, 28);
            this.cmbColour.TabIndex = 1;
            this.cmbColour.Text = "Select";
            this.cmbColour.Visible = false;
            this.cmbColour.SelectedIndexChanged += new System.EventHandler(this.cmbColour_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Shieldcoat (Paint)",
            "Shieldcoat (Basecoat)",
            "Shieldcoat (Pointing)",
            "Shieldcoat (Bases)",
            "Coloursteel",
            "Colourbond",
            "Monier",
            "Resene"});
            this.cmbType.Location = new System.Drawing.Point(37, 135);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(137, 28);
            this.cmbType.TabIndex = 0;
            this.cmbType.Text = "Select";
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // txtTintneeded
            // 
            this.txtTintneeded.AutoSize = true;
            this.txtTintneeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTintneeded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtTintneeded.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTintneeded.Location = new System.Drawing.Point(461, 65);
            this.txtTintneeded.Name = "txtTintneeded";
            this.txtTintneeded.Size = new System.Drawing.Size(134, 20);
            this.txtTintneeded.TabIndex = 19;
            this.txtTintneeded.Text = "Tinters needed:";
            this.txtTintneeded.Visible = false;
            // 
            // txtTintNeededList
            // 
            this.txtTintNeededList.AutoSize = true;
            this.txtTintNeededList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTintNeededList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtTintNeededList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTintNeededList.Location = new System.Drawing.Point(586, 65);
            this.txtTintNeededList.Name = "txtTintNeededList";
            this.txtTintNeededList.Size = new System.Drawing.Size(142, 20);
            this.txtTintNeededList.TabIndex = 18;
            this.txtTintNeededList.Text = "txtTintneededlist";
            this.txtTintNeededList.Visible = false;
            // 
            // cmbBase
            // 
            this.cmbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Items.AddRange(new object[] {
            "Strong",
            "Ultra Deep",
            "White",
            "Red"});
            this.cmbBase.Location = new System.Drawing.Point(38, 205);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(137, 28);
            this.cmbBase.TabIndex = 20;
            this.cmbBase.Text = "Select";
            this.cmbBase.Visible = false;
            this.cmbBase.SelectedIndexChanged += new System.EventHandler(this.cmbBase_SelectedIndexChanged);
            // 
            // cmbSheen
            // 
            this.cmbSheen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSheen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbSheen.FormattingEnabled = true;
            this.cmbSheen.Items.AddRange(new object[] {
            "Matt",
            "Satin",
            "Gloss"});
            this.cmbSheen.Location = new System.Drawing.Point(38, 276);
            this.cmbSheen.Name = "cmbSheen";
            this.cmbSheen.Size = new System.Drawing.Size(137, 28);
            this.cmbSheen.TabIndex = 22;
            this.cmbSheen.Text = "Select";
            this.cmbSheen.Visible = false;
            this.cmbSheen.SelectedIndexChanged += new System.EventHandler(this.cmbSheen_SelectedIndexChanged);
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtType.Location = new System.Drawing.Point(34, 110);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(99, 20);
            this.txtType.TabIndex = 24;
            this.txtType.Text = "Batch Type";
            // 
            // txtColour
            // 
            this.txtColour.AutoSize = true;
            this.txtColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtColour.Location = new System.Drawing.Point(33, 181);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(113, 20);
            this.txtColour.TabIndex = 25;
            this.txtColour.Text = "Batch Colour";
            // 
            // txtBase
            // 
            this.txtBase.AutoSize = true;
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtBase.Location = new System.Drawing.Point(34, 181);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(50, 20);
            this.txtBase.TabIndex = 26;
            this.txtBase.Text = "Base";
            // 
            // txtSheen
            // 
            this.txtSheen.AutoSize = true;
            this.txtSheen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSheen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtSheen.Location = new System.Drawing.Point(34, 251);
            this.txtSheen.Name = "txtSheen";
            this.txtSheen.Size = new System.Drawing.Size(61, 20);
            this.txtSheen.TabIndex = 27;
            this.txtSheen.Text = "Sheen";
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnContinue.Location = new System.Drawing.Point(582, 372);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(97, 36);
            this.btnContinue.TabIndex = 28;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtSize
            // 
            this.txtSize.AutoSize = true;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.txtSize.Location = new System.Drawing.Point(34, 325);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(44, 20);
            this.txtSize.TabIndex = 30;
            this.txtSize.Text = "Size";
            this.txtSize.Visible = false;
            // 
            // cmbSize
            // 
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(37, 349);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(137, 28);
            this.cmbSize.TabIndex = 29;
            this.cmbSize.Text = "Select";
            this.cmbSize.Visible = false;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnPrint.Location = new System.Drawing.Point(582, 372);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 36);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.numericUpDown1.Location = new System.Drawing.Point(700, 377);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 26);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::PaintPickerv2.Properties.Resources.shieldcoatlogov2;
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(411, 95);
            this.imgLogo.TabIndex = 33;
            this.imgLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnBack.Location = new System.Drawing.Point(465, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtSheen);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.cmbSheen);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.txtTintneeded);
            this.Controls.Add(this.txtTintNeededList);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBatch";
            this.Text = "Batch Labels";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label txtTintneeded;
        private System.Windows.Forms.Label txtTintNeededList;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.ComboBox cmbSheen;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.Label txtColour;
        private System.Windows.Forms.Label txtBase;
        private System.Windows.Forms.Label txtSheen;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label txtSize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnBack;
    }
}