using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO__Práctica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------> VARIABLES
            int menu1 = 0;
            // Contenido
            string titulo, plataforma, descripcion, url, usuario;
            int calificacion, genero, likes;
            // Pelicula
            string director, distribuidora;
            int año, duracion;
            // Serie
            int temporadas;
            bool finalizado;
            // Podcast
            int fechaCaducidad;
            bool formato;

            // ------------------------------> CONSTRUCTORES
            List<Episodio> episodios = new List<Episodio>();

            // ------------------------------> MAIN
            do
            {
                Console.WriteLine("1) Iniciar sesión");
                Console.WriteLine("2) Salir");
                Int32.TryParse(Console.ReadLine(), out menu1);
            } while (menu1 != 2);

            // ------------------------------> MÉTODOS

        }
    }
}
