namespace XMLtool
{
    partial class OPmapping
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
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.origColumns = new System.Windows.Forms.ListBox();
            this.targetColumns = new System.Windows.Forms.ListBox();
            this.btnLoadTargetSchema = new System.Windows.Forms.Button();
            this.targetSchemaTxt = new System.Windows.Forms.TextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearMappings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(757, 28);
            this.toolBar1.TabIndex = 1;
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            // 
            // origColumns
            // 
            this.origColumns.FormattingEnabled = true;
            this.origColumns.Location = new System.Drawing.Point(27, 137);
            this.origColumns.Name = "origColumns";
            this.origColumns.Size = new System.Drawing.Size(293, 381);
            this.origColumns.TabIndex = 2;
            this.origColumns.MouseDown += new System.Windows.Forms.MouseEventHandler(this.origColumns_MouseDown);
            // 
            // targetColumns
            // 
            this.targetColumns.FormattingEnabled = true;
            this.targetColumns.Location = new System.Drawing.Point(443, 137);
            this.targetColumns.Name = "targetColumns";
            this.targetColumns.Size = new System.Drawing.Size(293, 381);
            this.targetColumns.TabIndex = 3;
            this.targetColumns.MouseDown += new System.Windows.Forms.MouseEventHandler(this.targetColumns_MouseDown);
            // 
            // btnLoadTargetSchema
            // 
            this.btnLoadTargetSchema.Location = new System.Drawing.Point(545, 24);
            this.btnLoadTargetSchema.Name = "btnLoadTargetSchema";
            this.btnLoadTargetSchema.Size = new System.Drawing.Size(106, 20);
            this.btnLoadTargetSchema.TabIndex = 22;
            this.btnLoadTargetSchema.Text = "load target schema";
            this.btnLoadTargetSchema.UseVisualStyleBackColor = true;
            this.btnLoadTargetSchema.Click += new System.EventHandler(this.btnLoadTargetSchema_Click);
            // 
            // targetSchemaTxt
            // 
            this.targetSchemaTxt.AllowDrop = true;
            this.targetSchemaTxt.Location = new System.Drawing.Point(27, 25);
            this.targetSchemaTxt.Name = "targetSchemaTxt";
            this.targetSchemaTxt.Size = new System.Drawing.Size(496, 20);
            this.targetSchemaTxt.TabIndex = 21;
            this.targetSchemaTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.targetSchemaTxt_DragDrop);
            this.targetSchemaTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.targetSchemaTxt_DragEnter);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(229, 544);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(164, 25);
            this.btnMap.TabIndex = 23;
            this.btnMap.Text = "map and create a new XML";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 544);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 25);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Not common variables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "For mapping, select a variable from the original schema, and after the variable o" +
                "f the target schema to be mapped.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Original schema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Target schema";
            // 
            // btnClearMappings
            // 
            this.btnClearMappings.Location = new System.Drawing.Point(645, 524);
            this.btnClearMappings.Name = "btnClearMappings";
            this.btnClearMappings.Size = new System.Drawing.Size(91, 23);
            this.btnClearMappings.TabIndex = 29;
            this.btnClearMappings.Text = "clear mappings";
            this.btnClearMappings.UseVisualStyleBackColor = true;
            this.btnClearMappings.Click += new System.EventHandler(this.btnClearMappings_Click);
            // 
            // OPmapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 589);
            this.Controls.Add(this.btnClearMappings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnLoadTargetSchema);
            this.Controls.Add(this.targetSchemaTxt);
            this.Controls.Add(this.targetColumns);
            this.Controls.Add(this.origColumns);
            this.Controls.Add(this.toolBar1);
            this.Name = "OPmapping";
            this.Text = "Mapping from one schema to another one";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OPmapping_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ToolBarButton toolBarButton4;
        private System.Windows.Forms.ListBox origColumns;
        private System.Windows.Forms.ListBox targetColumns;
        private System.Windows.Forms.Button btnLoadTargetSchema;
        private System.Windows.Forms.TextBox targetSchemaTxt;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearMappings;
    }
}