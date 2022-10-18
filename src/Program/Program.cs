//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        //private static List<Product> productCatalog = new List<Product>();

        //private static List<Equipment> equipmentCatalog = new List<Equipment>();

        public static void Main(string[] args)
        {
            PopulateCatalogs();//crea los productos mas comunes definido en el program
            Recipe recipe = new Recipe();
            recipe.FinalProduct = ProductCatalog.GetProduct("Café con leche");
            recipe.AddStep(ProductCatalog.GetProduct("Café"),100,EquipmentCatalog.GetEquipment("Cafetera"),120);
            //recipe.AddStep(new Step(GetProduct("Café"), 100, GetEquipment("Cafetera"), 120));
            recipe.AddStep(ProductCatalog.GetProduct("Leche"),200,EquipmentCatalog.GetEquipment("Hervidor"),60);
            //recipe.AddStep(new Step(GetProduct("Leche"), 200, GetEquipment("Hervidor"), 60));
            //por creator los step debe crearlos el Recipe
            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }
        private static void PopulateCatalogs()
        {
            EquipmentCatalog.PopulateCatalogs();
            ProductCatalog.PopulateCatalogs();
        }

        // private static Product ProductAt(int index)//???
        // {
        //     return productCatalog[index] as Product;
        // }

        // private static Equipment EquipmentAt(int index)//????
        // {
        //     return equipmentCatalog[index] as Equipment;
        // }

        //Los getProd,y getEquipm. quedaron en sus respectivas clases
        //los add igual
    }
}
