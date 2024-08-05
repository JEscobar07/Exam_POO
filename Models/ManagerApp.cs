using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    //Clase estatica
    public static class ManagerApp
    {
        //Metodos para crear un perro o un gato
        public static Dog CreateDog()
        {
            ShowSeparator();
            Console.Write($"Dato #0");
            ShowSeparator();

            Console.Write($"Ingresa el ID del nuevo gato\n------>");
            int animalId = Convert.ToInt32(Console.ReadLine());

            ShowSeparator();
            Console.Write($"Dato #1");
            ShowSeparator();

            Console.Write($"Ingresa el nuevo nombre del perro\n------>");
            string animalName = Console.ReadLine();

            ShowSeparator();
            Console.Write($"Dato #2");
            ShowSeparator();

            Console.WriteLine("Ingresa el año de nacimiento:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el mes de nacimiento:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el dia de nacimiento:");
            int day = Convert.ToInt32(Console.ReadLine());
            DateOnly animalBirthdate = new DateOnly(year, month, day);

            ShowSeparator();
            Console.Write($"Dato #3");
            ShowSeparator();

            Console.Write($"Ingresa la raza del perro\n------>");
            string animalBreed = Console.ReadLine();

            ShowSeparator();
            Console.Write($"Dato #4");
            ShowSeparator();

            Console.Write($"Ingresa el color del perro\n------>");
            string animalColor = Console.ReadLine();

            ShowSeparator();
            Console.Write($"Dato #5");
            ShowSeparator();

            Console.Write($"Ingresa el peso del perro en kilo gramos\n------>");
            double animalWeightInKg = Convert.ToDouble(Console.ReadLine());

            ShowSeparator();
            Console.Write($"Dato #6");
            ShowSeparator();

            Console.WriteLine("Cual es el estado de castraccion del perro?, Eligir una opcion\n1. Castrado\n 2. NO castrado");
            int option = Convert.ToInt32(Console.ReadLine());
            bool dogBreendingStatus = false;
            if (option == 1)
            {
                dogBreendingStatus = true;
            }
            else if (option == 2)
            {
                dogBreendingStatus = false;
            }
            else
            {
                Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
            }

            ShowSeparator();
            Console.Write($"Dato #7");
            ShowSeparator();

            Console.WriteLine("Cual es el temperamento del perro?, Eligir una opcion\n1. Timido\n 2. Normal\n3. Agresivo");
            option = Convert.ToInt32(Console.ReadLine());
            string dogTemperament = "";
            switch (option)
            {
                case 1:
                    dogTemperament = "Timido";
                    break;
                case 2:
                    dogTemperament = "Normal";
                    break;
                case 3:
                    dogTemperament = "Agresivo";
                    break;
                default:
                    Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
                    break;
            }

            ShowSeparator();
            Console.Write($"Dato #8");
            ShowSeparator();

            Console.Write($"Ingresa el numero de microchip del perro \n------>");
            string dogMicrochipNumber = Console.ReadLine();

            ShowSeparator();
            Console.Write($"Dato #9");
            ShowSeparator();

            Console.WriteLine("Cual es el nivel de ladrido del perro?, Eligir una opcion\n1. Alto\n 2. Medio\n3. Bajo");
            option = Convert.ToInt32(Console.ReadLine());
            string dogBarkVolume = "";
            switch (option)
            {
                case 1:
                    dogBarkVolume = "Alto";
                    break;
                case 2:
                    dogBarkVolume = "Medio";
                    break;
                case 3:
                    dogBarkVolume = "Bajo";
                    break;
                default:
                    Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
                    break;
            }

            ShowSeparator();
            Console.Write($"Dato #10");
            ShowSeparator();

            Console.WriteLine("Escribe el numero del estilo que tiene tu perro: \n1.Sin pelo\n2.Pelo corto\n3.Pelo mediano\n4.Pelo largo");
            option = Convert.ToInt32(Console.ReadLine());
            string dogCoatType = "";

            switch (option)
            {
                case 1:
                    dogCoatType = "Sin pelo";
                    break;
                case 2:
                    dogCoatType = "Pelo corto";
                    break;
                case 3:
                    dogCoatType = "Pelo mediano";
                    break;
                case 4:
                    dogCoatType = "Pelo largo";
                    break;
                default:
                    Console.WriteLine("Error, elige una opcion disponible");
                    break;
            }
            return new Dog(animalId, animalName, animalBirthdate, animalBreed, animalColor, animalWeightInKg, dogBreendingStatus, dogTemperament, dogMicrochipNumber, dogBarkVolume, dogCoatType);
        }

        public static Cat CreateCat()
        {
            ShowSeparator();
            Console.Write($"Dato #0");
            ShowSeparator();

            Console.Write($"Ingresa el ID del nuevo gato\n------>");
            int animalId = Convert.ToInt32(Console.ReadLine());

            ShowSeparator();
            Console.Write($"Dato #1");
            ShowSeparator();

            Console.Write($"Ingresa el nuevo nombre del gato\n------>");
            string animalName = Console.ReadLine();

            ShowSeparator();
            Console.Write($"Dato #2");
            ShowSeparator();

            Console.WriteLine("Ingresa el año de nacimiento:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el mes de nacimiento:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el dia de nacimiento:");
            int day = Convert.ToInt32(Console.ReadLine());
            DateOnly animalBirthdate = new DateOnly(year, month, day);

            ShowSeparator();
            Console.Write($"Dato #3");
            ShowSeparator();

            Console.Write($"Ingresa la raza del gato\n------>");
            string animalBreed = Console.ReadLine();

            ShowSeparator();
            Console.Write($"Dato #4");
            ShowSeparator();

            Console.Write($"Ingresa el color del gato\n------>");
            string animalColor = Console.ReadLine();

            ShowSeparator();
            Console.Write($"Dato #5");
            ShowSeparator();

            Console.Write($"Ingresa el peso del gato en kilo gramos\n------>");
            double animalWeightInKg = Convert.ToDouble(Console.ReadLine());

            ShowSeparator();
            Console.Write($"Dato #6");
            ShowSeparator();

            Console.WriteLine("Cual es el estado de castraccion del gato?, Eligir una opcion\n1. Castrado\n 2. NO castrado");
            int option = Convert.ToInt32(Console.ReadLine());
            bool catBreendingStatus = false;
            if (option == 1)
            {
                catBreendingStatus = true;
            }
            else if (option == 2)
            {
                catBreendingStatus = false;
            }
            else
            {
                Console.WriteLine("Lo sentimos, pero debes elegir una opcion disponible");
            }


            ShowSeparator();
            Console.Write($"Dato #7");
            ShowSeparator();

            Console.WriteLine("Escribe el numero del estilo que tiene tu gato: \n1.Sin pelo\n2.Pelo corto\n3.Pelo mediano\n4.Pelo largo");
            option = Convert.ToInt32(Console.ReadLine());
            string catCoatType = "";

            switch (option)
            {
                case 1:
                    catCoatType = "Sin pelo";
                    break;
                case 2:
                    catCoatType = "Pelo corto";
                    break;
                case 3:
                    catCoatType = "Pelo mediano";
                    break;
                case 4:
                    catCoatType = "Pelo largo";
                    break;
                default:
                    Console.WriteLine("Error, elige una opcion disponible");
                    break;
            }
            return new Cat(animalId, animalName, animalBirthdate, animalBreed, animalColor, animalWeightInKg, catBreendingStatus, catCoatType);
        }

        //Metodos para ser utilizados en la interfaz o en alguna accion del sistema
        public static void ShowHeader()
        {
            Console.WriteLine(@$"
#############################################################################################
                                BIENVENIDO AL CENTRO VETERINARIO
#############################################################################################");
        }
        public static void ShowFooter()
        {
            Console.WriteLine(@$"
##############################################################################################
                                CODER: JONATHAN ESCOBAR MOLINA
##############################################################################################");
        }
        public static void ShowSeparator()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
    }