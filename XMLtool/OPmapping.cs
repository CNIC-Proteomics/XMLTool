using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;
using System.IO;

namespace XMLtool
{
    public partial class OPmapping : Form
    {
        //Original schema
        private string schema1;
        private string xmlFile1;
        private int numTable;
        private DataSet ds1;
        private DataView dv1;

        //target schema
        private string schema2;
        private string xmlFile2;
        private DataSet ds2;
        private DataView dv2;

        //mapping variables
        private ArrayList mapVariables_o=new ArrayList();
        private ArrayList mapVariables_t=new ArrayList();
        private ArrayList commonVariables=new ArrayList();

        //Drawing properties
        private Point lineStart;
        private Point lineEnd;
        private GraphicsPath line;
        private ArrayList linesToDraw = new ArrayList();
        private ArrayList tableConstraints = new ArrayList();

        public OPmapping()
        {
            schema1 = "";
            
            InitializeComponent();

        }

        public void setOriginalSchema(string _schema1)
        {
            schema1 = _schema1;             
        }

        public void setOriginalXML(string _xmlFile1)
        {
            
            if(!File.Exists(_xmlFile1))
            {
                MessageBox.Show("You have not entered any valid XML original file!", "Error");
                return;
            }

            xmlFile1 = _xmlFile1;

            string path = Path.GetDirectoryName(xmlFile1);
            string f = Path.GetFileName(xmlFile1);
            string ext = Path.GetExtension(xmlFile1);

            xmlFile2 = path+"\\"+ f + "_mapped" + ext;


        }

        public void setNumTable(int _numTable)
        {
            numTable = _numTable; 
        }

        public void fillProperties()
        {
            
            ds1 = new DataSet();
            try
            {
                ds1.ReadXmlSchema(schema1);
                ds1.ReadXml(xmlFile1);
                dv1 = new DataView(ds1.Tables[numTable]);
            
            }
            catch (System.Exception ex) 
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
                return;
            }

            foreach(DataColumn dc in dv1.Table.Columns)
            {
                origColumns.Items.Add(dc.ColumnName);
                
            }
         
        }

