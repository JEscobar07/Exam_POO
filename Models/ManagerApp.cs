using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_JonathanEscobarMolina.Models
{
    //Clase estatica
    public static class ManagerApp
    {
        //Metodos
        // public static Dog CreateDog(){

        // }
        // public static Cat CreateCat(){

        // }

        public static void ShowHeader(){
            Console.WriteLine(@$"
#############################################################################################
                                BIENVENIDO AL CENTRO VETERINARIO
#############################################################################################");
        }
        public static void ShowFooter(){
            Console.WriteLine(@$"
##############################################################################################
                                CODER: JONATHAN ESCOBAR MOLINA
##############################################################################################");
        }
        public static void ShowSeparator(){
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
    }
}