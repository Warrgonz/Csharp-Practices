// dependencias

// Este es el encargado de arrancar, orquestar y terminar el programa, solo hace los llamados (instancias) hacia los metodos.
namespace Practices
{
    // Una clase no representa datos, representa comportamiento y estados
    // Para pensar en un clase hay que deducir, "Que va hacer esta clase?" en vez de "Que campos tiene esta clase?"
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("yuca:");
                Console.WriteLine("Yuca1");
                
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Opt 1 Selected");
                        break;
                    case "2":
                        Console.WriteLine("Successfully closed!");
                        return;
                }
            }


        }
    }
};

