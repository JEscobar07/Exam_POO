using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    public class Cat:Animal
    {
        //Atributos

        public bool BreedingStatus;
        public string FurLength;

        //Constructor
        public Cat(bool _breedingStatus, string _furLength):base()
        {
            BreedingStatus = _breedingStatus;
            FurLength = _furLength;
        }

        //Metodos

        public void CastrateAnimal(){

        }

        public void Hairdress(){

        }
    }
}