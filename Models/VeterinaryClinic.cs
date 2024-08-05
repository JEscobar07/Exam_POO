using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaC_sharp_JonathanEscobarMolina.Models;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    //Clase principal publica 
    public class VeterinaryClinic
    {
        //Atributos
        public string Name;
        public string Address;
        public List<Dog> Dogs;
        public List<Cat> Cats;

        //Constructor vacio
        public VeterinaryClinic()
        {

        }

        //Constructor con parametros
        public VeterinaryClinic(string _name, string _address)
        {
            Name = _name;
            Address = _address;
            Dogs = new List<Dog>();
            Cats = new List<Cat>();
        }

        //Metodos


        //Metodos para guardar perros y gatos.
        public void SaveDog(Dog newDog)
        {
            if (Dogs.Find(item => (item.AnimalName().Equals(newDog.AnimalName()) && item.AnimalId() == newDog.AnimalId())) == null)
            {
                Dogs.Add(newDog);
                Console.WriteLine($"Se agrega un nuevo perro a nuestra veterinaria, Bienvenido :D ");
            }
            else
            {
                Console.WriteLine($"Lo sentimos, pero en nuestra veterinaria ya hay un perro que tiene el id: {newDog.AnimalId()}");
            }
        }

        public void SaveCat(Cat newCat)
        {
            if (Cats.Find(item => (item.AnimalName().Equals(newCat.AnimalName()) && item.AnimalId() == newCat.AnimalId())) == null)
            {
                Cats.Add(newCat);
                Console.WriteLine($"Se agrega un nuevo gato a nuestra veterinaria, Bienvenido :D ");
            }
            else
            {
                Console.WriteLine($"Lo sentimos, pero en nuestra veterinaria ya hay un gato que tiene el id: {newCat.AnimalId()}");
            }
        }

        //Metodos para actualizar perros y gatos.
        public void UpdateDog(Dog dog)
        {
            int option;
            Console.Write($"\nElige una opcion de lo que deseas actualizar del perro:\n1.Nombre\n2.Fecha de nacimiento\n3.Raza\n4.Color\n5.Peso en kilogramos\n6.Castraccion\n7.Temperamento\n8.Numero de microchip\n9.Volumen de ladrido\n10.Tamaño del pelo\n-----> ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write($"Ingresa el nuevo nombre del perro\n------>");
                    dog.AnimalName(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Ingresa el año de nacimiento:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el mes de nacimiento:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el dia de nacimiento:");
                    int day = Convert.ToInt32(Console.ReadLine());
                    if (new DateOnly(year, month, day) <= DateOnly.FromDateTime(DateTime.Now))
                    {
                        dog.AnimalBirthdate(new DateOnly(year, month, day));
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, pero la fecha de nacimiento no puede ser mayor que la fecha actual");
                    }
                    break;
                case 3:
                    Console.Write($"Ingresa la raza del perro\n------>");
                    if (int.TryParse(Console.ReadLine(), out var var) == true)
                    {
                        Console.WriteLine("Los sentimos pero este campo no puede contener numeros");
                    }
                    else
                    {
                        dog.AnimalBreed(Console.ReadLine());
                        
                    }
                    break;
                case 4:
                    Console.Write($"Ingresa el color del perro\n------>");
                    dog.AnimalColor(Console.ReadLine());
                    break;
                case 5:
                    Console.Write($"Ingresa el peso del perro en kilo gramos\n------>");
                    dog.AnimalWeightInKg(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 6:
                    Console.WriteLine("Cual es el estado de castraccion del perro?, Eligir una opcion\n1. Castrado\n 2. NO castrado");
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        dog.DogBreendingStatus(true);
                    }
                    else if (option == 2)
                    {
                        dog.DogBreendingStatus(false);
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
                    }
                    break;
                case 7:
                    Console.WriteLine("Cual es el temperamento del perro?, Eligir una opcion\n1. Timido\n 2. Normal\n3. Agresivo");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            dog.DogTemperament("Timido");
                            break;
                        case 2:
                            dog.DogTemperament("Normal");
                            break;
                        case 3:
                            dog.DogTemperament("Agresivo");
                            break;
                        default:
                            Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
                            break;
                    }
                    break;
                case 8:
                    Console.Write($"Ingresa el numero de microchip del perro \n------>");
                    dog.DogMicrochipNumber(Console.ReadLine());
                    break;
                case 9:
                    Console.WriteLine("Cual es el nivel de ladrido del perro?, Eligir una opcion\n1. Alto\n 2. Medio\n3. Bajo");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            dog.DogBarkVolume("Alto");
                            break;
                        case 2:
                            dog.DogBarkVolume("Medio");
                            break;
                        case 3:
                            dog.DogBarkVolume("Bajo");
                            break;
                        default:
                            Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine("Escribe el numero del estilo que tiene tu perro: \n1.Sin pelo\n2.Pelo corto\n3.Pelo Mediano\n4.Pelo largo");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            dog.DogCoatType("Sin pelo");
                            break;
                        case 2:
                            dog.DogCoatType("Pelo corto");
                            break;
                        case 3:
                            dog.DogCoatType("Pelo mediano");
                            break;
                        case 4:
                            dog.DogCoatType("Pelo largo");
                            break;
                        default:
                            Console.WriteLine("Error, elige una opcion disponible");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error, elige una opcion valida");
                    break;
            }
            Console.WriteLine($"El perro {dog.AnimalName()} ha sido ACTUALIZADO con exito.");
        }


        public void UpdateCat(Cat cat)
        {
            int option = 0;
            Console.Write($"\nElige una opcion de lo que deseas actualizar del gato:\n1.Nombre\n2.Fecha de nacimiento\n3.Raza\n4.Color\n5.Peso en kilogramos\n6.Castraccion\n7.Tamaño del pelo\n-----> ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write($"Ingresa el nuevo nombre del gato\n------>");
                    cat.AnimalName(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Ingresa el año de nacimiento:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el mes de nacimiento:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el dia de nacimiento:");
                    int day = Convert.ToInt32(Console.ReadLine());
                    cat.AnimalBirthdate(new DateOnly(year, month, day));
                    break;
                case 3:
                    Console.Write($"Ingresa la raza del gato\n------>");
                    cat.AnimalBreed(Console.ReadLine());
                    break;
                case 4:
                    Console.Write($"Ingresa el color del gato\n------>");
                    cat.AnimalColor(Console.ReadLine());
                    break;
                case 5:
                    Console.Write($"Ingresa el peso del gato en kilo gramos\n------>");
                    cat.AnimalWeightInKg(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 6:
                    Console.WriteLine("Cual es el estado de castraccion del gato?, Eligir una opcion\n1. Castrado\n 2. NO castrado");
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        cat.CatBreendingStatus(true);
                    }
                    else if (option == 2)
                    {
                        cat.CatBreendingStatus(false);
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
                    }
                    break;
                case 7:
                    Console.WriteLine("Escribe el numero del estilo que tiene tu gato: \n1.Sin pelo\n2.Pelo corto\n3.Pelo Mediano\n4.Pelo largo");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            cat.CatFurLength("Sin pelo");
                            break;
                        case 2:
                            cat.CatFurLength("Pelo corto");
                            break;
                        case 3:
                            cat.CatFurLength("Pelo mediano");
                            break;
                        case 4:
                            cat.CatFurLength("Pelo largo");
                            break;
                        default:
                            Console.WriteLine("Error, elige una opcion disponible");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error, elige una opcion valida");
                    break;
            }
            Console.WriteLine($"El gato {cat.AnimalName()} ha sido ACTUALIZADO con exito.");
        }

        //Metodos para eliminar perros y gatos.
        public void DeleteDog(int id)
        {
            Dog dogFound = Dogs.Find(item => item.AnimalId() == id);
            if (dogFound != null)
            {
                Dogs.Remove(dogFound);
                Console.WriteLine($"El perro con el id {id} se elimino correctamente");
            }
            else
            {
                Console.WriteLine($"\nEl perro con el id {id} NO se encuentra en nuestra veterinaria.");
            }
        }
        public void DeleteCat(int id)
        {
            Cat catFound = Cats.Find(item => item.AnimalId() == id);
            if (catFound != null)
            {
                Cats.Remove(catFound);
                Console.WriteLine($"El gato con el id {id} se elimino correctamente");
            }
            else
            {
                Console.WriteLine($"\nEl gato con el id {id} NO se encuentra en nuestra veterinaria.");
            }
        }

        //Metodos para Mostar perros y gatos.
        public void ShowAllPatients()
        {

            if (Dogs.Count != 0)
            {
                Console.WriteLine("\nPerros ingresados actualmente en la veterinaria:\n");
                foreach (Dog itemDog in Dogs)
                {
                    itemDog.ShowInformation();
                }
            }
            else
            {
                Console.WriteLine("\nActualmente NO hay perros registrados en nuestra veterinaria. :( ");
            }

            if (Cats.Count != 0)
            {
                Console.WriteLine("\nGatos ingresados actualmente en la veterinaria:\n");
                foreach (Cat itemCat in Cats)
                {
                    itemCat.ShowInformation();
                }
            }
            else
            {
                Console.WriteLine("\nActualmente NO hay gatos registrados en nuestra veterinaria. :( ");
            }

        }

        public void ShowAnimals(string type)
        {
            if (type.Equals("Perro", StringComparison.OrdinalIgnoreCase))
            {
                if (Dogs.Count != 0)
                {
                    Console.WriteLine("\nPerros ingresados actualmente en la veterinaria:\n");
                    foreach (Dog itemDog in Dogs)
                    {
                        itemDog.ShowInformation();
                    }
                }
                else
                {
                    Console.WriteLine("\nActualmente NO hay perros registrados en nuestra veterinaria. :( ");
                }

            }
            else if (type.Equals("Gato", StringComparison.OrdinalIgnoreCase))
            {
                if (Cats.Count != 0)
                {
                    Console.WriteLine("Gatos ingresados actualmente en la veterinaria:\n");
                    foreach (Cat itemCat in Cats)
                    {
                        itemCat.ShowInformation();
                    }
                }
                else
                {
                    Console.WriteLine("\nActualmente NO hay gatos registrados en nuestra veterinaria. :( ");
                }

            }
            else
            {
                Console.WriteLine($"Lo sentimos, pero no tenemos el tipo de animal {type} en nuestra veterinaria.");
            }
        }

        public void ShowPatient(string name)
        {
            bool flag = true;
            Dog dogFound = Dogs.Find(item => item.AnimalName().Equals(name, StringComparison.OrdinalIgnoreCase));
            Cat catFound = Cats.Find(item => item.AnimalName().Equals(name, StringComparison.OrdinalIgnoreCase));
            if (dogFound != null)
            {
                Console.WriteLine("\n");
                dogFound.ShowInformation();
                flag = false;
            }
            if (catFound != null)
            {
                Console.WriteLine("\n");
                catFound.ShowInformation();
                flag = false;
            }
            if (flag == true)
            {
                Console.WriteLine($"\nEl animal con el nombre {name} NO se encuentra en nuestra veterinaria.");
            }
        }

    }
}