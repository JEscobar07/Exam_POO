using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    //Clase publica hija de la herencia con la clase Animal
    public class Dog:Animal
    {
        //Atributos

        public bool BreedingStatus;
        public string Temperament;
        public string MicrochipNumber;
        public string BarkVolume;
        public string CoatType;

        //Constructor
        public Dog(bool _breedingStatus, string _temperament, string _microchipNumber, string _barkVolume, string _coatType)
        {
            BreedingStatus = _breedingStatus;
            Temperament = _temperament;
            MicrochipNumber = _microchipNumber;
            BarkVolume = _barkVolume;
            CoatType = _coatType;
        }

        //Metodos

        public void CastrateAnimal(){

        }

        public void Hairdress(){

        }


    }
}