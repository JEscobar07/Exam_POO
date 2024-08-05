using PruebaC_sharp_JonathanEscobarMolina.Models;

VeterinaryClinic myFirstClinic = new VeterinaryClinic("Veterinaria Villa paula", "calle 54 # 50 - 74");

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
                break;
            case 1:
                myFirstClinic.SaveDog(new Dog(3, "Mary Poppins", new DateOnly(2023, 08, 07), "Stray", "brown", 15, false, "spoiled", "13158", "low", "short"));
                // myFirstClinic.SaveDog(ManagerApp.CreateDog());

                break;
            case 2:
                myFirstClinic.SaveCat(new Cat(1, "Spok", new DateOnly(2010, 07, 04), "Persian", "black & white", 07, false, "long"));
                // myFirstClinic.SaveCat(ManagerApp.CreateCat());
                Message();
                break;
            case 3:
                Console.WriteLine("Ingresa el Id del perro que deseas actualizar");
                int id = Convert.ToInt32(Console.ReadLine());
                Dog dogFounded = myFirstClinic.Dogs.FirstOrDefault(item => item.AnimalId() == id);
                if (dogFounded != null)
                {
                    myFirstClinic.UpdateDog(dogFounded);
                }
                else
                {
                    Console.WriteLine($"Lo sentimos, pero el perro {id} NO se encuentra en nuestra veterinaria");
                }
                Message();
                break;
            case 4:
                Console.WriteLine("Ingresa el Id del gato que deseas actualizar");
                id = Convert.ToInt32(Console.ReadLine());
                Cat catFounded = myFirstClinic.Cats.FirstOrDefault(item => item.AnimalId() == id);
                if (catFounded != null)
                {
                    myFirstClinic.UpdateCat(catFounded);
                }
                else
                {
                    Console.WriteLine($"Lo sentimos, pero el gato {id} NO se encuentra en nuestra veterinaria");
                }
                Message();
                break;
            case 5:
                Console.WriteLine("Ingresa el Id del perro que deseas eliminar");
                id = Convert.ToInt32(Console.ReadLine());
                myFirstClinic.DeleteDog(id);
                Message();
                break;
            case 6:
                Console.WriteLine("Ingresa el Id del gato que deseas eliminar");
                id = Convert.ToInt32(Console.ReadLine());
                myFirstClinic.DeleteCat(id);
                Message();
                break;
            case 7:
                myFirstClinic.ShowAllPatients();
                Message();
                break;
            case 8:
                Console.WriteLine("Ingresa el numero de acuerdo al tipo de animal quieres ver.\n1.Perro\n2.Gato");
                int option = Convert.ToInt32(Console.ReadLine());
                if ( option == 1)
                {
                    myFirstClinic.ShowAnimals("Perro");
                }else if( option == 2){
                    myFirstClinic.ShowAnimals("Gato");
                }else{
                    Console.WriteLine($"Lo sentimos, pero tienes que elegir un opcion valida para el tipo animal mostrado.");
                }
                Message();
                break;
            case 9:
                Console.WriteLine("Ingresa el nombre del animal para mostrar la informacion:");
                string name = Console.ReadLine();
                myFirstClinic.ShowPatient(name);
                Message();
                break;
            default:
                Console.Write("Error, ingrese una opcion valida dentro del menu de opciones. ");
                Message();
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine();
        Console.WriteLine("Error, ingresa una opcion nuevamente.");
        Console.ReadKey();
    }
}

void Message()
{
    Console.WriteLine("Ingresa cualquier tecla para volver al menu principal");
    Console.ReadKey();
}
