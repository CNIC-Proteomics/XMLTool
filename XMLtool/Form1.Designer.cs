namespace XMLtool
{
    partial class mainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xmlFiletxt = new System.Windows.Forms.TextBox();
            this.xmlSchematxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableNumTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtMergeXML = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.removeDuplBtn = new System.Windows.Forms.Button();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.functionsgrp = new System.Windows.Forms.GroupBox();
            this.similarBtn = new System.Windows.Forms.Button();
            this.mappingbtn = new System.Windows.Forms.Button();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.lblRowNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.functionsgrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // xmlFiletxt
            // 
            this.xmlFiletxt.AllowDrop = true;
            this.xmlFiletxt.Location = new System.Drawing.Point(239, 12);
            this.xmlFiletxt.Name = "xmlFiletxt";
            this.xmlFiletxt.Size = new System.Drawing.Size(442, 20);
            this.xmlFiletxt.TabIndex = 1;
            this.xmlFiletxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.xmlFiletxt_DragDrop);
            this.xmlFiletxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.xmlFiletxt_DragEnter);
            // 
            // xmlSchematxt
            // 
            this.xmlSchematxt.AllowDrop = true;
            this.xmlSchematxt.Location = new System.Drawing.Point(239, 38);
            this.xmlSchematxt.Name = "xmlSchematxt";
            this.xmlSchematxt.Size = new System.Drawing.Size(442, 20);
            this.xmlSchematxt.TabIndex = 2;
            this.xmlSchematxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.xmlSchematxt_DragDrop);
            this.xmlSchematxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.xmlSchematxt_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "XML file :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "XML schema :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "GO !!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "bind table # :";
            // 
            // tableNumTxt
            // 
            this.tableNumTxt.Location = new System.Drawing.Point(239, 61);
            this.tableNumTxt.Name = "tableNumTxt";
            this.tableNumTxt.Size = new System.Drawing.Size(32, 20);
            this.tableNumTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "table name :";
            // 
            // tableNameLbl
            // 
            this.tableNameLbl.AutoSize = true;
            this.tableNameLbl.Location = new System.Drawing.Point(373, 64);
            this.tableNameLbl.Name = "tableNameLbl";
            this.tableNameLbl.Size = new System.Drawing.Size(16, 13);
            this.tableNameLbl.TabIndex = 9;
            this.tableNameLbl.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filter :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(238, 122);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(391, 20);
            this.txtFilter.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "save filtered XML";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(635, 122);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(45, 20);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtMergeXML
            // 
            this.txtMergeXML.AllowDrop = true;
            this.txtMergeXML.Location = new System.Drawing.Point(23, 438);
            this.txtMergeXML.Name = "txtMergeXML";
            this.txtMergeXML.Size = new System.Drawing.Size(366, 20);
            this.txtMergeXML.TabIndex = 14;
            this.txtMergeXML.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtMergeXML_DragDrop);
            this.txtMergeXML.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtMergeXML_DragEnter);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(395, 437);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(113, 21);
            this.btnMerge.TabIndex = 15;
            this.btnMerge.Text = "merge with this XML";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(35, 24);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(147, 23);
            this.replaceBtn.TabIndex = 16;
            this.replaceBtn.Text = "replace values using a list";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // removeDuplBtn
            // 
            this.removeDuplBtn.Location = new System.Drawing.Point(35, 53);
            this.removeDuplBtn.Name = "removeDuplBtn";
            this.removeDuplBtn.Size = new System.Drawing.Size(147, 23);
            this.removeDuplBtn.TabIndex = 17;
            this.removeDuplBtn.Text = "remove duplicates";
            this.removeDuplBtn.UseVisualStyleBackColor = true;
            this.removeDuplBtn.Click += new System.EventHandler(this.removeDuplBtn_Click);
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(238, 96);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(391, 20);
            this.txtSort.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sort :";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(634, 95);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(45, 20);
            this.btnSort.TabIndex = 20;
            this.btnSort.Text = "sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // functionsgrp
            // 
            this.functionsgrp.Controls.Add(this.similarBtn);
            this.functionsgrp.Controls.Add(this.mappingbtn);
            this.functionsgrp.Controls.Add(this.replaceBtn);
            this.functionsgrp.Controls.Add(this.removeDuplBtn);
            this.functionsgrp.Location = new System.Drawing.Point(734, 12);
            this.functionsgrp.Name = "functionsgrp";
            this.functionsgrp.Size = new System.Drawing.Size(213, 137);
            this.functionsgrp.TabIndex = 21;
            this.functionsgrp.TabStop = false;
            this.functionsgrp.Text = "special functions";
            // 
            // similarBtn
            // 
            this.similarBtn.Location = new System.Drawing.Point(35, 81);
            this.similarBtn.Name = "similarBtn";
            this.similarBtn.Size = new System.Drawing.Size(147, 23);
            this.similarBtn.TabIndex = 19;
            this.similarBtn.Text = "group similar values";
            this.similarBtn.UseVisualStyleBackColor = true;
            this.similarBtn.Click += new System.EventHandler(this.similarBtn_Click);
            // 
            // mappingbtn
            // 
            this.mappingbtn.Location = new System.Drawing.Point(35, 107);
            this.mappingbtn.Name = "mappingbtn";
            this.mappingbtn.Size = new System.Drawing.Size(147, 23);
            this.mappingbtn.TabIndex = 18;
            this.mappingbtn.Text = "schemas mapping";
            this.mappingbtn.UseVisualStyleBackColor = true;
            this.mappingbtn.Click += new System.EventHandler(this.mappingbtn_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(20, 124);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(57, 13);
            this.lblRowCount.TabIndex = 22;
            this.lblRowCount.Text = "row count:";
            // 
            // lblRowNumber
            // 
            this.lblRowNumber.AutoSize = true;
            this.lblRowNumber.Location = new System.Drawing.Point(83, 124);
            this.lblRowNumber.Name = "lblRowNumber";
            this.lblRowNumber.Size = new System.Drawing.Size(16, 13);
            this.lblRowNumber.TabIndex = 23;
            this.lblRowNumber.Text = "---";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 481);
            this.Controls.Add(this.lblRowNumber);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.functionsgrp);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.txtMergeXML);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableNumTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xmlSchematxt);
            this.Controls.Add(this.xmlFiletxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mainForm";
            this.Text = "XMLtool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.functionsgrp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox xmlFiletxt;
        private System.Windows.Forms.TextBox xmlSchematxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tableNumTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tableNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtMergeXML;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button removeDuplBtn;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox functionsgrp;
        private System.Windows.Forms.Button mappingbtn;
        private System.Windows.Forms.Button similarBtn;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label lblRowNumber;
    }
}

