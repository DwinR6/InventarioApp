using InventarioApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace InventarioApp.ViewModels
{
   public  class CategoryViewModel
    {
        #region Propiedades
        public string CategoryName { get; set; }
        public string Desciption { get; set; } 
        public List<Product> Product { get; set; }

        public Command AddNewCategoryCommand { get; set; }
        public Command AddProductToCategoryCommand { get; set; }
        private readonly Repository repository;
        #endregion

        #region Constructor
        public CategoryViewModel(Repository repository)
        {
            this.repository = repository;
            AddNewCategoryCommand = new Command(SaveCategory);
            AddProductToCategoryCommand = new Command(AddProduct);
        }

        private void AddProduct()
        {
            
        }

        private void SaveCategory()
        {
            
        }
        #endregion

    }
}
