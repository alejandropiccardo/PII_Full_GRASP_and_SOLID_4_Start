//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;
namespace Full_GRASP_And_SOLID
{
    public abstract class ProductCatalog
    {
        public static List<Product> productCatalog = new List<Product>();//lista de los productos
        public static void AddProduct(string description, double unitCost)
        {
            productCatalog.Add(new Product(description,unitCost));  //la creacion de product pasa a su contenedor, productCatalog
        }
        public static void PopulateCatalogs()//añade los elementos mas comunes
        {
            ProductCatalog.AddProduct("Café", 100);
            ProductCatalog.AddProduct("Leche", 200);
            ProductCatalog.AddProduct("Café con leche", 300);
        }
        public static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }
    }
}