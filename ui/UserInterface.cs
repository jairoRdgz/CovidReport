using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable table;
        bool chooseSexo = false;

        public UserInterface()
        {
            InitializeComponent();
            initializeTable();
            categorico.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //
                path.Text = openFileDialog1.FileName;

                loadData(openFileDialog1.FileName);
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

        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(4.570868, -74.297333);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 6;
            gMapControl1.AutoScroll = true;
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

        private void campos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cases = campos.Text;

            switch (cases)
            {
                case "Ciudad":
                    
                    break;
                case "Departamento":
                    
                    break;
                case "Atencion":
                    chooseSexo = false;
                    categorico.Show();
                    categorico.Items.Clear();
                    fillAtencion();
                    break;
                case "Edad":

                    break;
                case "Sexo":
                    chooseSexo = true;
                    categorico.Show();
                    categorico.Items.Clear();
                    fillSexo();
                    break;
                default:
                    categorico.Hide();
                    categorico.Items.Clear();
                    break;
            }
        }

        private void categorico_SelectedIndexChanged(object sender, EventArgs e)
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
