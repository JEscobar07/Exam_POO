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
            Dogs.Add(newDog);
            Console.WriteLine($"Se agrega un nuevo perro a nuestra veterinaria, Bienvenido :D ");
        }

        public void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
            Console.WriteLine($"Se agrega un nuevo gato a nuestra veterinaria, Bienvenido :D ");
        }

        //Metodos para actualizar perros y gatos.
        public void UpdateDog(Dog dog)
        {
            int option = 0;
            Dog dogFounded = Dogs.FirstOrDefault(item => item.AnimalId() == dog.AnimalId());
            if (dogFounded != null)
            {
                Console.Write($"\nElige una opcion de lo que deseas actualizar del perro:\n1.Nombre\n2.Fecha de nacimiento\n3.Raza\n4.Color\n5.Peso en kilogramos\n6.Castraccion\n7.Temperamento\n8.Numero de microchip\n9.Volumen de ladrido\n10.Tamaño del pelo\n-----> ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write($"Ingresa el nuevo nombre del perro\n------>");
                        dogFounded.AnimalName(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el año de nacimiento:");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el mes de nacimiento:");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el dia de nacimiento:");
                        int day = Convert.ToInt32(Console.ReadLine());
                        dogFounded.AnimalBirthdate(new DateOnly(year, month, day));
                        break;
                    case 3:
                        Console.Write($"Ingresa la raza del perro\n------>");
                        dogFounded.AnimalBreed(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write($"Ingresa el color del perro\n------>");
                        dogFounded.AnimalColor(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write($"Ingresa el peso del perro en kilo gramos\n------>");
                        dogFounded.AnimalWeightInKg(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 6:
                        Console.WriteLine("Cual es el estado de castraccion del perro?, Eligir una opcion\n1. Castrado\n 2. NO castrado");
                        option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            dogFounded.DogBreendingStatus(true);
                        }
                        else if (option == 2)
                        {
                            dogFounded.DogBreendingStatus(false);
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
                                dogFounded.DogTemperament("Timido");
                                break;
                            case 2:
                                dogFounded.DogTemperament("Normal");
                                break;
                            case 3:
                                dogFounded.DogTemperament("Agresivo");
                                break;
                            default:
                                Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
                                break;
                        }
                        break;
                    case 8:
                        Console.Write($"Ingresa el numero de microchip del perro \n------>");
                        dogFounded.DogMicrochipNumber(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Cual es el nivel de ladrido del perro?, Eligir una opcion\n1. Alto\n 2. Medio\n3. Bajo");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                dogFounded.DogBarkVolume("Alto");
                                break;
                            case 2:
                                dogFounded.DogBarkVolume("Medio");
                                break;
                            case 3:
                                dogFounded.DogBarkVolume("Bajo");
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
                                dogFounded.DogCoatType("Sin pelo");
                                break;
                            case 2:
                                dogFounded.DogCoatType("Pelo corto");
                                break;
                            case 3:
                                dogFounded.DogCoatType("Pelo mediano");
                                break;
                            case 4:
                                dogFounded.DogCoatType("Pelo largo");
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
                Console.WriteLine($"El perro {dogFounded.AnimalName()} ha sido ACTUALIZADO con exito.");
            }
            else
            {
                Console.WriteLine($"Lo sentimos, pero el perro {dogFounded.AnimalName()} NO se encuentra en nuestra veterinaria");
            }
        }


        public void UpdateCat(Cat cat)
        {
            int option = 0;
            Cat catFounded = Cats.FirstOrDefault(item => item.AnimalId() == cat.AnimalId());
            if (catFounded != null)
            {
                Console.Write($"\nElige una opcion de lo que deseas actualizar del gato:\n1.Nombre\n2.Fecha de nacimiento\n3.Raza\n4.Color\n5.Peso en kilogramos\n6.Castraccion\n7.Tamaño del pelo\n-----> ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write($"Ingresa el nuevo nombre del gato\n------>");
                        catFounded.AnimalName(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el año de nacimiento:");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el mes de nacimiento:");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el dia de nacimiento:");
                        int day = Convert.ToInt32(Console.ReadLine());
                        catFounded.AnimalBirthdate(new DateOnly(year, month, day));
                        break;
                    case 3:
                        Console.Write($"Ingresa la raza del gato\n------>");
                        catFounded.AnimalBreed(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write($"Ingresa el color del gato\n------>");
                        catFounded.AnimalColor(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write($"Ingresa el peso del gato en kilo gramos\n------>");
                        catFounded.AnimalWeightInKg(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 6:
                        Console.WriteLine("Cual es el estado de castraccion del gato?, Eligir una opcion\n1. Castrado\n 2. NO castrado");
                        option = Convert.ToInt32(Console.ReadLine());
                        if (option == 1)
                        {
                            catFounded.CatBreendingStatus(true);
                        }
                        else if (option == 2)
                        {
                            catFounded.CatBreendingStatus(false);
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
                                catFounded.CatFurLength("Sin pelo");
                                break;
                            case 2:
                                catFounded.CatFurLength("Pelo corto");
                                break;
                            case 3:
                                catFounded.CatFurLength("Pelo mediano");
                                break;
                            case 4:
                                catFounded.CatFurLength("Pelo largo");
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
                Console.WriteLine($"El gato {catFounded.AnimalName()} ha sido ACTUALIZADO con exito.");
            }
            else
            {
                Console.WriteLine($"Lo sentimos, pero el gato {catFounded.AnimalName()} NO se encuentra en nuestra veterinaria");
            }
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
                Console.WriteLine($"El perro con el id {id} NO se encuentra en nuestra veterinaria.");
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
                Console.WriteLine($"El gato con el id {id} NO se encuentra en nuestra veterinaria.");
            }
        }

        //Metodos para Mostar perros y gatos.
        public void ShowAllPatients()
        {
            Console.WriteLine("Perros ingresados actualmente en la veterinaria:");
            foreach (Dog itemDog in Dogs)
            {
                itemDog.ShowInformation();
            }
            Console.WriteLine("Gatos ingresados actualmente en la veterinaria:");
            foreach (Cat itemCat in Cats)
            {
                itemCat.ShowInformation();
            }
        }

        public void ShowAnimals(string type)
        {
            if (type.Equals("Perro", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Perros ingresados actualmente en la veterinaria:");
                foreach (Dog itemDog in Dogs)
                {
                    itemDog.ShowInformation();
                }
            }
            else if (type.Equals("Gato", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Gatos ingresados actualmente en la veterinaria:");
                foreach (Cat itemCat in Cats)
                {
                    itemCat.ShowInformation();
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
                dogFound.ShowInformation();
                flag = false;
            }
            if (catFound != null)
            {
                catFound.ShowInformation();
                flag = false;
            }
            if (flag == true)
            {
                Console.WriteLine($"El animal con el nombre {name} NO se encuentra en nuestra veterinaria.");
            }
        }

    }
}