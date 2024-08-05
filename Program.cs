using PruebaC_sharp_JonathanEscobarMolina.Models;

VeterinaryClinic myFirstClinic = new VeterinaryClinic("Veterinaria Villa paula", "calle 54 # 50 - 74");

int op = -1;

while (op != 0)
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
9. Buscar un animal por su nombre.
10. Castrar un animal.
11. Peluquear un animal.
");
        ManagerApp.ShowSeparator();
        Console.WriteLine("Seleccione el número de la opción que desea realizar: ");
        op = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case 0:
                MessageForMenu(0);
                Console.WriteLine("¡GRACIAS POR USAR NUESTRO SISTEMA! HASTA LUEGO...");
                MessageForMenu(1);
                break;
            case 1:
                MessageForMenu(0);

                //Dato Quemado para ensayar rapido
                //myFirstClinic.SaveDog(new Dog(3, "Mary Poppins", new DateOnly(2023, 08, 07), "Stray", "brown", 15, true, "spoiled", "13158", "low", "Pelo corto"));
                
                    try
                    {
                        myFirstClinic.SaveDog(ManagerApp.CreateDog());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Error con el dato ingresado por favor vuelve a digitar el formulario");
                    }
                MessageForMenu(1);
                break;
            case 2:
                MessageForMenu(0);
                
                //Dato Quemado para ensayar rapido
                //myFirstClinic.SaveCat(new Cat(1, "Spok", new DateOnly(2010, 07, 04), "Persian", "black & white", 07, true, "sin pelo"));

                try
                {
                    myFirstClinic.SaveCat(ManagerApp.CreateCat());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Error con el dato ingresado por favor vuelve a digitar el formulario");
                }
  
                MessageForMenu(1);
                break;
            case 3:
                MessageForMenu(0);
                Console.WriteLine("Ingresa el Id del perro que deseas actualizar");
                int id = Convert.ToInt32(Console.ReadLine());
                Dog dogFounded = myFirstClinic.Dogs.FirstOrDefault(item => item.AnimalId() == id);
                if (dogFounded != null)
                {
                    myFirstClinic.UpdateDog(dogFounded);
                }
                else
                {
                    Console.WriteLine($"\nLo sentimos, pero el perro {id} NO se encuentra en nuestra veterinaria");
                }
                MessageForMenu(1);
                break;
            case 4:
                MessageForMenu(0);
                Console.WriteLine("Ingresa el Id del gato que deseas actualizar");
                id = Convert.ToInt32(Console.ReadLine());
                Cat catFounded = myFirstClinic.Cats.FirstOrDefault(item => item.AnimalId() == id);
                if (catFounded != null)
                {
                    myFirstClinic.UpdateCat(catFounded);
                }
                else
                {
                    Console.WriteLine($"\n\nLo sentimos, pero el gato {id} NO se encuentra en nuestra veterinaria");
                }
                MessageForMenu(1);
                break;
            case 5:
                MessageForMenu(0);
                Console.WriteLine("Ingresa el Id del perro que deseas eliminar");
                id = Convert.ToInt32(Console.ReadLine());
                myFirstClinic.DeleteDog(id);
                MessageForMenu(1);
                break;
            case 6:
                MessageForMenu(0);
                Console.WriteLine("Ingresa el Id del gato que deseas eliminar");
                id = Convert.ToInt32(Console.ReadLine());
                myFirstClinic.DeleteCat(id);
                MessageForMenu(1);
                break;
            case 7:
                MessageForMenu(0);
                myFirstClinic.ShowAllPatients();
                MessageForMenu(1);
                break;
            case 8:
                MessageForMenu(0);
                Console.Write("Ingresa el numero de acuerdo al tipo de animal quieres ver:\n\n1.Perro\n2.Gato\n\n---->");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    myFirstClinic.ShowAnimals("Perro");
                }
                else if (option == 2)
                {
                    myFirstClinic.ShowAnimals("Gato");
                }
                else
                {
                    Console.WriteLine($"\nLo sentimos, pero tienes que elegir un opcion valida para el tipo animal mostrado.");
                }
                MessageForMenu(1);
                break;
            case 9:
                MessageForMenu(0);
                Console.WriteLine("Ingresa el nombre del animal para mostrar la informacion:");
                string name = Console.ReadLine();
                myFirstClinic.ShowPatient(name);
                MessageForMenu(1);
                break;
            case 10:
                MessageForMenu(0);
                Console.WriteLine("Ingresa elija el animal al cual quiere castrar:\n\n1.Perro\n2.Gato");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("\nIngresa el Id del perro que deseas castrar");
                    id = Convert.ToInt32(Console.ReadLine());
                    dogFounded = myFirstClinic.Dogs.FirstOrDefault(item => item.AnimalId() == id);
                    if (dogFounded != null)
                    {
                        dogFounded.CastrateAnimal();
                    }
                    else
                    {
                        Console.WriteLine($"\nLo sentimos pero no hay ningun perro con el id {id}");
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("\nIngresa el Id del gato que deseas castrar");
                    id = Convert.ToInt32(Console.ReadLine());
                    catFounded = myFirstClinic.Cats.FirstOrDefault(item => item.AnimalId() == id);
                    if (catFounded != null)
                    {
                        catFounded.CastrateAnimal();
                    }
                    else
                    {
                        Console.WriteLine($"\nLo sentimos pero no hay ningun gato con el id {id}");
                    }
                }
                else
                {
                    Console.WriteLine("Lo sentimos, pero tienes que ingresar una opcion valida");
                }
                MessageForMenu(1);
                break;
            case 11:
                MessageForMenu(0);
                Console.WriteLine("Ingresa elija el animal al cual quiere peluquear:\n\n1.Perro\n2.Gato");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("\nIngresa el Id del perro que deseas peluquear");
                    id = Convert.ToInt32(Console.ReadLine());
                    dogFounded = myFirstClinic.Dogs.FirstOrDefault(item => item.AnimalId() == id);
                    if (dogFounded != null)
                    {
                        dogFounded.Hairdress();
                    }
                    else
                    {
                        Console.WriteLine($"\nLo sentimos pero no hay ningun perro con el id {id}");
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("\nIngresa el Id del gato que deseas peluquear");
                    id = Convert.ToInt32(Console.ReadLine());
                    catFounded = myFirstClinic.Cats.FirstOrDefault(item => item.AnimalId() == id);
                    if (catFounded != null)
                    {
                        catFounded.Hairdress();
                    }
                    else
                    {
                        Console.WriteLine($"\nLo sentimos pero no hay ningun gato con el id {id}");
                    }
                }
                else
                {
                    Console.WriteLine("Lo sentimos, pero tienes que ingresar una opcion valida");
                }
                MessageForMenu(1);
                break;
            default:
                Console.Write("Error, ingrese una opcion valida dentro del menu de opciones. ");
                MessageForMenu(1);
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine();
        Console.WriteLine("Error, ingresa una opcion nuevamente.");
        Console.WriteLine("\nIngresa cualquier tecla para volver al menu principal");
        Console.ReadKey();
    }
}


//Metodo para limpiar la interfaz despues de una accion o una respuesta
void MessageForMenu(int i)
{
    if (i == 1)
    {
        Console.WriteLine("\nIngresa cualquier tecla para volver al menu principal");
        Console.ReadKey();
    }
    else
    {
        Console.Clear();
    }

}
