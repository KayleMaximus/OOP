using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    class ProductSummary
    {
       
        //Product's Info
        private  string productID;
        private int price;
        private int warranty;
        private string productName;
        private string productBrand;


        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new Exception($"{nameof(value)} must bigger than 5.000.000 VND");
                price = value;
            }
        }

        public int Warranty
        {
            get => warranty;
            set
            {
                if (value <= 0)
                    throw new Exception($"{nameof(value)} must has at least 1 year!");
            }
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }


        //Constructor For Laptop (without vram) Details
        public ProductSummary(string vgabrand,string cpuname,string ramgen,int ramcap,string disktype,int diskcap )
        {

        }

        //Constructor For PC/Laptop Details
        public ProductSummary(string vgabrand, int vgacap, string cpuname, string ramgen, int ramcap, string disktype, int diskcap)
        {

        }
        //Consturctor For Laptop Info
        public ProductSummary (string pID, int price, int warranty, string PName, string Pbrand)
        {
            this.ProductID = pID;
            this.price = price;
            this.warranty = warranty;
            this.ProductName = PName;
            this.productBrand = Pbrand;
        }

        //Constructor For PC Info (Don't have brand)
        public ProductSummary(string pID, int price, int warranty, string PName)
        {
            this.ProductID = pID;
            this.price = price;
            this.warranty = warranty;
            this.ProductName = PName;
        }

        

        public void OutputLaptop()
        {
            Console.WriteLine("Laptop's ID      : " + this.ProductID);
            Console.WriteLine("Name             : " + this.ProductName);
            Console.WriteLine("Brand            : " + this.productBrand);
            Console.WriteLine("Warranty         : " + this.warranty + " years");
            Console.Write("Price            : ");
            WareHouse.Outputprice(this.price);
        }

        public void OutputPC()
        {
            Console.WriteLine("PC's ID          : " + this.ProductID);
            Console.WriteLine("Name             : " + this.ProductName);
            Console.WriteLine("Warranty         : " + this.warranty + " years");
            Console.Write("Price            : ");
            WareHouse.Outputprice(this.price);
        }
    }
}
