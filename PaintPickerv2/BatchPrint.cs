using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using PaintPickerConnections;

#pragma warning disable IDE1006
#pragma warning disable CS0252

namespace PaintPickerv2
{
    public partial class frmBatch : Form
    {
        public frmBatch()
        {
            InitializeComponent();

            //if (Connection.connection.State != ConnectionState.Open)
            //{
            //    Connection.connection.Open();
            //}
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex != -1)
            {
                List<string> data = new List<string>();

                cmbColour.ResetBindings();
                if (data.Count > 0)
                {
                    data.RemoveAt(0);
                }

                //dbdict
                data.Add(typeColour(cmbType.Text.ToString()));

                string tableName = typeColour(cmbType.Text.ToString());
                DataTable table = GetDataFromTable(tableName);

                cmbColour.DataSource = table;
                cmbColour.DisplayMember = "Name";
            }

            if (cmbType.SelectedItem == "Shieldcoat (Pointing)")
            {
                cmbBase.Visible = false;
                cmbSheen.Visible = false;

                cmbSize.Visible = true;
                cmbColour.Visible = true;

                txtSize.Visible = true;

                pointing_size();
            }
            else if (cmbType.SelectedItem != "Shieldcoat (Pointing)" || cmbType.SelectedItem != "Shieldcoat (Bases)")
            {
                cmbBase.Visible = false;

                cmbSheen.Visible = true;
                cmbColour.Visible = true;
                cmbSize.Visible = true;

                txtSize.Visible = true;

                paint_size();
            }
            else if (cmbType.SelectedItem == "Shieldcoat (Bases)")
            {
                cmbColour.Visible = false;

                cmbBase.Visible = true;
                cmbSheen.Visible = true;
                cmbSize.Visible = true;

                txtSize.Visible = true;

                paint_size();
            }
            checkContinue();
        }

        private void pointing_size()
        {
            const int pointing_batch_size = 1000;

            cmbSize.SelectedIndex = -1;

            cmbSize.Items.Clear();

            cmbSize.Items.Add(pointing_batch_size);
        }

        private void paint_size()
        {
            const int paint_batch_size1 = 1500;
            const int paint_batch_size2 = 1000;
            const int paint_batch_size3 = 500;

            cmbSize.SelectedIndex = -1;

            cmbSize.Items.Clear();

            cmbSize.Items.Add(paint_batch_size1);
            cmbSize.Items.Add(paint_batch_size2);
            cmbSize.Items.Add(paint_batch_size3);
        }

