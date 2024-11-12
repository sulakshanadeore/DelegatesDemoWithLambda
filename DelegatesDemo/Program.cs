using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCodeLibrary;
namespace DelegatesDemo
{
    //when conosle app compile-----> .exe
    //exe is dependent on the code(.dll)
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobiles mobiles=new Mobiles();
              
           
            MobileOpertaions opertaions=new MobileOpertaions();
            
           
           
                Console.WriteLine("Menu 1.Add 2.Delete 3.Show 4.Find ");
                Console.WriteLine("neter choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter brand name");
                        mobiles.Brand = Console.ReadLine();
                        Console.WriteLine("Enter price");
                        mobiles.Price = Convert.ToInt32(Console.ReadLine());


                        opertaions.AddMobileToList(mobiles);
                        opertaions.ShowAllMobiles();
                        break;
                    case 2:

                        Console.WriteLine("Enter mobile brand to delete");
                        string brand = Console.ReadLine();
                        opertaions.DeleteMobile(brand);

                        break;
                    default:
                        break;
                }
            //Console.WriteLine("---------------");
            //opertaions.ShowAllMobiles();










            //Products p=new Products();
            //Console.WriteLine("Enter productid");
            //p.ProductID=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Product name ");
            //p.ProductName=Console.ReadLine();
            //Console.WriteLine("Enter Price");
            //p.Price=Convert.ToInt32(Console.ReadLine());

            //ProductOperations op = new ProductOperations();
            //Del_InsertProduct delobj = new Del_InsertProduct(op.AddProduct);//delegate pointing to method
            //delobj.Invoke(p);

            //foreach (var item in ProductOperations.ProductsList)
            //{
            //    Console.WriteLine(item.ProductID);
            //    Console.WriteLine(item.ProductName);
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine();
            //}

            //DelegateToDisplayAllProducts delList=new DelegateToDisplayAllProducts(op.DisplayProducts);
            //List<Products> pList=delList.Invoke();
            //foreach (var item in pList)
            //{
            //    Console.WriteLine(item.ProductID);
            //    Console.WriteLine(item.ProductName);
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine();
            //}


            Console.ReadLine();
        }
    }
}
