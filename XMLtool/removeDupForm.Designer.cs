namespace XMLtool
{
    partial class removeDupForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.key1 = new System.Windows.Forms.ComboBox();
            this.key2 = new System.Windows.Forms.ComboBox();
            this.key3 = new System.Windows.Forms.ComboBox();
            this.key4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSortPref = new System.Windows.Forms.TextBox();
            this.cbxRedundantPeaks = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a key for finding duplicates:";
            // 
            // key1
            // 
            this.key1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key1.FormattingEnabled = true;
            this.key1.Location = new System.Drawing.Point(86, 82);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(142, 21);
            this.key1.TabIndex = 0;
            this.key1.TextChanged += new System.EventHandler(this.key1_TextChanged);
            // 
            // key2
            // 
            this.key2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key2.FormattingEnabled = true;
            this.key2.Location = new System.Drawing.Point(86, 109);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(142, 21);
            this.key2.TabIndex = 1;
            this.key2.TextChanged += new System.EventHandler(this.key2_TextChanged);
            // 
            // key3
            // 
            this.key3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key3.FormattingEnabled = true;
            this.key3.Location = new System.Drawing.Point(86, 136);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(142, 21);
            this.key3.TabIndex = 2;
            this.key3.TextChanged += new System.EventHandler(this.key3_TextChanged);
            // 
            // key4
            // 
            this.key4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key4.FormattingEnabled = true;
            this.key4.Location = new System.Drawing.Point(86, 163);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(142, 21);
            this.key4.TabIndex = 3;
            this.key4.TextChanged += new System.EventHandler(this.key4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "first key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "second key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "third key:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(139, 270);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 36);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "remove duplicates";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(220, 270);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 36);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "if duplicated, preserve the first one sorted by:";
            // 
            // txbSortPref
            // 
            this.txbSortPref.Location = new System.Drawing.Point(12, 225);
            this.txbSortPref.Name = "txbSortPref";
            this.txbSortPref.Size = new System.Drawing.Size(283, 20);
            this.txbSortPref.TabIndex = 4;
            // 
            // cbxRedundantPeaks
            // 
            this.cbxRedundantPeaks.AutoSize = true;
            this.cbxRedundantPeaks.Location = new System.Drawing.Point(15, 50);
            this.cbxRedundantPeaks.Name = "cbxRedundantPeaks";
            this.cbxRedundantPeaks.Size = new System.Drawing.Size(258, 17);
            this.cbxRedundantPeaks.TabIndex = 7;
            this.cbxRedundantPeaks.Text = "use default for redundant chromatographic peaks";
            this.cbxRedundantPeaks.UseVisualStyleBackColor = true;
            this.cbxRedundantPeaks.CheckedChanged += new System.EventHandler(this.cbxRedundantPeaks_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "third key:";
            // 
            // removeDupForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(309, 323);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxRedundantPeaks);
            this.Controls.Add(this.txbSortPref);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.label1);
            this.Name = "removeDupForm";
            this.Text = "remove duplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox key1;
        private System.Windows.Forms.ComboBox key2;
        private System.Windows.Forms.ComboBox key3;
        private System.Windows.Forms.ComboBox key4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSortPref;
        private System.Windows.Forms.CheckBox cbxRedundantPeaks;
        private System.Windows.Forms.Label label6;
    }
}