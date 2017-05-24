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
    public partial class OPgroupSimilar : Form
    {

        public string copyGroupStr="";
        public string key1Str;
        public string key2Str;
        public string key3Str;
        public string key4Str;
        public int simKey = 0;
        public double tolerance;
        public bool okPressed=false;

        public OPgroupSimilar()
        {
            InitializeComponent();

        }

        public void SetSourceColumns(DataColumnCollection Columns)
        {
            try
            {
                foreach (DataColumn col in Columns)
                {
                    key1.Items.Add(col.ColumnName.ToString());
                    key2.Items.Add(col.ColumnName.ToString());
                    key3.Items.Add(col.ColumnName.ToString());
                    key4.Items.Add(col.ColumnName.ToString());
                    copyGroup.Items.Add(col.ColumnName.ToString());                
                }

            }
            catch (System.Exception a_Ex)
            {
                MessageBox.Show(a_Ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
                    key1Str = item;
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
                    key2Str = item;
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
                    key3Str = item;
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
                    key4Str = item;
                    break;
                }
            }
        }
              

        private void copyGroup_TextChanged(object sender, EventArgs e)
        {
            string text = this.copyGroup.Text.ToUpper();

            for (int i = 0; i < this.copyGroup.Items.Count; i++)
            {
                string item = this.copyGroup.Items[i].ToString().ToUpper();
                if (item == text)
                {
                    this.copyGroup.SelectedIndex = i;
                    copyGroupStr = item;
                    break;
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.keytol1.Enabled = true;
            simKey = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.keytol1.Enabled = true;
            simKey = 2;    
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.keytol1.Enabled = true;
            simKey = 3;    
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.keytol1.Enabled = true;
            simKey = 4;    
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool tolOk = double.TryParse(keytol1.Text, out tolerance);
            if (!tolOk) tolerance = 0;

            if (copyGroupStr.Length == 0) 
            {
                MessageBox.Show("You have not selected any field to copy the grouping index!", "Error");
                return;
            }

            okPressed = true;
            this.Dispose();
        }


    }
}
