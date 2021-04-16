using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialP1.Clases
{
    interface InterfaceMean
    {
        /// <summary>
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columna_parcial);


        /// <summary>
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion);


        /// <summary>
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion);



        /// <summary>
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz, string seccion);


        /// <summary>
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        string[,] sumatoria_general_por_alumno(string[,] matriz);
    }
}
