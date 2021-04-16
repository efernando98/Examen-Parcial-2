using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialP1.Clases;

namespace ParcialP1
{
    public partial class Form1 : Form
    {
        public string[,] matriz;
        ClsArray arreglo = new ClsArray();
        ClsMean promedios = new ClsMean();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            ClsFile archivo = new ClsFile();
            this.textFile.Text = archivo.ruta; 
            string[] filas = archivo.obtenerFilas();

            foreach (string linea in filas)
            {
                this.listFile.Items.Add(linea);
            }

            this.matriz = arreglo.DosDimensiones(filas, 7);
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                this.listParcial.Items.Add(matriz[i, 1] + " - " + matriz[i, 6]);
            }
        }

        private void btnP1A_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            int datos = promedios.promedios_por_parcial(this.matriz, 2);
            this.listParcial.Items.Add("Promedio por Parcial Uno: " + datos);
        }

        private void btnP2A_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            int datos = promedios.promedios_por_parcial(this.matriz, 3);
            this.listParcial.Items.Add("Promedio por Parcial Dos: " + datos);
        }

        private void btnP3A_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            int datos = promedios.promedios_por_parcial(this.matriz, 4);
            this.listParcial.Items.Add("Promedio por Parcial Tres: " + datos);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            string[,] datos = promedios.sumatoria_general_por_alumno(this.matriz);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                this.listParcial.Items.Add(datos[i, 0] + "   -    Sumatoria: " + datos[i, 1]);
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            string seccion = this.textSecc.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 6, seccion);
            this.listParcial.Items.Add("Promedio General Por Seccion " + seccion + " :   " + datos);
        }

        private void btnP1G_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            string seccion = this.textSecc.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 2, seccion);
            this.listParcial.Items.Add("Promedio General Por Parcial Uno en la Sección " + seccion + " :   " + datos);
        }

        private void btnP2G_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            string seccion = this.textSecc.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 3, seccion);
            this.listParcial.Items.Add("Promedio General Por Parcial Dos en la Sección " + seccion + " :   " + datos);
        }

        private void btnP3G_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            string seccion = this.textSecc.Text;
            int datos = promedios.promedios_por_seccion(this.matriz, 3, seccion);
            this.listParcial.Items.Add("Promedio General Por Parcial Tres en la Sección " + seccion + " :   " + datos);
        }

        private void btnClasif_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            string seccion = this.textSecc.Text;
            string[,] datos = promedios.Clasificar_Alumnos(this.matriz, seccion);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                this.listParcial.Items.Add(datos[i, 0] + "; " + datos[i, 1] + "; " + datos[i, 2] + "; " + datos[i, 3] + "; " + datos[i, 4] + "; " + datos[i, 5] + "; " + datos[i, 6] + "; ");
            }
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            string[] datos = arreglo.OrdenarString(this.matriz, 1);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listParcial.Items.Add(datos[i]);
            }
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            int[] datos = arreglo.OrdenarInt(this.matriz, 2);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listParcial.Items.Add(datos[i]);
            }
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            int[] datos = arreglo.OrdenarInt(this.matriz, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listParcial.Items.Add(datos[i]);
            }
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            this.listParcial.Items.Clear();
            int[] datos = arreglo.OrdenarInt(this.matriz, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listParcial.Items.Add(datos[i]);
            }
        }
    }
}
