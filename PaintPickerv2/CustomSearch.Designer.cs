
namespace PaintPickerv2
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkOrder = new System.Windows.Forms.CheckBox();
            this.chkAddress = new System.Windows.Forms.CheckBox();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(227)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(439, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(278, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // chkOrder
            // 
            this.chkOrder.AutoSize = true;
            this.chkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.chkOrder.Location = new System.Drawing.Point(438, 68);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.Size = new System.Drawing.Size(73, 24);
            this.chkOrder.TabIndex = 3;
            this.chkOrder.Text = "Order";
            this.chkOrder.UseVisualStyleBackColor = true;
            // 
            // chkAddress
            // 
            this.chkAddress.AutoSize = true;
            this.chkAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.chkAddress.Location = new System.Drawing.Point(513, 68);
            this.chkAddress.Name = "chkAddress";
            this.chkAddress.Size = new System.Drawing.Size(94, 24);
            this.chkAddress.TabIndex = 4;
            this.chkAddress.Text = "Address";
            this.chkAddress.UseVisualStyleBackColor = true;
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.chkCustomer.Location = new System.Drawing.Point(607, 68);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(105, 24);
            this.chkCustomer.TabIndex = 5;
            this.chkCustomer.Text = "Customer";
            this.chkCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.btnSearch.Location = new System.Drawing.Point(716, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::PaintPickerv2.Properties.Resources.shieldcoatlogov2;
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(411, 95);
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkCustomer);
            this.Controls.Add(this.chkAddress);
            this.Controls.Add(this.chkOrder);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.Text = "Custom Label Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.CheckBox chkAddress;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}