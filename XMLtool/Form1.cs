using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace XMLtool
{
    public partial class mainForm : Form
    {

        DataSet ds;
        BindingSource source1 = new BindingSource();


        public mainForm()
        {
            InitializeComponent();
            source1 = new BindingSource();
            this.Text = "XMLtool v." + XMLtool.Properties.Resources.version.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string schemaFile = xmlSchematxt.Text.Trim();
            string xmlFile = xmlFiletxt.Text.Trim();
            int tableNum = getTableNum();
            if (tableNum == -1) return;

            ds = new DataSet();
            try
            {
                ds.ReadXmlSchema(schemaFile);
                ds.ReadXml(xmlFile);
            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }
            
            
            
            try
            {
                dataGridView1.DataSource = ds.Tables[tableNum];
                tableNameLbl.Text = ds.Tables[tableNum].TableName;
      
            }
            catch (System.Exception ex) 
            {
                MessageBox.Show("Table num is too large for this DB : Error : " + ex.Message);
            }

            updateRowNumber();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileToBeSaved = this.xmlFiletxt.Text.Trim();

            //ds.Tables[1].
            DataSet dsSave = new DataSet();
            dsSave = ds.Copy();

            int tableNum = getTableNum();
            if (tableNum == -1) return;

            DataView dvSave = new DataView(dsSave.Tables[tableNum]);

            if (txtFilter.Text.Trim() != "")
            {
                dvSave.RowFilter = "not (" + txtFilter.Text.Trim() + ")";

                dvSave.Sort = "";

                while (dvSave.Count > 0)
                {
                    dvSave.Delete(dvSave.Count - 1);
                }
            }


            dsSave.WriteXml(fileToBeSaved);

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int tableNum = getTableNum();
            if (tableNum == -1) return;

            // Create a BindingSource and set its DataSource property to
            // the DataView.
            //BindingSource source1 = new BindingSource();
            source1.DataSource = ds.Tables[tableNum];

            // Set the data source for the DataGridView.
            dataGridView1.DataSource = source1;

            //The Filter string can include Boolean expressions.
            source1.Filter = txtFilter.Text.Trim();

            updateRowNumber();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            
            string schemaFile = xmlSchematxt.Text.Trim();
            string xmlFile2 = txtMergeXML.Text.Trim();
            int tableNum = getTableNum();
            if (tableNum == -1) return;

            DataSet ds2 = new DataSet();
            try
            {
                ds2.ReadXmlSchema(schemaFile);
                ds2.ReadXml(xmlFile2);
            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }

            string primKey = ds.Tables[tableNum].PrimaryKey[0].ToString();
            int lastRowOfBoth = Math.Max(ds.Tables[tableNum].Rows.Count,ds2.Tables[tableNum].Rows.Count);

            for (int i = 0; i < ds2.Tables[tableNum].Rows.Count; i++)
            {
                ds2.Tables[tableNum].Rows[i][primKey] = lastRowOfBoth + 1 + i; 
            }


            ds.Merge(ds2, true,MissingSchemaAction.Add);

            updateRowNumber();
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            int tableNum = getTableNum();
            if (tableNum == -1) return;

            replaceForm replace = new replaceForm();
            DataColumnCollection cols;

            cols = ds.Tables[tableNum].Columns;

            replace.SetSourceColumns(cols);

            replace.ShowDialog(this);

            if (!replace.okChange)  return;

            DataView dv = new DataView(ds.Tables[tableNum]);
            dv.Sort = "";
            dv.RowFilter = "";

            ArrayList references=(ArrayList)replace.col1.Clone();
            ArrayList targets=(ArrayList)replace.col2.Clone();

            Type refType = ds.Tables[tableNum].Columns[replace.reference].DataType;
            Type targetType = ds.Tables[tableNum].Columns[replace.target].DataType;

            for (int i = 0; i < references.Count; i++)
            {
                string currReference = (string)references[i].ToString();
                string currTarget = (string)targets[i].ToString();

                try
                {
                    if (refType.Name == "String")
                    {
                        dv.RowFilter = replace.reference + " like '%" + currReference + "%'";
                    }
                    else
                    {
                        dv.RowFilter = replace.reference + " = " + currReference;
                    }

                    for (int j = 0; j < dv.Count; j++)
                    {
                        dv[j][replace.target] = targets[i].ToString();
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Reference " + currReference.ToString() + " skipped. " + ex.Message);
                }
 
            }

            updateRowNumber();
        }

        private void removeDuplBtn_Click(object sender, EventArgs e)
        {

            int tableNum = getTableNum();
            if (tableNum == -1) return;

            string key1 = "";
            string key2 = "";
            string key3 = "";
            string key4 = "";
            string sortPref = "";
            string sortSense = "";

            removeDupForm remove = new removeDupForm();
            DataColumnCollection cols;

            cols = ds.Tables[tableNum].Columns;

            remove.SetSourceColumns(cols);

            remove.ShowDialog(this);

            if (!remove.okPressed)
            {
                return;
            }

            key1 = remove.key1str;
            key2 = remove.key1str;
            key3 = remove.key1str;
            key4 = remove.key1str;
            sortPref = remove.prefColStr;
            sortSense = remove.sortSensestr;


            string sort = remove.key1str;
            if (remove.key2str != "")
            { 
                sort += ", " + remove.key2str;
                key2=remove.key2str;
            }

            if (remove.key3str != "") 
            {
                sort += ", " + remove.key3str;
                key3=remove.key3str;
            }

            if (remove.key4str != "")
            {
                sort += ", " + remove.key4str;
                key4 = remove.key4str;
            }

            if (remove.prefColStr != "" && remove.prefColStr != null)
            {
                sort += ", " + remove.prefColStr;
                sortPref = remove.prefColStr;
                if (remove.sortSensestr != "")
                {
                    sort += " " + remove.sortSensestr;
                    sortSense = remove.sortSensestr;
                }
            }


            DataView dv = new DataView(ds.Tables[tableNum]);
            try
            {
                dv.Sort = sort;
                dv.RowFilter = this.txtFilter.Text.Trim();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "error when filtering & sorting out the data");
                return;
            }

            int i = 0;
            while (i < dv.Count - 1)
            {
                string val1 = dv[i][key1].ToString();
                string cmp1 = dv[i + 1][key1].ToString();
                string val2 = dv[i][key2].ToString();
                string cmp2 = dv[i + 1][key2].ToString();
                string val3 = dv[i][key3].ToString();
                string cmp3 = dv[i + 1][key3].ToString();
                string val4 = dv[i][key4].ToString();
                string cmp4 = dv[i + 1][key4].ToString();
                
                
                //duplicate
                if (val1 == cmp1 && val2 == cmp2 && val3 == cmp3 && val4 == cmp4)
                    dv.Delete(i + 1);
                else
                    i++;
            }

            updateRowNumber();
        }

        private int getTableNum()
        {
            int tableNum;
            try
            {
                tableNum = int.Parse(tableNumTxt.Text);
            }
            catch
            {
                MessageBox.Show("Table num is not a number");
                return -1;
            }

            return tableNum;
        }


        #region drag&drops
        private void xmlFiletxt_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (IsXmlFile(file[0]))
            {
                xmlFiletxt.Text = file[0].Trim();               
            }        
        }
        private void xmlFiletxt_DragEnter(object sender, DragEventArgs e)
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
        private void xmlSchematxt_DragEnter(object sender, DragEventArgs e)
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
        private void xmlSchematxt_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (IsXsdFile(file[0]))
            {
                xmlSchematxt.Text = file[0].Trim();
            }  
        }
        private void txtMergeXML_DragEnter(object sender, DragEventArgs e)
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
        private void txtMergeXML_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (IsXmlFile(file[0]))
            {
                txtMergeXML.Text = file[0].Trim();
            } 
        }

        private static bool IsXmlFile(string f)
        {
            return f != null &&
                f.EndsWith(".xml", StringComparison.OrdinalIgnoreCase);
        }
        private static bool IsXsdFile(string f)
        {
            return f != null &&
                f.EndsWith(".xsd", StringComparison.OrdinalIgnoreCase);
        }
        #endregion

        private void btnSort_Click(object sender, EventArgs e)
        {
            int tableNum = getTableNum();
            if (tableNum == -1) return;

            // Create a BindingSource and set its DataSource property to
            // the DataView.
            //BindingSource source1 = new BindingSource();
            source1.DataSource = ds.Tables[tableNum];

            // Set the data source for the DataGridView.
            dataGridView1.DataSource = source1;

            //The Filter string can include Boolean expressions.
            source1.Sort = txtSort.Text.Trim();

            updateRowNumber();

        }

        private void updateRowNumber()
        {
            lblRowNumber.Text = (dataGridView1.Rows.Count - 1).ToString();
        }

        private void mappingbtn_Click(object sender, EventArgs e)
        {
            OPmapping myMapping = new OPmapping();
            
            myMapping.setOriginalSchema(this.xmlSchematxt.Text.Trim());
            myMapping.setOriginalXML(this.xmlFiletxt.Text.Trim());
            

            int numTable=0;
            bool numOk= int.TryParse(this.tableNumTxt.Text.Trim(),out numTable);
            
            if(!numOk)
            {
                MessageBox.Show("num table is not a number!");
                return;
            }

            myMapping.setNumTable(numTable);

            myMapping.fillProperties();

            myMapping.Focus();
            myMapping.ShowDialog();

            updateRowNumber();

            return;
        }

        private void similarBtn_Click(object sender, EventArgs e)
        {
            int tableNum = getTableNum();
            if (tableNum == -1) return;            
            
            OPgroupSimilar grpSimilar = new OPgroupSimilar();

            DataColumnCollection cols;
            cols = ds.Tables[tableNum].Columns;
            grpSimilar.SetSourceColumns(cols);

            grpSimilar.ShowDialog(this);

            if (!grpSimilar.okPressed) return;

            //Sort data
            string tmpSort = "";
            ArrayList keys = new ArrayList(4);
            ArrayList keysCmp = new ArrayList();
            string keyTol = "";

            keys.Add(grpSimilar.key1Str);
            keys.Add(grpSimilar.key2Str);
            keys.Add(grpSimilar.key3Str);
            keys.Add(grpSimilar.key4Str);

            for (int i = 0; i < keys.Count; i++)
            {
                string key = (string)keys[i];
                if (key == null) key = ""; 
                if (grpSimilar.simKey != i + 1 && key!="")
                {
                    keysCmp.Add(keys[i]);
                    if (tmpSort == "")
                    {
                        tmpSort += (string)keys[i];
                    }
                    else { tmpSort += "," + (string)keys[i]; }
                }
            }

            //we place at the last sorting position the value for tolerance
            if (grpSimilar.simKey != 0)
            {
                keyTol =(string)keys[grpSimilar.simKey-1];

                if (tmpSort == "")
                {
                    tmpSort += (string)keys[grpSimilar.simKey-1];
                }
                else { tmpSort += "," + (string)keys[grpSimilar.simKey - 1]; }
 
            }

            DataView dv = new DataView(ds.Tables[tableNum]);
            try
            {
                dv.Sort = tmpSort;
                dv.RowFilter = this.txtFilter.Text.Trim();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "error when filtering & sorting out the data");
                return;
            }

            int groupingIndex = 0;
            string[] currGrpProps= new string[keysCmp.Count];


            for (int i = 0; i < currGrpProps.Length; i++)
            {
                currGrpProps[i] = "";
            }

            bool newGroup = true;
            double groupTolValue = double.MaxValue;

            for (int k = 0; k < dv.Count; k++)
            {
                newGroup = false;
                //Check "usual" comparations
                for(int i=0;i<keysCmp.Count;i++)
                {
                    string currColumn =(string)keysCmp[i];
                    if (dv[k][currColumn].ToString() != currGrpProps[i]) newGroup = true;                     
                }

                //Check tolerance
                if (grpSimilar.simKey != 0)
                {
                    double currValKey =0;
                    bool convOk = double.TryParse(dv[k][keyTol].ToString(), out currValKey);
                    if (Math.Abs(groupTolValue - currValKey) > grpSimilar.tolerance) newGroup = true;
                }

                if (newGroup)
                {
                    groupingIndex++;
                    for (int i = 0; i < keysCmp.Count; i++)
                    {
                        string currColumn = (string)keysCmp[i];
                        currGrpProps[i] = dv[k][currColumn].ToString();
                    }
                    if (grpSimilar.simKey != 0)
                    {
                        groupTolValue =0;
                        bool convOk = double.TryParse(dv[k][keyTol].ToString(), out groupTolValue);
 
                    }
                }

                dv[k][grpSimilar.copyGroupStr] = groupingIndex;
            }

            updateRowNumber();

        }

        // the following are just to keep the row number updated
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateRowNumber();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            updateRowNumber();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            updateRowNumber();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            updateRowNumber();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateRowNumber();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateRowNumber();
        }

    }
}
