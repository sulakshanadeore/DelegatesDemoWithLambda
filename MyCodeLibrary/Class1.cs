using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyCodeLibrary
{//class library when compiled ----> .dll

    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

       
    }


    public delegate List<Products> DelegateToDisplayAllProducts();
    public delegate void Del_InsertProduct(Products p);
    public class ProductOperations
    {
         static List<Products> ProductsList = new List<Products>() 
        {
        new Products{ProductID=1,ProductName="Tea",Price=10 },
        new Products{ProductID=2,ProductName="Coffee",Price=20 },
        new Products{ProductID=3,ProductName="Chocolate",Price=30 },

        };
        public void AddProduct(Products p)
        { 
            ProductsList.Add(p);
        
        }

        public List<Products> DisplayProducts()
        {
            return ProductsList;


        }




        public void RemoveProduct(int id) 
        {
        
        }
        public void UpdateProduct(Products p, int id)
        { 
        
        
        }

        public List<Products> getAllProducts()
        { 
        return ProductsList;
        }

    
    }


}
