using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using PaintPickerConnections;

namespace PaintPickerv2
{
    public partial class frmBucket : Form
    {
        //Initialize code
        public frmBucket()
        {
            InitializeComponent();

            //if (Connection.connection.State != ConnectionState.Open)
            //{
            //    Connection.connection.Open();
            //}
        }

        //Initialize code
        private void frm1_Load(object sender, EventArgs e)
        {
            cmbColour.Text = "Select...";
        }

        //Check that all requirements are met to move to next page
        private void checkbothticks()
        {
            if (cmbBrand.SelectedIndex == 1)
            {
                btnContinue.Enabled = true;
            }
            else if (cmbColour.SelectedIndex == -1)
            {
                btnContinue.Enabled = false;
            }
            else if (cmbSheen.SelectedIndex == -1)
            {
                btnContinue.Enabled = false;
            }
            else if (cmbSheen.SelectedIndex != -1 && cmbColour.SelectedIndex != -1)
            {
                btnContinue.Enabled = true;
            }
        }

        private string giveselectedtable_brand(string brand)
        {
            return BucketTable.bucket_dbdict[brand];
        }

        //Change colours in cmbColour
        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> data = new List<string>();

            cmbColour.ResetBindings();
            if (data.Count > 0)
            {
                data.RemoveAt(0);
            }

            data.Add(giveselectedtable_brand(cmbBrand.Text.ToString()));

            string tableName = giveselectedtable_brand(cmbBrand.Text.ToString());
            DataTable table = GetDataFromTable(tableName);

            cmbColour.DataSource = table;
            cmbColour.DisplayMember = "Name";

            if (cmbBrand.SelectedIndex != 1)
            {
                cmbSheen.Text = "Select...";
            }
        }

