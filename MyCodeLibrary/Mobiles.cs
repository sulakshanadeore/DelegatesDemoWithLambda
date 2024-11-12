using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyCodeLibrary
{
    public delegate void DelegateDeleteMobile(string brand);

    public class MobileOpertaions
    {
      
         static    List<Mobiles> mobileList = new List<Mobiles>()
            {
   new Mobiles{ Brand="Apple",Price=70000},
   new Mobiles{Brand="Samsung",Price=80000 },
   new Mobiles{ Brand="MI",Price=50000}

            };
        
        

        public void AddMobileToList(Mobiles m)
        {
            mobileList.Add(m);
        }

        public void FindMobile(string brand)
        {
            foreach (var item in mobileList)
            {
                if (item.Brand == brand)
                {
                    Console.WriteLine(item.Brand);
                    Console.WriteLine(item.Price);
                }
                else
                {
                    Console.WriteLine("not found");
                }
            }
        }

        public void DeleteMobile(string brand)
        {
          
            Mobiles found=mobileList.Find(m1=>m1.Brand == brand);
            if (found != null)
            {
                mobileList.Remove(found);
                Console.WriteLine("Deleted");
            }
            else {
                Console.WriteLine("Not found");
            
            }
           //         int cnt=mobileList.Count;
           // for (int i = 0; i <cnt; i++)
           //{
           //     if (mobileList[i].Brand == brand)   
           //     {
           //         Mobiles m = new Mobiles();
           //         m.Brand = brand;
           //         m.Price = mobileList[i].Price;
           //         mobileList.Remove(m);
           //         Console.WriteLine("Deleting this brand mobile");
           //         break;
           //     }
           //     else
           //     {
           //         Console.WriteLine("Not found");
           //         break;
           //     }
               


            //}


        }


        public void ShowAllMobiles()
        {
            foreach (var mobile in mobileList)
            {
                Console.WriteLine(mobile.Brand);
                Console.WriteLine(mobile.Price);
                Console.WriteLine();
            }


        }

    }



    public class Mobiles
    {
        public string Brand { get; set; }
        public int Price { get; set; }
    
    }
}
