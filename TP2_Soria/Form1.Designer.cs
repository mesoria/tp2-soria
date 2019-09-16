namespace TP2_Soria
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnArticulo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblTitleFilter = new System.Windows.Forms.Label();
            this.lblSelectFilter = new System.Windows.Forms.Label();
            this.cboColumna = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cboxTxt = new System.Windows.Forms.RadioButton();
            this.cboxObj = new System.Windows.Forms.RadioButton();
            this.cboObj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObj = new System.Windows.Forms.Label();
            this.cboObj2 = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArticulo,
            this.btnModificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnArticulo
            // 
            this.btnArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulo.Image")));
            this.btnArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(29, 24);
            this.btnArticulo.Text = "Agregar Articulo";
            this.btnArticulo.Click += new System.EventHandler(this.BtnArticulo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(29, 24);
            this.btnModificar.Text = "Modificar Artículo";
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 188);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(756, 250);
            this.dgvArticulos.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(830, 134);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(121, 35);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // lblTitleFilter
            // 
            this.lblTitleFilter.AutoSize = true;
            this.lblTitleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFilter.Location = new System.Drawing.Point(23, 47);
            this.lblTitleFilter.Name = "lblTitleFilter";
            this.lblTitleFilter.Size = new System.Drawing.Size(143, 25);
            this.lblTitleFilter.TabIndex = 5;
            this.lblTitleFilter.Text = "Agrega un filtro";
            // 
            // lblSelectFilter
            // 
            this.lblSelectFilter.AutoSize = true;
            this.lblSelectFilter.Location = new System.Drawing.Point(93, 95);
            this.lblSelectFilter.Name = "lblSelectFilter";
            this.lblSelectFilter.Size = new System.Drawing.Size(73, 17);
            this.lblSelectFilter.TabIndex = 6;
            this.lblSelectFilter.Text = "Filtrar por:";
            // 
            // cboColumna
            // 
            this.cboColumna.FormattingEnabled = true;
            this.cboColumna.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Descripción"});
            this.cboColumna.Location = new System.Drawing.Point(200, 92);
            this.cboColumna.Name = "cboColumna";
            this.cboColumna.Size = new System.Drawing.Size(210, 24);
            this.cboColumna.TabIndex = 7;
            this.cboColumna.SelectedIndexChanged += new System.EventHandler(this.CboColumna_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(430, 95);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(68, 17);
            this.lblFilter.TabIndex = 8;
            this.lblFilter.Text = "Contiene:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(542, 92);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(226, 22);
            this.txtFind.TabIndex = 9;
            this.txtFind.TextChanged += new System.EventHandler(this.TxtFind_TextChanged);
            // 
            // cboxTxt
            // 
            this.cboxTxt.AutoSize = true;
            this.cboxTxt.Location = new System.Drawing.Point(28, 95);
            this.cboxTxt.Name = "cboxTxt";
            this.cboxTxt.Size = new System.Drawing.Size(17, 16);
            this.cboxTxt.TabIndex = 10;
            this.cboxTxt.TabStop = true;
            this.cboxTxt.UseVisualStyleBackColor = true;
            // 
            // cboxObj
            // 
            this.cboxObj.AutoSize = true;
            this.cboxObj.Location = new System.Drawing.Point(28, 143);
            this.cboxObj.Name = "cboxObj";
            this.cboxObj.Size = new System.Drawing.Size(17, 16);
            this.cboxObj.TabIndex = 13;
            this.cboxObj.TabStop = true;
            this.cboxObj.UseVisualStyleBackColor = true;
            // 
            // cboObj
            // 
            this.cboObj.FormattingEnabled = true;
            this.cboObj.Items.AddRange(new object[] {
            "Marca",
            "Categoría"});
            this.cboObj.Location = new System.Drawing.Point(200, 140);
            this.cboObj.Name = "cboObj";
            this.cboObj.Size = new System.Drawing.Size(210, 24);
            this.cboObj.TabIndex = 12;
            this.cboObj.SelectedIndexChanged += new System.EventHandler(this.CboObj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtrar por:";
            // 
            // lblObj
            // 
            this.lblObj.AutoSize = true;
            this.lblObj.Location = new System.Drawing.Point(433, 143);
            this.lblObj.Name = "lblObj";
            this.lblObj.Size = new System.Drawing.Size(54, 17);
            this.lblObj.TabIndex = 14;
            this.lblObj.Text = "Igual a:";
            // 
            // cboObj2
            // 
            this.cboObj2.FormattingEnabled = true;
            this.cboObj2.Location = new System.Drawing.Point(542, 140);
            this.cboObj2.Name = "cboObj2";
            this.cboObj2.Size = new System.Drawing.Size(226, 24);
            this.cboObj2.TabIndex = 15;
            this.cboObj2.SelectedIndexChanged += new System.EventHandler(this.CboObj2_SelectedIndexChanged);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(830, 86);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(121, 35);
            this.btnMostrarTodo.TabIndex = 16;
            this.btnMostrarTodo.Text = "Mustrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(830, 403);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 35);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.cboObj2);
            this.Controls.Add(this.lblObj);
            this.Controls.Add(this.cboxObj);
            this.Controls.Add(this.cboObj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxTxt);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboColumna);
            this.Controls.Add(this.lblSelectFilter);
            this.Controls.Add(this.lblTitleFilter);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Catalogo de Articulos";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnArticulo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblTitleFilter;
        private System.Windows.Forms.Label lblSelectFilter;
        private System.Windows.Forms.ComboBox cboColumna;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton cboxTxt;
        private System.Windows.Forms.RadioButton cboxObj;
        private System.Windows.Forms.ComboBox cboObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.ComboBox cboObj2;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnEliminar;
    }
}

