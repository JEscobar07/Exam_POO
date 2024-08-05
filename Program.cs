using PruebaC_sharp_JonathanEscobarMolina.Models;

while (true)
{
    try
    {
        Console.Clear();
        ManagerApp.ShowHeader();
        ManagerApp.ShowSeparator();
        Console.WriteLine(@"
0. Salir.
1. Ingresar un perro a la veterinaria.
2. Ingresar un gato a la veterinaria.
3. Actualizar un perro de la veterinaria.
4. Actualizar un gato de la veterinaria.
5. Eliminar un perro de la veterinaria.
6. Eliminar un gato de la veterinaria.
7. Mostrar todos los animales de la veterinaria.
8. Mostrar los animales de la veterinaria por tipo de animal (Gato, Perro).
9. Buscar un animal por su nombre.");
        ManagerApp.ShowSeparator();
        Console.WriteLine("Seleccione el número de la opción que desea realizar: ");
        int op = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case 0:
                Console.Clear();
                Console.WriteLine("¡GRACIAS POR USAR NUESTRO SISTEMA! HASTA LUEGO...");
                return;
            case 1:
                Console.ReadKey();
                break;
            case 2:
                Console.ReadKey();
                break;
            case 3:
                Console.ReadKey();
                break;
            case 4:
                Console.ReadKey();
                break;
            case 5:
                Console.ReadKey();
                break;
            case 6:
                Console.ReadKey();
                break;
            case 7:
                Console.ReadKey();
                break;
            case 8:
                Console.ReadKey();
                break;
            case 9:
                Console.ReadKey();
                break;
            case 10:
                Console.ReadKey();
                break;
            case 11:
                Console.ReadKey();
                break;
            case 12:
                Console.ReadKey();
                break;
            case 13:
                Console.ReadKey();
                break;
            default:
                Console.Write("Presione cualquier tecla para volver al menú: ");
                Console.ReadKey();
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine();
        Console.WriteLine("Error, La opción que escogio NO es valida. ingresa una opcion nuevamente.");
        Console.ReadKey();
    }
}
