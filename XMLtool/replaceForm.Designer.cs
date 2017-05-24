namespace XMLtool
{
    partial class replaceForm
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
            this.listFileTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.refCol = new System.Windows.Forms.ComboBox();
            this.targetCol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listFileTxt
            // 
            this.listFileTxt.AllowDrop = true;
            this.listFileTxt.Location = new System.Drawing.Point(103, 26);
            this.listFileTxt.Name = "listFileTxt";
            this.listFileTxt.Size = new System.Drawing.Size(317, 20);
            this.listFileTxt.TabIndex = 0;
            this.listFileTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.listFileTxt_DragDrop);
            this.listFileTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.listFileTxt_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "changes list file :";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(433, 26);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(43, 20);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // refCol
            // 
            this.refCol.FormattingEnabled = true;
            this.refCol.Location = new System.Drawing.Point(62, 281);
            this.refCol.Name = "refCol";
            this.refCol.Size = new System.Drawing.Size(176, 21);
            this.refCol.TabIndex = 3;
            this.refCol.TextChanged += new System.EventHandler(this.refCol_TextChanged);
            // 
            // targetCol
            // 
            this.targetCol.FormattingEnabled = true;
            this.targetCol.Location = new System.Drawing.Point(244, 281);
            this.targetCol.Name = "targetCol";
            this.targetCol.Size = new System.Drawing.Size(176, 21);
            this.targetCol.TabIndex = 4;
            this.targetCol.TextChanged += new System.EventHandler(this.targetCol_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reference column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "target column";
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(144, 318);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(94, 28);
            this.changeBtn.TabIndex = 7;
            this.changeBtn.Text = "change values";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(244, 318);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 28);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 173);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(244, 65);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(176, 173);
            this.listBox2.TabIndex = 10;
            // 
            // replaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.targetCol);
            this.Controls.Add(this.refCol);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFileTxt);
            this.Name = "replaceForm";
            this.Text = "replace values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listFileTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ComboBox refCol;
        private System.Windows.Forms.ComboBox targetCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}