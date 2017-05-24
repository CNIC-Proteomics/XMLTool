namespace XMLtool
{
    partial class OPmapping_conf
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblorig = new System.Windows.Forms.Label();
            this.lbltarget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTypeOrig = new System.Windows.Forms.Label();
            this.lblTypeTarget = new System.Windows.Forms.Label();
            this.lblParseActions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(117, 142);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(49, 24);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "map";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblorig
            // 
            this.lblorig.AutoSize = true;
            this.lblorig.Location = new System.Drawing.Point(114, 42);
            this.lblorig.Name = "lblorig";
            this.lblorig.Size = new System.Drawing.Size(62, 13);
            this.lblorig.TabIndex = 2;
            this.lblorig.Text = "origVariable";
            // 
            // lbltarget
            // 
            this.lbltarget.AutoSize = true;
            this.lbltarget.Location = new System.Drawing.Point(114, 86);
            this.lbltarget.Name = "lbltarget";
            this.lbltarget.Size = new System.Drawing.Size(72, 13);
            this.lbltarget.TabIndex = 3;
            this.lbltarget.Text = "targetVariable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Do you want to map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "to the variable ?";
            // 
            // lblTypeOrig
            // 
            this.lblTypeOrig.AutoSize = true;
            this.lblTypeOrig.Location = new System.Drawing.Point(213, 42);
            this.lblTypeOrig.Name = "lblTypeOrig";
            this.lblTypeOrig.Size = new System.Drawing.Size(54, 13);
            this.lblTypeOrig.TabIndex = 6;
            this.lblTypeOrig.Text = "(var type )";
            // 
            // lblTypeTarget
            // 
            this.lblTypeTarget.AutoSize = true;
            this.lblTypeTarget.Location = new System.Drawing.Point(213, 86);
            this.lblTypeTarget.Name = "lblTypeTarget";
            this.lblTypeTarget.Size = new System.Drawing.Size(54, 13);
            this.lblTypeTarget.TabIndex = 7;
            this.lblTypeTarget.Text = "(var type )";
            // 
            // lblParseActions
            // 
            this.lblParseActions.AutoSize = true;
            this.lblParseActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParseActions.ForeColor = System.Drawing.Color.Red;
            this.lblParseActions.Location = new System.Drawing.Point(12, 122);
            this.lblParseActions.Name = "lblParseActions";
            this.lblParseActions.Size = new System.Drawing.Size(83, 13);
            this.lblParseActions.TabIndex = 8;
            this.lblParseActions.Text = "parse actions";
            // 
            // OPmapping_conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 192);
            this.Controls.Add(this.lblParseActions);
            this.Controls.Add(this.lblTypeTarget);
            this.Controls.Add(this.lblTypeOrig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltarget);
            this.Controls.Add(this.lblorig);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "OPmapping_conf";
            this.Text = "Confirm mapping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblorig;
        private System.Windows.Forms.Label lbltarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTypeOrig;
        private System.Windows.Forms.Label lblTypeTarget;
        private System.Windows.Forms.Label lblParseActions;
    }
}