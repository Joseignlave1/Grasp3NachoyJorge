//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }
        public class FilePrinter : Iprinter
        {
            public void PrintRecipe(Recipe recipe)
            {
                File.WriteAllText( "Ticket.txt", recipe.GetTextToPrint());
            }
        }
        // agregamos un interfaz llamado Iprinter y dos clases, una llamada ConsolePrinter y la otra llamada FilePrinter
        // estas clases las hicimos mediante el patrón de polimorfismo, en la cuál la implementación del interfaz permite que no tengamos que comparar la dirección en un bucle 
        // cada vez que queremos imprimir la receta y cada vez que queremos imprimir el ticket, mediante esto podemos imprimirlo en varios destinos.
        
        public class ConsolePrinter : Iprinter
        {
            
            public void PrintRecipe(Recipe recipe)
            {
                System.Console.WriteLine(recipe.GetTextToPrint());
            }
        }
    
    }
