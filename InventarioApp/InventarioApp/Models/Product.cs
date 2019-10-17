using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace InventarioApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public int UnitsInStoc { get; set; }
        public decimal Price { get; set; }
        [ForeignKey(typeof(Category))]
        public int CategoryID { get; set; }// FK
        [ManyToOne]
        public Category Category { get; set; }
    }
}
