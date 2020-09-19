using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Taller_2.model;

namespace Taller_2
{
    public partial class UserInterface : Form
    {
        DatoList list = new DatoList();
        //GMarkerGoogle marker;
        //GMapOverlay markerOverlay;
        DataTable table;
        bool chooseSexo = false;
        bool ciudadChoosen = false;
        GMapOverlay markers = new GMapOverlay("markers");

        public UserInterface()
        {
            InitializeComponent();
            initializeTable();
            hideElements();
        }

        private void hideElements()
        {
            categorico.Hide();
            cadena.Hide();
            from.Hide();
            fromtxt.Hide();
            to.Hide();
            toTxt.Hide();
            agregarInfectados.Hide();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //
                path.Text = openFileDialog1.FileName;

                loadData(openFileDialog1.FileName);
            }
            agregarRegistrosAlGmap();
        }

        private void agregarRegistrosAlGmap()
        {
            List<string> lista = list.getCiudades();

            foreach (string f in lista)
            {
                GeoCoderStatusCode statusCode;
                PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(f, out statusCode);

                if (pointLatLng1 != null)
                {
                    GMapMarker marker00 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker00.ToolTipText = f + "\n" + pointLatLng1.Value.Lat + "\n" + pointLatLng1.Value.Lng; // Esta linea es solo apariencia
                    markers.Markers.Add(marker00);
                }
            }
        }

        public void loadData(string a)
        {
            String[] lineas = File.ReadAllLines(a);

            for (int i = 1; i < lineas.Length; i++)
            {
                String[] valores = lineas[i].Split(',');

                list.addDato(new Dato(valores[3], valores[4], valores[5], valores[6], valores[7]));
            }
            fill();
            showBarrChartData();
            //showFullBarchartData();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(4.570868, -74.297333);
            gMap.MinZoom = 2;
            gMap.MaxZoom = 24;
            gMap.Zoom = 6;
            gMap.AutoScroll = true;
        }

        public void initializeTable()
        {
            table = new DataTable();
            table.Columns.Add("CIUDAD");
            table.Columns.Add("DEPARTAMENTO");
            table.Columns.Add("ATENCION");
            table.Columns.Add("EDAD");
            table.Columns.Add("SEXO");
            tablaDatos.DataSource = table;
        }

        public void fill()
        {
            foreach (var item in list.getDatos())
            {
                DataRow row = table.NewRow();
                row[0] = item.getCiudad();
                row[1] = item.getDepartamento();
                row[2] = item.getAtencion();
                row[3] = item.getEdad();
                row[4] = item.getSexo();

                table.Rows.Add(row);
            }
            list.setCiudades();
            list.setDepartments();
        }

        private void fillAtencion()
        {
            categorico.Items.Add("Recuperado");
            categorico.Items.Add("Casa");
            categorico.Items.Add("Hospital");
            categorico.Items.Add("Fallecido");
            categorico.Items.Add("Hospital UCI");
            categorico.Items.Add("N/A");
        }

        private void fillSexo()
        {
            categorico.Items.Add("M");
            categorico.Items.Add("F");
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMap.Overlays.Add(markers);
        }

        private void showBarrChartData()
        {
            list.setDepartments();
            List<int> yValues = list.getDepartamentValues();
            List<string> xValues = list.getDepartamentos();
            for (int i = 0; i < xValues.Count; i++)
            {
                barrChart.Series["Recuperados"].Points.AddXY(xValues[i],yValues[i]);
            }
        }

