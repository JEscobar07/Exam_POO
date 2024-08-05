using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    public class Cat : Animal
    {
        //Atributos

        public bool BreedingStatus;
        public string FurLength;

        //Constructor
        public Cat(int _id, string _name, DateOnly _birthdate, string _breed, string _color, double _weightInKg, bool _breedingStatus, string _furLength) : base(_id, _name, _birthdate, _breed, _color, _weightInKg)
        {
            BreedingStatus = _breedingStatus;
            FurLength = _furLength;
        }

        //Metodos

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Estado de Castraccion: {BreedingStatus}\nTipo de corte: {FurLength}");

        }

        public void CastrateAnimal()
        {
            if (BreedingStatus == true)
            {
                BreedingStatus = false;
                Console.WriteLine("\nLa castración del animal ha sido realizada con exito.");
            }
            else
            {
                Console.WriteLine("\nLo sentimos, pero el animal ya se encuentra castrado.");
            }
        }

        public void Hairdress()
        {
            if (FurLength != "Pelo corto")
            {
                Console.WriteLine("Escribe el numero del estilo que deseas realizarle a tu gato: \n1.Sin pelo\n2.Pelo corto\n3.Pelo Mediano\n4.Pelo largo");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FurLength = "Sin pelo";
                        break;
                    case 2:
                        FurLength = "Pelo corto";
                        break;
                    case 3:
                        FurLength = "Pelo mediano";
                        break;
                    case 4:
                        FurLength = "Pelo largo";
                        break;
                    default:
                        Console.WriteLine("Error, elige una opcion disponible");
                        break;
                }
                Console.WriteLine("Se ha realizado la peluqueria con exito.");
            }
        }
        public void CatBreendingStatus(bool breedingStatus)
        {
            BreedingStatus = breedingStatus;
        }
        public void CatFurLength(string furLength)
        {
            FurLength = furLength;
        }
    }
}