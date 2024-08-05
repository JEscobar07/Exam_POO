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
        public virtual void ShowInformation()
        {
            Console.WriteLine($"Id: {Id}\nNombre: {Name}\nFecha de cumpleaños: {Birthdate}\nRaza: {Breed}\nColor: {Color}\nPeso (Kilogramos): {WeightInKg}");
        }

        protected virtual void BasicReview()
        {
            Console.WriteLine($"Id: {Id}\nNombre: {Name}\nFecha de cumpleaños: {Birthdate}\nRaza: {Breed}");
        }

        protected int CalculateAgeInMonths()
        {
            return DateOnly.FromDateTime(DateTime.Now).Month - Birthdate.Month;
        }

        public int AnimalId()
        {
            return Id;
        }

        public string AnimalName()
        {
            return Name;
        }
        public void AnimalName(string name)
        {
            Name = name;
        }

        public void AnimalBirthdate(DateOnly birthdate)
        {
            Birthdate = birthdate;
        }

        public void AnimalBreed(string breed){
            Breed = breed;
        }

        public void AnimalColor(string color){
            Color = color;
        }

        public void AnimalWeightInKg(double weight){
            WeightInKg = weight;
        }


    }
}