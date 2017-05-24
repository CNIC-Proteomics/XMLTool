using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace XMLtool
{
    public partial class replaceForm : Form
    {

        public ArrayList col1;
        public ArrayList col2;
        public bool okChange;
        public string reference;
        public string target;

        public replaceForm()
        {
            InitializeComponent();
            okChange = false;
            reference = "";
            target = "";
        }


        private void loadBtn_Click(object sender, EventArgs e)
        {

            string file = this.listFileTxt.Text.Trim();

            try
            {

                StreamReader sr = new StreamReader(File.OpenRead(file));
                ArrayList myAL = new ArrayList();
                col1 = new ArrayList();
                col2 = new ArrayList();

                try
                {
                    while (sr.Peek() != -1) 
                    {
                        myAL.Add(sr.ReadLine());
                    }
                }
                catch (EndOfStreamException ex)
                {
                    Console.WriteLine(" Parse error: " + ex);
                    return;
                }

                int r = myAL.Count;

                string[] str;

                foreach (object o in myAL)
                {
                    str = Regex.Split(o.ToString(), "\t");
                    System.Collections.IEnumerator myEnumerator = str.GetEnumerator();

                    myEnumerator.MoveNext();
                    col1.Add((string)myEnumerator.Current);
                    this.listBox1.Items.Add((string)myEnumerator.Current); 
                    myEnumerator.MoveNext();
                    col2.Add((string)myEnumerator.Current);
                    this.listBox2.Items.Add((string)myEnumerator.Current); 

                }

                return;
            }
            catch
            {
                if (File.Exists(file))
                {
                    MessageBox.Show("read error.");
                    return;
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                    return;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (target.Trim() == "") 
            {
                MessageBox.Show("no target column selected!");
                return;
            }
            if (reference.Trim() == "")
            {
                MessageBox.Show("no reference column selected!");
                return;
            }

            okChange = true;
            this.Dispose();
        }

        public void SetSourceColumns(DataColumnCollection Columns)
        {
            try
            {
                foreach (DataColumn col in Columns)
                {
                    refCol.Items.Add(col.ColumnName.ToString());
                    targetCol.Items.Add(col.ColumnName.ToString());
                }

            }
            catch (System.Exception a_Ex)
            {
                MessageBox.Show(a_Ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            okChange = false;
            this.Dispose();
        }

        private void targetCol_TextChanged(object sender, EventArgs e)
        {
            string text = this.targetCol.Text.ToUpper();

            for (int i = 0; i < this.targetCol.Items.Count; i++)
            {
                string item = this.targetCol.Items[i].ToString().ToUpper();
                if (item == text)
                {
                    this.targetCol.SelectedIndex = i;
                    target = item;
                    break;
                }
            }

        }

        private void refCol_TextChanged(object sender, EventArgs e)
        {
            string text = this.refCol.Text.ToUpper();

            for (int i = 0; i < this.refCol.Items.Count; i++)
            {
                string item = this.refCol.Items[i].ToString().ToUpper();
                if (item == text)
                {
                    this.refCol.SelectedIndex = i;
                    reference = item;
                    break;
                }
            }

        }


        #region drag&drops
        private void listFileTxt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (file.GetUpperBound(0) == 0)
                {
                    if (File.Exists(file[0].ToString()))
                    {
                        e.Effect = DragDropEffects.All;
                    }
                    else { e.Effect = DragDropEffects.None; }
                }
            }
        }
        private void listFileTxt_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (IsTxtFile(file[0]))
            {
                listFileTxt.Text = file[0].Trim();
            } 
        }

        private static bool IsTxtFile(string f)
        {
            return f != null &&
                f.EndsWith(".txt", StringComparison.OrdinalIgnoreCase);
        }
        #endregion

    }
}
