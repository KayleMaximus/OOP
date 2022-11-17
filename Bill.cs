using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    class Bill : Coustomer
    {
        private int exchange;
        private int ProDuctPrice;
        private DateTime BuyDate;
        private string ProDuctName; 
        public Bill(string Coustomer, string CoustomerPhone, int CoustomerMoney, List<ProductSummary> ProductInfo, int ProductPosInList)
        {
            this.name = Coustomer;
            this.phone = CoustomerPhone;
            this.money = CoustomerMoney;
            this.ProDuctName = ProductInfo[ProductPosInList].ProductName;
            this.ProDuctPrice = ProductInfo[ProductPosInList].Price;
            this.exchange = this.money - ProductInfo[ProductPosInList].Price;
            BuyDate = DateTime.Now;
        }
        public void BillOut()
        {
            Console.WriteLine(WareHouse.StoreName);
            Console.WriteLine();
            Console.WriteLine("Purchase Date        : " + this.BuyDate);
            Console.WriteLine("Coustomer's Name     : " + this.name);
            Console.WriteLine("Coustomer's Phone    : " + this.phone);
            Console.Write("Coustomer's Payment  : ");   WareHouse.Outputprice(this.money);
            Console.WriteLine("Product's Name       : " + this.ProDuctName);
            Console.Write("Product's Price      : ");   WareHouse.Outputprice(this.ProDuctPrice);
            if(this.exchange != 0)
            {
                Console.Write("ExChange             : ");   WareHouse.Outputprice(exchange);
            }    
            else
            Console.WriteLine("ExChange             : 0 (VND)");       
        }
    }
}
