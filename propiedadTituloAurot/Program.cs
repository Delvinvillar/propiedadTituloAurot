using System;

namespace propiedadTituloAurot
{

    class libro
    {
     public string Titulo { get; set; }
      public string Autor { get; set; }
      public int Paginas  { get; set; }

        public void MostrarIrformacion()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Paginas: {Paginas}");
        }
        public bool EsLargo()
            {
              return Paginas >500;
            
            }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            libro libro = new libro();
            libro.Titulo = "Habito Atomico";
            libro.Autor = " James Clear";
            libro.Paginas = 600;
            libro.MostrarIrformacion();

            if (libro.EsLargo())
            {
                Console.WriteLine("Este libro es largo");
            } else
            {
                Console.WriteLine("Este libro no es largo");
            }
        }
    }
}
