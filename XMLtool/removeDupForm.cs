using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLtool
{
    public partial class removeDupForm : Form
    {
        public string key1str;
        public string key2str;
        public string key3str;
        public string key4str;
        public string prefColStr;
        public string sortSensestr;
        public bool okPressed;

        public removeDupForm()
        {
            InitializeComponent();
            okPressed = false;
            key1str = "";
            key2str = "";
            key3str = "";
            key4str = "";
            sortSensestr = "";

            //sortSenseCmb.Items.Add("Asc");
            //sortSenseCmb.Items.Add("Desc");
            
        }


        public void SetSourceColumns(DataColumnCollection Columns)
        {
            try
            {
                key1.Items.Add("");
                key2.Items.Add("");
                key3.Items.Add("");
                key4.Items.Add("");

                foreach (DataColumn col in Columns)
                {
                    key1.Items.Add(col.ColumnName.ToString());
                    key2.Items.Add(col.ColumnName.ToString());
                    key3.Items.Add(col.ColumnName.ToString());
                    key4.Items.Add(col.ColumnName.ToString());
                    //prefColumn.Items.Add(col.ColumnName.ToString());
                }

            }
            catch (System.Exception a_Ex)
            {
                MessageBox.Show(a_Ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            okPressed = false;
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            key1_TextChanged(null, null);
            key2_TextChanged(null, null);
            key3_TextChanged(null, null);
            key4_TextChanged(null, null);
            
            if (this.key1str.Trim() == "")
            {
                MessageBox.Show("First key not selected", "error", MessageBoxButtons.OK);
                return;
            }

            okPressed = true;
            sortSensestr = txbSortPref.Text.Trim();
            this.Dispose();
        }

        private void key1_TextChanged(object sender, EventArgs e)
        {
            string text = this.key1.Text.ToUpper();

            for (int i = 0; i < this.key1.Items.Count; i++)
            {
                string item = this.key1.Items[i].ToString().ToUpper();
                if (item == text)
                {
                    this.key1.SelectedIndex = i;
                    key1str = item;
                    break;
                }
            }
        }

        private void key2_TextChanged(object sender, EventArgs e)
        {
            string text = this.key2.Text.ToUpper();

            for (int i = 0; i < this.key2.Items.Count; i++)
            {
                string item = this.key2.Items[i].ToString().ToUpper();
                if (item == text)
                {
                    this.key2.SelectedIndex = i;
                    key2str = item;
                    break;
                }
            }

        }

        private void key3_TextChanged(object sender, EventArgs e)
        {
            string text = this.key3.Text.ToUpper();

            for (int i = 0; i < this.key3.Items.Count; i++)
            {
                string item = this.key3.Items[i].ToString().ToUpper();
                if (item == text)
                {
                    this.key3.SelectedIndex = i;
                    key3str = item;
                    break;
                }
            }
        }

        private void key4_TextChanged(object sender, EventArgs e)
        {
            string text = this.key4.Text.ToUpper();

            for (int i = 0; i < this.key4.Items.Count; i++)
            {
                string item = this.key4.Items[i].ToString().ToUpper();
                if (item == text)
                {
                    this.key4.SelectedIndex = i;
                    key4str = item;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxRedundantPeaks_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRedundantPeaks.Checked)
            {
                key1.Text = "RAWFileName";
                key1.Enabled = false;
                key2.Text = "Sequence";
                key2.Enabled = false;
                key3.Text = "Charge";
                key3.Enabled = false;
                key4.Text = "";
                key4.Enabled = false;
                txbSortPref.Text = "PeakIntensity DESC";
                txbSortPref.Enabled = false;
            }
            else
            {
                key1.Enabled = true;
                key2.Enabled = true;
                key3.Enabled = true;
                key4.Enabled = true;
                txbSortPref.Enabled = true;
            }
        }

        //private void prefColumn_TextChanged(object sender, EventArgs e)
        //{
        //    string text = this.prefColumn.Text.ToUpper();

        //    for (int i = 0; i < this.prefColumn.Items.Count; i++)
        //    {
        //        string item = this.prefColumn.Items[i].ToString().ToUpper();
        //        if (item == text)
        //        {
        //            this.prefColumn.SelectedIndex = i;
        //            prefColStr = item;
        //            break;
        //        }
        //    }
        //}

        //private void sortSenseCmb_TextChanged(object sender, EventArgs e)
        //{
        //    string text = this.sortSenseCmb.Text.ToUpper();

        //    for (int i = 0; i < this.sortSenseCmb.Items.Count; i++)
        //    {
        //        string item = this.sortSenseCmb.Items[i].ToString().ToUpper();
        //        if (item == text)
        //        {
        //            this.sortSenseCmb.SelectedIndex = i;
        //            sortSensestr = item;
        //            break;
        //        }
        //    }

        //}


    }
}