        private void showFullBarchartData()
        {
            List<Dato> todo = list.getDatos();
            List<String> department = list.getDepartamentos();

            for (int i = 0; i < department.Count; i++)
            {
                int recuperado = 0;
                int casa = 0;
                int hospital = 0;
                int fallecido = 0;
                int uci = 0;
                int na = 0;

                for (int j = 0; j < todo.Count; j++)
                {
                    switch (todo[i].getAtencion())
                    {
                        case "Recuperado":
                            recuperado += 1;
                            break;
                        case "Casa":
                            casa += 1;
                            break;
                        case "Hospital":
                            hospital += 1;
                            break;
                        case "Fallecido":
                            fallecido += 1;
                            break;
                        case "Hospital UCI":
                            uci += 1;
                            break;
                        case "N/A":
                            na += 1;
                            break;
                    }
                }
                Console.WriteLine(department[i] + "   " +recuperado);
                Console.WriteLine(department[i] + "   " + casa);
                Console.WriteLine(department[i] + "   " + hospital);
                Console.WriteLine(department[i] + "   " + fallecido);
                Console.WriteLine(department[i] + "   " + uci);
                Console.WriteLine(department[i] + "   " + na);

                barrChart.Series["Recuperados"].Points.AddXY(department[i], recuperado);
                barrChart.Series["Casa"].Points.AddXY(department[i], casa);
                barrChart.Series["Hospital"].Points.AddXY(department[i], hospital);
                barrChart.Series["Fallecido"].Points.AddXY(department[i], fallecido);
                barrChart.Series["UCI"].Points.AddXY(department[i], uci);
                barrChart.Series["N/A"].Points.AddXY(department[i], na);
            }
        }

        private void campos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cases = campos.Text;

            switch (cases)
            {
                case "Ciudad":
                    from.Hide();
                    fromtxt.Hide();
                    to.Hide();
                    toTxt.Hide();
                    agregarInfectados.Hide();
                    cadena.Show();
                    cadena.Clear();
                    categorico.Hide();
                    ciudadChoosen = true;
                    break;
                case "Departamento":
                    agregarInfectados.Hide();
                    from.Hide();
                    fromtxt.Hide();
                    to.Hide();
                    toTxt.Hide();
                    cadena.Show();
                    cadena.Clear();
                    categorico.Hide();
                    ciudadChoosen = false;
                    break;
                case "Atencion":
                    agregarInfectados.Hide();
                    from.Hide();
                    fromtxt.Hide();
                    to.Hide();
                    toTxt.Hide();
                    chooseSexo = false;
                    cadena.Hide();
                    cadena.Clear();
                    categorico.Show();
                    categorico.Items.Clear();
                    fillAtencion();
                    break;
                case "Edad":
                    categorico.Hide();
                    categorico.Items.Clear();
                    cadena.Hide();
                    cadena.Clear();
                    from.Show();
                    fromtxt.Show();
                    to.Show();
                    toTxt.Show();
                    agregarInfectados.Show();
                    break;
                case "Sexo":
                    agregarInfectados.Hide();
                    from.Hide();
                    fromtxt.Hide();
                    to.Hide();
                    toTxt.Hide();
                    chooseSexo = true;
                    cadena.Hide();
                    cadena.Clear();
                    categorico.Show();
                    categorico.Items.Clear();
                    fillSexo();
                    break;
                default:
                    agregarInfectados.Hide();
                    from.Hide();
                    fromtxt.Hide();
                    to.Hide();
                    toTxt.Hide();
                    categorico.Hide();
                    categorico.Items.Clear();
                    cadena.Hide();
                    cadena.Clear();
                    break;
            }
        }

        private void cadena_TextChanged_1(object sender, EventArgs e)
        {
            if (ciudadChoosen)
            {
                table.DefaultView.RowFilter = $"CIUDAD LIKE '{cadena.Text}%'";
            }
            else
            {
                table.DefaultView.RowFilter = $"DEPARTAMENTO LIKE '{cadena.Text}%'";
            }
        }

        private void agregarInfectados_Click_1(object sender, EventArgs e)
        {
            int value1 = int.Parse(fromtxt.Text);
            int value2 = int.Parse(toTxt.Text);

            table.DefaultView.RowFilter = $"EDAD >= '{value1}' AND EDAD <= '{value2}'";
        }

        private void categorico_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (chooseSexo)
            {
                table.DefaultView.RowFilter = $"SEXO LIKE '{categorico.Text}%'";
            }
            else
            {
                table.DefaultView.RowFilter = $"ATENCION LIKE '{categorico.Text}%'";
            }
        }
    }
}
