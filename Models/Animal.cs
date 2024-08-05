using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    //Clase publica padre para las clases Perro y Gato 
    public class Animal
    {
        //Atributos
        protected int Id;
        protected string Name;
        protected DateOnly Birthdate;
        protected string Breed;
        protected string Color;
        protected double WeightInKg;

        //Constructor
        public Animal(int _id, string _name, DateOnly _birthdate, string _breed, string _color, double _weightInKg)
        {
            Id = _id;
            Name = _name;
            Birthdate = _birthdate;
            Breed = _breed;
            Color = _color;
            WeightInKg = _weightInKg;
        }

        //Metodos
        public void ShowInformation()
        {

        }

        protected void BasicReview()
        {

        }

        protected int CalculateAgeInMonths()
        {
            return 0;
        }
    }
}