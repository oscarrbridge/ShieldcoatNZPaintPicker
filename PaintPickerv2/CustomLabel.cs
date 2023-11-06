using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using PaintPickerConnections;
using static PaintPickerConnections.Connection;

namespace PaintPickerv2
{
    public partial class frmCustom : Form
    {
        public frmCustom()
        {
            InitializeComponent();
        }

        private void frmCustom_Load(object sender, EventArgs e)
        {
        }

        private void chkOchre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOchre.Checked == true)
            {
                intOchre.Visible = true;
            }
            else
            {
                intOchre.Visible = false;
            }
        }

        private void chkBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlack.Checked == true)
            {
                intBlack.Visible = true;
            }
            else
            {
                intBlack.Visible = false;
            }
        }

        private void chkOxide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOxide.Checked == true)
            {
                intOxide.Visible = true;
            }
            else
            {
                intOxide.Visible = false;
            }
        }

        private void chkWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhite.Checked == true)
            {
                intWhite.Visible = true;
            }
            else
            {
                intWhite.Visible = false;
            }
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreen.Checked == true)
            {
                intGreen.Visible = true;
            }
            else
            {
                intGreen.Visible = false;
            }
        }

        private void chkBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlue.Checked == true)
            {
                intBlue.Visible = true;
            }
            else
            {
                intBlue.Visible = false;
            }
        }

        private void chkUmber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUmber.Checked == true)
            {
                intUmber.Visible = true;
            }
            else
            {
                intUmber.Visible = false;
            }
        }

        private void chkMagenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMagenta.Checked == true)
            {
                intMagenta.Visible = true;
            }
            else
            {
                intMagenta.Visible = false;
            }
        }

        private void print_QL800()
        {
            string colour = inpColour.Text;
            string sheenbase = $"{inpSheen.Text} {inpBase.Text}";
            string batchdate = DateTime.Now.ToString("dd/MM/yyyy");
            string order = inpOrder.Text;

            //Opening the code after acquiring the path from the environment variables
            bpac.IDocument doc = new bpac.Document();
            string strFilePath = Path.Combine(Environment.CurrentDirectory, "customlabel.lbx");
            doc.Open(strFilePath);

            //Sheet acquisition and setting
            object[] sheetNames = doc.SheetNames as object[];
            foreach (string sheetName in sheetNames)
            {
                doc.CurrentSheet = sheetName;
            }

            string[] objs = { "", "", "", "" };
            string[] elementscng = { colour, sheenbase, batchdate, order };

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
            string[] elementscng = { tintstrV2(), "Formula:" };

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

        private string tintstrV2()
        {
            CheckBox[] chk = { chkOchre, chkBlack, chkOxide, chkWhite, chkGreen, chkBlue, chkUmber, chkMagenta };
            NumericUpDown[] intbox = { intOchre, intBlack, intOxide, intWhite, intGreen, intGreen, intUmber, intMagenta };
            List<string> elements = new List<string>();

            for (int i = 0; i < chk.Length; i++)
            {
                if (chk[i].Checked && intbox[i].Value >= 1)
                {
                    elements.Add($"{chk[i].Text}: {(int)intbox[i].Value}g");
                }
            }

            string frmlatxt = string.Join(",\n", elements);

            return frmlatxt;
        }

        private string tintstr()
        {
            CheckBox[] chk = { chkOchre, chkBlack, chkOxide, chkWhite, chkGreen, chkBlue, chkUmber, chkMagenta };
            NumericUpDown[] intbox = { intOchre, intBlack, intOxide, intWhite, intGreen, intGreen, intUmber, intMagenta };
            List<string> elements = new List<string>();

            for (int i = 0; i < chk.Length; i++)
            {
                if (chk[i].Checked && intbox[i].Value >= 1)
                {
                    elements.Add($"{chk[i].Text}: {(int)intbox[i].Value}g");
                }
            }

            string frmlatxt = string.Join(", ", elements);

            return frmlatxt;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            inpColour.ReadOnly = true;
            inpSheen.ReadOnly = true;
            inpBase.ReadOnly = true;

            inpAddress.ReadOnly = true;
            inpName.ReadOnly = true;
            inpOrder.ReadOnly = true;

            intOchre.Visible = false;
            intBlack.Visible = false;
            intOxide.Visible = false;
            intWhite.Visible = false;
            intGreen.Visible = false;
            intBlue.Visible = false;
            intUmber.Visible = false;
            intMagenta.Visible = false;

            chkOchre.Visible = false;
            chkBlack.Visible = false;
            chkOxide.Visible = false;
            chkWhite.Visible = false;
            chkGreen.Visible = false;
            chkBlue.Visible = false;
            chkUmber.Visible = false;
            chkMagenta.Visible = false;

            btnBack.Enabled = true;
            btnContinue.Enabled = false;

            btnPrint.Visible = true;
            numericUpDown1.Visible = true;

            lblFormula.Visible = true;
            lblFormula.Text = tintstr();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            inpColour.ReadOnly = false;
            inpSheen.ReadOnly = false;
            inpBase.ReadOnly = false;

            inpAddress.ReadOnly = false;
            inpName.ReadOnly = false;
            inpOrder.ReadOnly = false;

            intOchre.Visible = true;
            intBlack.Visible = true;
            intOxide.Visible = true;
            intWhite.Visible = true;
            intGreen.Visible = true;
            intBlue.Visible = true;
            intUmber.Visible = true;
            intMagenta.Visible = true;

            chkOchre.Visible = true;
            chkBlack.Visible = true;
            chkOxide.Visible = true;
            chkWhite.Visible = true;
            chkGreen.Visible = true;
            chkBlue.Visible = true;
            chkUmber.Visible = true;
            chkMagenta.Visible = true;

            btnContinue.Enabled = true;
            btnBack.Enabled = false;

            btnPrint.Visible = false;
            numericUpDown1.Visible = false;

            lblFormula.Visible = false;
        }

        private void inputdata()
        {
            using (OleDbConnection connection = ConnectionV.GetConnection())
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (OleDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int maxId = 0;
                        using (OleDbCommand cmd = new OleDbCommand("SELECT MAX(ID) FROM tblCustomLables", connection))
                        {
                            cmd.Transaction = transaction;
                            object result = cmd.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                maxId = Convert.ToInt32(result);
                            }
                        }

                        string insertSql = "INSERT INTO tblCustomLables (ID, Colour, Sheen, Base, Tint, Address, Customer_Name, Order_Number, Date_) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                        using (OleDbCommand command = new OleDbCommand(insertSql, connection))
                        {
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@ID", maxId + 1);
                            command.Parameters.AddWithValue("@Colour", inpColour.Text);
                            command.Parameters.AddWithValue("@Sheen", inpSheen.Text);
                            command.Parameters.AddWithValue("@Base", inpBase.Text);
                            command.Parameters.AddWithValue("@Tint", tintstr());
                            command.Parameters.AddWithValue("@Address", inpAddress.Text);
                            command.Parameters.AddWithValue("@Customer_Name", inpName.Text);
                            command.Parameters.AddWithValue("@Order_Number", inpOrder.Text);
                            command.Parameters.AddWithValue("@Date_", DateTime.Now.ToString("dd/MM/yyyy"));
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Handle the exception here (e.g., log it)
                    }
                }
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            inputdata();

            print_QL800_formula();
            print_QL800();

            UploadFile();

            Close();
        }

        private void txtOrder_Click(object sender, EventArgs e)
        {

        }
    }
}