namespace inventario;

public class Program
{
    public static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("=== Bienvenido a la app inventario ===");
            Console.WriteLine("Seleccione alguna de las siguientes opciones:\n" +
                              "1: Crear producto\n" +
                              "2: Agregar Stock\n" +
                              "3: Vender productos\n" +
                              "4: Consultar la información del producto\n" +
                              "5: Ver el historial de movimientos del stock\n" +
                              "6: Salir");

            string input = Console.ReadLine();

            // Convertir input a int y retorna si fue valid
            bool isValidOption = int.TryParse(input, out int opcion);

            if (!isValidOption)
            {
                Console.WriteLine("Debe ingresar un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    // Create product
                    break;

                case 2:
                    // Add stock
                    break;

                case 3:
                    // Sell products
                    break;

                case 4:
                    // Show product information
                    break;

                case 5:
                    // Show stock movement history
                    break;

                case 6:
                    salir = true;
                    Console.WriteLine("Saliendo del sistema");
                    break;

                default:
                    Console.WriteLine("Seleccione una opción válida");
                    break;
            }
        }
    }
}