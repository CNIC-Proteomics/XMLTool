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
    public partial class OPmapping_conf : Form
    {

        private DataColumn origCol;
        private DataColumn targetCol;
        public bool ok;

        public OPmapping_conf()
        {
            ok = false;

            InitializeComponent();

            this.lblParseActions.Visible = false;

        }

        public void setData(DataColumn _origCol,DataColumn _targetCol)
        {
            origCol = _origCol;
            targetCol = _targetCol;

            this.lblorig.Text = _origCol.ColumnName;
            this.lblTypeOrig.Text = _origCol.DataType.ToString();
            this.lbltarget.Text = _targetCol.ColumnName;
            this.lblTypeTarget.Text = _targetCol.DataType.ToString();



            if (_origCol.DataType != _targetCol.DataType)
            {
                if (_targetCol.DataType.ToString().Contains("String"))
                {
                    this.lblParseActions.Text = "Original variable will converted to a string";
                }
                else
                {
                    this.lblParseActions.Text = "Original variable will be parsed to " + _targetCol.DataType.ToString();
                }

                this.lblParseActions.Visible = true;
    
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Dispose();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Dispose();
        }              


    }
}
