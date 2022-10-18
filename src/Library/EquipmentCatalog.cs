//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;
namespace Full_GRASP_And_SOLID
{
    public abstract class EquipmentCatalog
    {
        public static List<Equipment> equipmentCatalog = new List<Equipment>();//lista de los equipment
        public static void AddEquipment(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description,hourlyCost));  //la creacion de Equipment pasa a su contenedor, EquipmentCatalog
        }
        public static void PopulateCatalogs()//añade los elementos mas comunes
        {
            EquipmentCatalog.AddEquipment("Hervidor", 2000);
            EquipmentCatalog.AddEquipment("Cafetera", 1000);
        }
        public static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}