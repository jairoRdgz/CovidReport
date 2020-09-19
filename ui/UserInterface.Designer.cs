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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.barrChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarInfectados = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.fromtxt = new System.Windows.Forms.TextBox();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.categorico = new System.Windows.Forms.ComboBox();
            this.campos = new System.Windows.Forms.ComboBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.cadena = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.barrChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.gMap.Location = new System.Drawing.Point(6, 28);
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
            // barrChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barrChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barrChart.Legends.Add(legend1);
            this.barrChart.Location = new System.Drawing.Point(6, 6);
            this.barrChart.Name = "barrChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Recuperados";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Casa";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Hospital";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Fallecido";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "UCI";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "N/A";
            this.barrChart.Series.Add(series1);
            this.barrChart.Series.Add(series2);
            this.barrChart.Series.Add(series3);
            this.barrChart.Series.Add(series4);
            this.barrChart.Series.Add(series5);
            this.barrChart.Series.Add(series6);
            this.barrChart.Size = new System.Drawing.Size(1273, 490);
            this.barrChart.TabIndex = 13;
            this.barrChart.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1293, 528);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.agregarInfectados);
            this.tabPage1.Controls.Add(this.path);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.to);
            this.tabPage1.Controls.Add(this.from);
            this.tabPage1.Controls.Add(this.fromtxt);
            this.tabPage1.Controls.Add(this.toTxt);
            this.tabPage1.Controls.Add(this.categorico);
            this.tabPage1.Controls.Add(this.campos);
            this.tabPage1.Controls.Add(this.tablaDatos);
            this.tabPage1.Controls.Add(this.gMap);
            this.tabPage1.Controls.Add(this.cadena);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1152, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(947, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Flitrar:";
            // 
            // agregarInfectados
            // 
            this.agregarInfectados.Location = new System.Drawing.Point(869, 48);
            this.agregarInfectados.Name = "agregarInfectados";
            this.agregarInfectados.Size = new System.Drawing.Size(74, 23);
            this.agregarInfectados.TabIndex = 23;
            this.agregarInfectados.Text = "Buscar";
            this.agregarInfectados.UseVisualStyleBackColor = true;
            this.agregarInfectados.Click += new System.EventHandler(this.agregarInfectados_Click_1);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(702, 24);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 13);
            this.path.TabIndex = 22;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(584, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 23);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Cargar Datos";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(742, 52);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(23, 13);
            this.to.TabIndex = 20;
            this.to.Text = "To:";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(588, 52);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(33, 13);
            this.from.TabIndex = 19;
            this.from.Text = "From:";
            // 
            // fromtxt
            // 
            this.fromtxt.Location = new System.Drawing.Point(624, 49);
            this.fromtxt.Name = "fromtxt";
            this.fromtxt.Size = new System.Drawing.Size(63, 20);
            this.fromtxt.TabIndex = 18;
            // 
            // toTxt
            // 
            this.toTxt.Location = new System.Drawing.Point(771, 49);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(63, 20);
            this.toTxt.TabIndex = 17;
            // 
            // categorico
            // 
            this.categorico.FormattingEnabled = true;
            this.categorico.Location = new System.Drawing.Point(593, 50);
            this.categorico.Name = "categorico";
            this.categorico.Size = new System.Drawing.Size(246, 21);
            this.categorico.TabIndex = 15;
            this.categorico.SelectedIndexChanged += new System.EventHandler(this.categorico_SelectedIndexChanged_1);
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
            this.campos.Location = new System.Drawing.Point(988, 49);
            this.campos.Name = "campos";
            this.campos.Size = new System.Drawing.Size(137, 21);
            this.campos.TabIndex = 14;
            this.campos.SelectedIndexChanged += new System.EventHandler(this.campos_SelectedIndexChanged_1);
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Location = new System.Drawing.Point(581, 77);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(544, 368);
            this.tablaDatos.TabIndex = 13;
            // 
            // cadena
            // 
            this.cadena.Location = new System.Drawing.Point(593, 50);
            this.cadena.Name = "cadena";
            this.cadena.Size = new System.Drawing.Size(246, 20);
            this.cadena.TabIndex = 16;
            this.cadena.TextChanged += new System.EventHandler(this.cadena_TextChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.barrChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1285, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Charts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 564);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barrChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.DataVisualization.Charting.Chart barrChart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarInfectados;
        private System.Windows.Forms.TextBox cadena;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox fromtxt;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.ComboBox categorico;
        private System.Windows.Forms.ComboBox campos;
        private System.Windows.Forms.DataGridView tablaDatos;
    }
}

