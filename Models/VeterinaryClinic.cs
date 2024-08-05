using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    //Clase padre publica 
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

        }

        public void SaveCat(Cat newCat)
        {

        }

        //Metodos para actualizar perros y gatos.
        public void UpdateDog(Dog dog)
        {

        }

        public void UpdateCat(Cat cat)
        {

        }

        //Metodos para eliminar perros y gatos.
        public void DeleteDog(int id)
        {

        }
        public void DeleteCat(int id)
        {

        }

        //Metodos para Mostar perros y gatos.
        public void ShowAllPatients()
        {

        }

        public void ShowAnimals(string type)
        {

        }

        public void ShowPatient(int idPatient)
        {

        }

    }
}