        //Read tint required from database & decode
        private string readtintneeded()
        {
            string[] tint = { "[Ochre (875)]", "[Black (875)]", "[Oxide (875)]",
                "[White (875)]", "[Green (875)]", "[Blue (303)]", "[Umber (810)]", "[Magenta (V)]" };

            string tintrequired = "";
            float tint_size = Convert.ToSingle(cmbSize.SelectedItem);
            float updatedformula = 0F;
            float bucket_size = 15;

            if (cmbType.SelectedItem == "Shieldcoat (Pointing)")
            {
                bucket_size = 10;
                tint_size = 1000;
            }

            if (cmbType.SelectedItem != "Paint (No Colour)")
            {
                if (Connection.connection.State != ConnectionState.Open)
                {
                    Connection.connection.Open();
                }

                for (int i = 0; i < tint.Length; i++)
                {
                    OleDbCommand command = new OleDbCommand($"SELECT {tint[i]} FROM {typeColour(cmbType.Text.ToString())} WHERE Name='{cmbColour.Text}'", Connection.connection);

                    OleDbDataReader read = command.ExecuteReader();

                    while (read.Read())
                    {
                        if (read[0].ToString() != "")
                        {
                            if (cmbSize.SelectedItem != null)
                            {
                                updatedformula = Convert.ToSingle(read[0]) * (tint_size / bucket_size) / 1000;
                            }

                            tintrequired += tint[i] += " ";
                            tintrequired += updatedformula.ToString("0.00");
                            tintrequired += "Kg\n ";
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
            else
            {
                float basetintrequired = 0;
                if (cmbBase.SelectedItem == "Ultra Deep")
                {
                    basetintrequired = 4500 * (tint_size / bucket_size) / 1000f;
                    tintrequired = $"White(875) {basetintrequired}Kg";
                }
                else if (cmbBase.SelectedItem == "White")
                {
                    basetintrequired = 4800 * (tint_size / bucket_size) / 1000f;
                    tintrequired = $"White(875) {basetintrequired}Kg";
                }
                else if (cmbBase.SelectedItem == "Red")
                {
                    basetintrequired = 9999 * (tint_size / bucket_size) / 1000f;
                    tintrequired = $"Oxide(875) {basetintrequired}Kg";
                }
                Connection.connection.Close();
                return tintrequired;
            }
        }

        private DataTable GetDataFromTable(string tableName)
        {
            string queryString = $"SELECT NAME FROM {tableName}";
            OleDbCommand command = new OleDbCommand(queryString, Connection.connection);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        private string typeColour(string type)
        {
        //    // Create a dictionary that maps type names to BindingSource property names
        //    Dictionary<string, string> dbdict = new Dictionary<string, string>
        //    {
        //{ "Paint", "tblShieldcoatColours" },
        //{ "Paint (No Colour)", "tblShieldcoatColours" },
        //{ "Pointing", "tblShieldcoatRangePointing" }
        //    };
            return BatchTable.batch_dbdict[type];
        }

        private void checkContinue()
        {
            if (cmbType.SelectedItem != "Shieldcoat (Pointing)" || cmbType.SelectedItem != "Shieldcoat (Bases)")
            {
                if (cmbColour.SelectedIndex != -1 && cmbSheen.SelectedIndex != -1 && cmbSize.SelectedIndex != -1)
                {
                    btnContinue.Enabled = true;
                }
                else
                {
                    btnContinue.Enabled = false;
                }
            }
            else if (cmbType.SelectedItem == "Shieldcoat (Bases)")
            {
                if (cmbBase.SelectedIndex != -1 && cmbSheen.SelectedIndex != -1 && cmbSize.SelectedIndex != -1)
                {
                    btnContinue.Enabled = true;
                }
                else
                {
                    btnContinue.Enabled = false;
                }
            }
            else if (cmbType.SelectedItem == "Shieldcoat (Pointing)")
            {
                if (cmbColour.SelectedIndex != -1 && cmbSize.SelectedIndex != -1)
                {
                    btnContinue.Enabled = true;
                }
                else
                {
                    btnContinue.Enabled = false;
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //show everything else
            txtTintneeded.Visible = true;
            txtTintNeededList.Visible = true;

            btnContinue.Visible = false;
            btnPrint.Visible = true;
            btnBack.Visible = true;

            numericUpDown1.Visible = true;


            txtTintNeededList.Text = readtintneeded();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //hide everything else
            txtTintneeded.Visible = false;
            txtTintNeededList.Visible = false;

            btnContinue.Visible = true;
            btnPrint.Visible = false;
            btnBack.Visible = false;

            numericUpDown1.Visible = false;
        }

        private void cmbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkContinue();
        }

        private void cmbBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkContinue();
        }

        private void cmbSheen_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkContinue();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkContinue();
        }

        private string getBrand()
        {
            if (cmbType.SelectedItem == "Paint" || cmbType.SelectedItem == "Paint (No Colour)")
            {
                return "Roofbond Premium Finish";
            }
            else if (cmbType.SelectedItem == "Pointing")
            {
                return "Roofbond Premium Pointing";
            }
            return "";
        }

        private string getcolourbase()
        {
            if (cmbType.SelectedItem == "Paint" || cmbType.SelectedItem == "Pointing")
            {
                return cmbColour.Text;
            }
            else if (cmbType.SelectedItem == "Paint (No Colour)")
            {
                return cmbBase.Text + " Base";
            }
            return "";
        }

        private string getsheen()
        {
            if (cmbType.SelectedItem == "Pointing")
            {
                return "";
            }
            else if (cmbType.SelectedItem == "Paint (No Colour)" || cmbType.SelectedItem == "Paint")
            {
                return cmbSheen.SelectedItem.ToString();
            }
            return "";
        }

        private int print_num()
        {
            string str_print = cmbSize.SelectedItem.ToString();

            if (cmbType.SelectedItem == "Pointing")
            {
                return int.Parse(str_print) / 10;
            }
            else if (cmbType.SelectedItem == "Paint (No Colour)" || cmbType.SelectedItem == "Paint")
            {
                return int.Parse(str_print) / 15;
            }
            return 0;
        }

        private void print_QL800_formula()
        {
            bpac.IDocument doc = new bpac.Document();
            string strFilePath = Path.Combine(Environment.CurrentDirectory, "tintlabel.lbx");
            doc.Open(strFilePath);

            //Sheet acquisition and setting
            object[] sheetNames = doc.SheetNames as object[];
            foreach (string sheetName in sheetNames)
            {
                doc.CurrentSheet = sheetName;
            }

            string[] objs = { "", "" };
            string[] elementscng = { readtintneeded(), "Formula:" };

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
            doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);

            // Print setting end (=Print start)
            doc.EndPrint();

            // Close template
            doc.Close();
        }

        private void print_QL800()
        {
            string brand = getBrand();
            string colourbase = getcolourbase();
            string combo = $"{brand} {colourbase}";

            string sheen = getsheen();
            string batchdate = DateTime.Now.ToString("yyMMdd");

            //Opening the code after acquiring the path from the environment variables
            bpac.IDocument doc = new bpac.Document();
            string strFilePath = Path.Combine(Environment.CurrentDirectory, "batchlabel.lbx");
            doc.Open(strFilePath);

            //Sheet acquisition and setting
            object[] sheetNames = doc.SheetNames as object[];
            foreach (string sheetName in sheetNames)
            {
                doc.CurrentSheet = sheetName;
            }

            string[] objs = { "", "", "" };
            string[] elementscng = { combo, batchdate, sheen };

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print_num();
            print_QL800_formula();
            print_QL800();

            DialogResult result = MessageBox.Show($"Printing {numericUpDown1.Value} labels");
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}