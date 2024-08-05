using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    //Clase publica hija de la herencia con la clase Animal
    public class Dog : Animal
    {
        //Atributos

        public bool BreedingStatus;
        public string Temperament;
        public string MicrochipNumber;
        public string BarkVolume;
        public string CoatType;

        //Constructor
        public Dog(int _id, string _name, DateOnly _birthdate, string _breed, string _color, double _weightInKg, bool _breedingStatus, string _temperament, string _microchipNumber, string _barkVolume, string _coatType) : base(_id, _name, _birthdate, _breed, _color, _weightInKg)
        {
            BreedingStatus = _breedingStatus;
            Temperament = _temperament;
            MicrochipNumber = _microchipNumber;
            BarkVolume = _barkVolume;
            CoatType = _coatType;
        }

        //Metodos

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Estado de Castraccion: {BreedingStatus}\nTemperamento: {Temperament}\nNumero de microchip: {MicrochipNumber}\nVolumen de ladrido: {BarkVolume}\nTipo de corte: {CoatType}");

        }

        public void CastrateAnimal()
        {
            if (BreedingStatus == true)
            {
                BreedingStatus = true;
                Console.WriteLine("La castración del animal ha sido realizada con exito.");
            }
            else
            {
                Console.WriteLine("Lo sentimos, pero el animal ya se encuentra castrado.");
            }
        }

        public void Hairdress()
        {
            if (CoatType != "Pelo corto")
            {
                Console.WriteLine("Escribe el numero del estilo que deseas realizarle a tu perro: \n1.Sin pelo\n2.Pelo corto\n3.Pelo Mediano\n4.Pelo largo");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: 
                        CoatType = "Sin pelo";
                        break;
                    case 2:
                        CoatType = "Pelo corto";
                        break;
                    case 3:
                        CoatType = "Pelo mediano";
                        break;
                    case 4:
                        CoatType = "Pelo largo";
                        break;
                    default:
                        Console.WriteLine("Error, elige una opcion disponible");
                        break;
                }
                Console.WriteLine("Se ha realizado la peluqueria con exito.");
            }
        }
    }
}