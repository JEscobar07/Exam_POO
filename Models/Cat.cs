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

        public void CastrateAnimal()
        {

        }

        public void Hairdress()
        {

        }
    }
}