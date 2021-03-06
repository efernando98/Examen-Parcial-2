using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialP1.Clases
{
    class ClsFile
    {
        public string ruta { get; private set; }
        public string[] filas { get; private set; }
        public ClsFile()
        {
            this.abrir();
        }
        private string abrir()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Title = "Seleccione su Archivo Plano!";
            archivo.InitialDirectory = "c:\\";
            archivo.Filter = "Archivos CSV|*.csv";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                this.ruta = archivo.FileName;
            }
            return this.ruta;
        }
        public string[] obtenerFilas()
        {
            string[] filas = File.ReadAllLines(this.ruta, Encoding.ASCII);
            this.filas = filas;
            return filas;
        }
    }
}
