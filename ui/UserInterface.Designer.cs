namespace Taller_2
{
    partial class UserInterface
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
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.campos = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.agregarInfectados = new System.Windows.Forms.Button();
            this.categorico = new System.Windows.Forms.ComboBox();
            this.cadena = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(12, 12);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(560, 426);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Location = new System.Drawing.Point(578, 140);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(435, 298);
            this.tablaDatos.TabIndex = 1;
            // 
            // campos
            // 
            this.campos.FormattingEnabled = true;
            this.campos.Items.AddRange(new object[] {
            "",
            "Ciudad",
            "Departamento",
            "Atencion",
            "Edad",
            "Sexo"});
            this.campos.Location = new System.Drawing.Point(883, 113);
            this.campos.Name = "campos";
            this.campos.Size = new System.Drawing.Size(130, 21);
            this.campos.TabIndex = 2;
            this.campos.SelectedIndexChanged += new System.EventHandler(this.campos_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(596, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Cargar Archivos";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(699, 17);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 13);
            this.path.TabIndex = 10;
            // 
            // agregarInfectados
            // 
            this.agregarInfectados.Location = new System.Drawing.Point(608, 63);
            this.agregarInfectados.Name = "agregarInfectados";
            this.agregarInfectados.Size = new System.Drawing.Size(100, 23);
            this.agregarInfectados.TabIndex = 11;
            this.agregarInfectados.Text = "Ubicar Infectados";
            this.agregarInfectados.UseVisualStyleBackColor = true;
            this.agregarInfectados.Click += new System.EventHandler(this.agregarInfectados_Click);
            // 
            // categorico
            // 
            this.categorico.FormattingEnabled = true;
            this.categorico.Location = new System.Drawing.Point(578, 113);
            this.categorico.Name = "categorico";
            this.categorico.Size = new System.Drawing.Size(272, 21);
            this.categorico.TabIndex = 3;
            this.categorico.SelectedIndexChanged += new System.EventHandler(this.categorico_SelectedIndexChanged);
            // 
            // cadena
            // 
            this.cadena.Location = new System.Drawing.Point(578, 113);
            this.cadena.Name = "cadena";
            this.cadena.Size = new System.Drawing.Size(272, 20);
            this.cadena.TabIndex = 4;
            this.cadena.Visible = false;
            this.cadena.TextChanged += new System.EventHandler(this.cadena_TextChanged);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(885, 15);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(23, 13);
            this.to.TabIndex = 8;
            this.to.Text = "To:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(900, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 5;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(732, 15);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(33, 13);
            this.from.TabIndex = 7;
            this.from.Text = "From:";
            this.from.Click += new System.EventHandler(this.from_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(770, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Location = new System.Drawing.Point(900, 62);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(89, 24);
            this.buttonFiltro.TabIndex = 12;
            this.buttonFiltro.Text = "Filtrar";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            this.buttonFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.agregarInfectados);
            this.Controls.Add(this.cadena);
            this.Controls.Add(this.path);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.categorico);
            this.Controls.Add(this.campos);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.gMap);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.ComboBox campos;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button agregarInfectados;
        private System.Windows.Forms.ComboBox categorico;
        private System.Windows.Forms.TextBox cadena;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonFiltro;
    }
}