        //Change colours in cmbColour
        private DataTable GetDataFromTable(string tableName)
        {
            string queryString = $"SELECT NAME FROM {tableName}";
            OleDbCommand command = new OleDbCommand(queryString, Connection.connection);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Make cross tick after combo box changed
        private void cmbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedIndex == 1)
            {
                cmbSheen.Text = "";
                cmbSheen.Visible = false;
                //checkbothticks();
            }
            else
            {
                cmbSheen.Visible = true;
            }
            checkbothticks();
        }

        //Make cross tick after combo box changed
        private void cmbSheen_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkbothticks();
        }

        //Read tint required from database & decode
        private string readtintneeded()
        {
            string[] tint = { "[Ochre (875)]", "[Black (875)]", "[Oxide (875)]",
                "[White (875)]", "[Green (875)]", "[Blue (303)]", "[L ( Umber)]", 
                "[Magenta (V)]", "[B (810)]", "[C (810)]", "[I (810)]", "[D (810)]", 
                "[RN]", "[AN]", "[L]"};

            string tintrequired = "";

            if (Connection.connection.State != ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            for (int i = 0; i < tint.Length; i++)
            {
                OleDbCommand command = new OleDbCommand($"SELECT {tint[i]} FROM {giveselectedtable_brand(cmbBrand.Text)} WHERE Name='{txtColourselected.Text}'", Connection.connection);

                OleDbDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    if (read[0].ToString() != "")
                    {
                        tintrequired += tint[i] += " ";
                        tintrequired += read[0].ToString();
                        tintrequired += "g\n ";
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            string[] chartoremove = { "[", "]" };

            for (int i = 0; i < chartoremove.Length; i++)
            {
                tintrequired = tintrequired.Replace(chartoremove[i], "");
            }

            Connection.connection.Close();
            return tintrequired;
        }

        //Read base required from database & decode
        private string readbaseneeded()
        {

            if (Connection.connection.State != ConnectionState.Open)
            {
                Connection.connection.Open();
            }

            OleDbCommand command = new OleDbCommand($"SELECT Base FROM {giveselectedtable_brand(cmbBrand.Text)} WHERE Name='{txtColourselected.Text}'", Connection.connection);

            OleDbDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                return read[0].ToString();
            }

            Connection.connection.Close();
            return null;
        }

        //Trigger next page
        private void btnContinue_Click(object sender, EventArgs e)
        {
            GOTOpage2();
        }

        //Trigger previous page
        private void btnBack_Click(object sender, EventArgs e)
        {
            GOTOpage1();
        }

        //Hide all page 1 elements
        private void GOTOpage2()
        {
            txtBrandselected.Text = cmbBrand.Text;
            txtColourselected.Text = cmbColour.Text;
            txtSheenselected.Text = cmbSheen.Text;

            txtColourselected.Visible = true;
            txtSheenselected.Visible = true;
            txtBrandselected.Visible = true;

            cmbBrand.Visible = false;
            cmbColour.Visible = false;
            cmbSheen.Visible = false;

            btnBack.Visible = true;
            btnBack.Enabled = true;

            txtBaseselected.Text = readbaseneeded();

            txtTintneededlist.Text = readtintneeded();

            txtBase.Visible = true;
            txtBaseselected.Visible = true;

            txtTintneededlist.Visible = true;

            txtTintneeded.Visible = true;

            btnContinue.Visible = false;

            btnPrint.Visible = true;

            numericUpDown1.Visible = true;

            if (cmbBrand.SelectedIndex == 2)
            {
                txtSheen.Visible = false;
            }
        }

        //Hide all page 2 elements
        private void GOTOpage1()
        {
            txtColourselected.Text = cmbColour.Text;
            txtSheenselected.Text = cmbSheen.Text;

            txtColourselected.Visible = false;
            txtSheenselected.Visible = false;
            txtBrandselected.Visible = false;

            cmbBrand.Visible = true;
            cmbColour.Visible = true;
            cmbSheen.Visible = true;

            btnBack.Visible = false;
            btnBack.Enabled = false;

            txtBaseselected.Text = readbaseneeded();

            txtBase.Visible = false;
            txtBaseselected.Visible = false;

            txtSheen.Visible = true;

            txtTintneededlist.Visible = false;

            txtTintneeded.Visible = false;

            btnContinue.Visible = true;

            btnPrint.Visible = false;

            numericUpDown1.Visible = false;

            if (cmbBrand.SelectedIndex == 1)
            {
                cmbSheen.Visible = false;
            }
        }

        //Decode and format the tint formula for print page
        private string createtints()
        {
            string tintneeded = readtintneeded();

            string[] chartoremove = { "\n", "(875) " };

            for (int i = 0; i < chartoremove.Length; i++)
            {
                tintneeded = tintneeded.Replace(chartoremove[i], "");
            }

            int[] j = { 0, 0, 0, 0, 0, 0, 0, 0 };
            int k = 0;

            if (tintneeded.Length > 40)
            {
                for (int i = 0; i < tintneeded.Length; i++)
                {
                    if (tintneeded[i] == 'g' && tintneeded[i + 1] == ' ')
                    {
                        j[k] = i;
                        k++;
                    }
                }

                for (int i = 1; i < j.Length; i++)
                {
                    if (j[i] != 0)
                    {
                        k = j[i - 1];
                    }
                }

                tintneeded = tintneeded.Insert(k + 1, "\n");
            }

            return tintneeded;
        }

        //Decode and format the base required for print page
        private string createbasesheen()
        {
            string basesheen = "";
            basesheen += txtBaseselected.Text;
            basesheen += " ";
            basesheen += txtSheenselected.Text;

            return basesheen;
        }

        //Send a print payload
        private void print_QL800()
        {
            string colour = txtColourselected.Text;
            string basesheen = createbasesheen();
            string tints = createtints();
            string date = DateTime.Now.ToString("d/M/yy");

            //Opening the code after acquiring the path from the environment variables
            bpac.IDocument doc = new bpac.Document();
            string strFilePath = Path.Combine(Environment.CurrentDirectory, "bucketlabel.lbx");
            doc.Open(strFilePath);

            //Sheet acquisition and setting
            object[] sheetNames = doc.SheetNames as object[];
            foreach (string sheetName in sheetNames)
            {
                doc.CurrentSheet = sheetName;
            }

            string[] objs = { "", "", "", "" };
            string[] elementscng = { date, tints, basesheen, colour };

            int i = 0;

            foreach (bpac.IObject obj in doc.Objects)
            {
                objs[i] = obj.Name;
                i++;
            }

            bpac.Object textObject;

            for (int k = 0; k < objs.Length; k++)
            {
                textObject = doc.GetObject(objs[k]);
                textObject.Text = elementscng[k];
            }

            // Print setting start
            doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);

            // Adds a print job (2 jobs are printed)
            doc.PrintOut((int)numericUpDown1.Value, bpac.PrintOptionConstants.bpoDefault);

            // Print setting end (=Print start)
            doc.EndPrint();

            // Close template
            doc.Close();
        }

        //Open print page
        private void btnPrint_Click(object sender, EventArgs e)
        {
            print_QL800();
            DialogResult result = MessageBox.Show($"Printing {numericUpDown1.Value.ToString()} labels");
            if (result == DialogResult.OK)
            {
                GOTOpage1();
            }
        }
    }
}