        private void OPmapping_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphicsPath path in linesToDraw)
            {
                DrawLine(e.Graphics, path);
            }
        }

        private void DrawLine(Graphics g, GraphicsPath lineToDraw)
        {

            Pen myPen = new Pen(Color.Green, 1);


            AdjustableArrowCap myArrow = new AdjustableArrowCap(4, 4, true);

            myPen.CustomEndCap = myArrow;

            g.DrawPath(myPen, lineToDraw);

            myPen.Dispose();

            myArrow.Dispose();

        }

        private void btnLoadTargetSchema_Click(object sender, EventArgs e)
        {
            ds2 = new DataSet();
            schema2 = this.targetSchemaTxt.Text.Trim();

            //Clear the previous mappings
            clearMappings();

            //Clean textboxes
            origColumns.Items.Clear();
            targetColumns.Items.Clear();
            
            
            //Reset columns of the original schema
            foreach (DataColumn dc in dv1.Table.Columns)
            {
                origColumns.Items.Add(dc.ColumnName);

            }


            try
            {
                ds2.ReadXmlSchema(schema2);
                //ds1.ReadXml(xmlFile1);
                dv2 = new DataView(ds2.Tables[numTable]);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            targetColumns.Items.Clear();

            foreach (DataColumn dc in dv2.Table.Columns)
            {
                if (origColumns.Items.Contains(dc.ColumnName))
                {
                    commonVariables.Add(dc);
                    origColumns.Items.Remove(dc.ColumnName);
                }
                else
                {
                    targetColumns.Items.Add(dc.ColumnName);
                }
            }

        }

        private void clearMappings()
        {
            //Reset mapping variables
            mapVariables_o.Clear();
            mapVariables_t.Clear();
            commonVariables.Clear();

            //Clean lines
            linesToDraw.Clear();
            tableConstraints.Clear();
            this.Invalidate();
        }

        private void origColumns_MouseDown(object sender, MouseEventArgs e)
        {
            lineStart.X = origColumns.Location.X + origColumns.Size.Width ;
            lineStart.Y = e.Location.Y+origColumns.Location.Y;
                        
        }

        private void targetColumns_MouseDown(object sender, MouseEventArgs e)
        {
            lineEnd.X = targetColumns.Location.X;
            lineEnd.Y = e.Location.Y+targetColumns.Location.Y;


            OPmapping_conf confirm = new OPmapping_conf();

            DataColumn origCol = dv1.Table.Columns[origColumns.SelectedItem.ToString()];
            DataColumn targetCol = dv2.Table.Columns[targetColumns.SelectedItem.ToString()];
            

            if(mapVariables_t.Contains(targetCol))
            {
                MessageBox.Show("This target variable was already mapped!","Error: can't be mapped!");
                return;
            }

            confirm.setData(origCol,targetCol);

            confirm.ShowDialog();

            if (!confirm.ok) return;

            mapVariables_o.Add(origCol);
            mapVariables_t.Add(targetCol);

            //If lineStart coord. are set, create the line

            if (lineStart.X != 0 && lineEnd.Y != 0)
            {
                line = new GraphicsPath();
                
                line.AddLine(lineStart, lineEnd);
                linesToDraw.Add(line);
                Invalidate();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {

            //Copy all the tables, but the treated one
            try 
            {
                ds2.EnforceConstraints =false;
                        
                for (int t = 0; t < ds1.Tables.Count; t++)
                {
                    if (t != numTable)
                    {
                        ds2.Tables[t].Clear();

                       
                        //foreach (Constraint c in ds2.Tables[t].Constraints)
                        //{
                        //    if(!c.ExtendedProperties.Keys)
                        //    {
                        //        tableConstraints.Add(ds2.Tables[t].Constraints);
                        //        ds2.Tables[t].Constraints.Remove(c);
                        //    }
                        //}

                        for (int row = 0; row < ds1.Tables[t].Rows.Count; row++)
                        {
                            DataRow dr=ds2.Tables[t].NewRow();

                            for(int c=0;c<ds1.Tables[t].Columns.Count;c++)
                            {
                                dr[c] = ds1.Tables[t].Rows[row][c];
                            }

                            ds2.Tables[t].Rows.Add(dr);
                        }

                    }
                }


            }
            catch(Exception ex) 
            {
                MessageBox.Show("Problem when treating to copy tables. " +ex.Message,"Error");
                return;
            }


            try
            {
                for (int row = 0; row < dv1.Table.Rows.Count; row++)
                {
                    //Add a new row to the target dataview
                    DataRow dr = dv2.Table.NewRow();
                    
                    //Process the common variables
                    foreach (DataColumn dc in commonVariables)
                    {
                        dr[dc.ColumnName] = dv1.Table.Rows[row][dc.ColumnName];
                    }


                    //Variables to be mapped
                    int counter = 0;
                    for (counter = 0; counter < mapVariables_o.Count; counter++)
                    {
                        DataColumn dc_o = (DataColumn)mapVariables_o[counter];
                        DataColumn dc_t = (DataColumn)mapVariables_t[counter];

                        //if the DataType is the same for both variables --> copy directly
                        if (dc_o.DataType == dc_t.DataType)
                        {
                            dr[dc_t.ColumnName] = dv1.Table.Rows[row][dc_o.ColumnName];
                        }

                        //if the DataType is NOT the same for both variables --> try to parse
                        if (dc_o.DataType != dc_t.DataType)
                        {

                            //Parse possibilities
                            if (dc_t.DataType.ToString().ToUpper().Contains("STRING")) //String --> transformed directly to a string
                            {
                                dr[dc_t.ColumnName] = dv1.Table.Rows[row][dc_o.ColumnName].ToString();

                            }
                            if (dc_t.DataType.ToString().ToUpper().Contains("DOUBLE")) //Double
                            {
                                double mappedVal = 0;
                                bool mapOk = double.TryParse(dv1.Table.Rows[row][dc_o.ColumnName].ToString(), out mappedVal);
                                if (!mapOk)
                                {
                                    mappedVal = double.NaN;
                                }
                                dr[dc_t.ColumnName] = mappedVal;
                            }

                            if (dc_t.DataType.ToString().ToUpper().Contains("FLOAT")) //Float
                            {
                                float mappedVal = 0;
                                bool mapOk = float.TryParse(dv1.Table.Rows[row][dc_o.ColumnName].ToString(), out mappedVal);
                                if (!mapOk)
                                {
                                    mappedVal = float.NaN;
                                }
                                dr[dc_t.ColumnName] = mappedVal;
                            }

                            if (dc_t.DataType.ToString().ToUpper().Contains("INT")) //Integer
                            {
                                int mappedVal = 0;
                                bool mapOk = int.TryParse(dv1.Table.Rows[row][dc_o.ColumnName].ToString(), out mappedVal);
                                if (!mapOk)
                                {
                                    mappedVal = int.MinValue;
                                }
                                dr[dc_t.ColumnName] = mappedVal;
                            }
                        }

                    }


                    //Add the processed new row
                    dv2.Table.Rows.Add(dr);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem when mapping! " + ex.Message,"Error");
                return;
            }


            //Save the new XML
            try
            {
                ds2.WriteXml(xmlFile2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save the new file!" + ex.Message, "Error");
                return;
            }

            MessageBox.Show("Schema has been mapped! A new XML file has been created with the name: " + xmlFile2);
           
            this.Dispose();
        }

        private void targetSchemaTxt_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (IsXsdFile(file[0]))
            {
                targetSchemaTxt.Text = file[0].Trim();
                this.btnLoadTargetSchema.PerformClick();
            }

        }

        private void targetSchemaTxt_DragEnter(object sender, DragEventArgs e)
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

        private static bool IsXsdFile(string f)
        {
            return f != null &&
                f.EndsWith(".xsd", StringComparison.OrdinalIgnoreCase);
        }

        private void btnClearMappings_Click(object sender, EventArgs e)
        {
            clearMappings();
        }
                       

    }
}
