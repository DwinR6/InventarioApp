using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes
    ;

namespace InventarioApp.Models
{
    // Clases POCO ( Plane Old CLR Object )
    [Table("Categories")]
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(50), Unique]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [OneToMany(CascadeOperations =  CascadeOperation.CascadeInsert)]
        public List<Product> Products { get; set; }

    }
}
