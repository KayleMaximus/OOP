using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    static class WareHouse
    {
        public static string StoreName = "                            ZzZ  Zeus Gaming Computer Store   ZzZ";
        public static List<ProductSummary> InfoList ;
        public static List<Technical_Details> DetailList ;
        public static int countpc = 0;
        public static int countlap = 0;
        public static int total;
        
        static WareHouse()
        {

        }

        public static void Outputprice(int price)
        {
            #region xử lý int thành chuỗi để in ra dạng  xx.000.000 vnd
            string chuoi = Convert.ToString(price);
            int digit = chuoi.Length - 6;
            for (int i = 0; i < digit; i++)
            {
                Console.Write(chuoi[i]);
            }
            int check = 0;
            for (int i = digit; i < chuoi.Length; i++)
            {
                if (check == 0)
                {
                    Console.Write(".");
                    check = 3;
                }
                Console.Write(chuoi[i]);
                check--;
            }
            Console.WriteLine(" (VND)");
            #endregion 
        }

        public static void input()
        {
            #region Import Devices To Warehouse
            //PCs Infos
            ProductSummary Pro = new ProductSummary("001", 8999000, 3, "Perseus");
            ProductSummary Pro1 = new ProductSummary("002", 9999000, 3, "Achilles");
            ProductSummary Pro2 = new ProductSummary("003", 12990000, 4, "Theseus ");
            ProductSummary Pro3 = new ProductSummary("004", 16990000, 4, "Hercules ");
            ProductSummary Pro4 = new ProductSummary("005", 15000000, 5, "Zeus");
            ProductSummary Pro5 = new ProductSummary("006", 25000000, 5, "Pegasus");

            //Laptops Info
            ProductSummary Pro6 = new ProductSummary("101", 9690000, 2, "Dell Vostro Lite", "Dell ");
            ProductSummary Pro7 = new ProductSummary("102", 15690000, 2, "Dell Vostro 3405", "Dell ");
            ProductSummary Pro8 = new ProductSummary("103", 16800000, 2, "Dell G3 3579", "Dell");
            ProductSummary Pro9 = new ProductSummary("104", 19990000, 3, "Aspire 7 A715-42G-R4ST", "Acer");
            ProductSummary Pro10 = new ProductSummary("105", 27990000, 4, "TUF Dash F15 FX516PC", "Asus");
            ProductSummary Pro11 = new ProductSummary("106", 30199000, 5, "Legion 5 15ITH6", "Lenovo");

            //Add Devices Into List
            InfoList = new List<ProductSummary>();
            InfoList.Add(Pro);
            InfoList.Add(Pro1);
            InfoList.Add(Pro2);
            InfoList.Add(Pro3);
            InfoList.Add(Pro4);
            InfoList.Add(Pro5);
            InfoList.Add(Pro6);
            InfoList.Add(Pro7);
            InfoList.Add(Pro8);
            InfoList.Add(Pro9);
            InfoList.Add(Pro10);
            InfoList.Add(Pro11);

            //PCs Details
            Technical_Details pc = new PC("GT 730    ", 2, "INTELCORE™ i5-2400 ", "DDR3", 8, "HDD SEAGATE", 500, "SAMA ESPORT 2");
            Technical_Details pc1 = new PC("GTX 750   ", 2, "INTELCORE™ i3-4130 ", "DDR3", 8, "HDD WD     ", 500, "VSP          ");
            Technical_Details pc2 = new PC("GTX 1050  ", 2, "INTELCORE™ i5-6400 ", "DDR4", 8, "SSD KINGSTON", 240, "AeroCool Cylon Mini");
            Technical_Details pc3 = new PC("GTX 1050Ti", 4, "INTELCORE™ i5-8400 ", "DDR4", 8, "SSD CONSAIR", 512, "SAMA ESPORT 2");
            Technical_Details pc4 = new PC("GTX 1660 ", 6, "INTELCORE™ i5-10400F", "DDR5", 16, "SSD GIGABYTE", 512, "Jetek 9311");
            Technical_Details pc5 = new PC("GTX 1660 ", 6, "INTELCORE™ i5-11400F", "DDR5", 16, "SSD Samsung 981A", 512, "Jetek 9321 Led RGB");


            //Laptops Details
            Technical_Details lap = new Laptop("AMD Radeon Vega 8", "Intel Core i3 10110U", "DDR4", 4, "SSD NMVe", 256, 14);
            Technical_Details lap1 = new Laptop("AMD Radeon Vega 8", "AMD Ryzen 5 3500U", "DDR4", 4, "SSD NMVe", 256, 14);
            Technical_Details lap2 = new Laptop("Nvidia GTX 1050", 3, "Intel Core i5 8300H", "DDR4", 8, "SSD NMVe", 256, 15.6);
            Technical_Details lap3 = new Laptop("Nvidia GTX 1650", 4, "AMD Ryzen 5 5500U", "DDR4", 8, "SSD NMVe", 256, 15.6);
            Technical_Details lap4 = new Laptop("Nvidia RTX 3050", 4, "Intel Core i7 11370H", "DDR4", 8, "SSD NMVe", 512, 15.6);
            Technical_Details lap5 = new Laptop("Nvidia RTX 3050", 4, "Intel Core i7 11800H", "DDR4", 16, "SSD NMVe", 512, 15.6);

            //Add Devices Details Into List
            DetailList = new List<Technical_Details>();
            DetailList.Add(pc);
            DetailList.Add(pc1);
            DetailList.Add(pc2);
            DetailList.Add(pc3);
            DetailList.Add(pc4);
            DetailList.Add(pc5);
            DetailList.Add(lap);
            DetailList.Add(lap1);
            DetailList.Add(lap2);
            DetailList.Add(lap3);
            DetailList.Add(lap4);
            DetailList.Add(lap5);
            #endregion

            total = countpc + countlap;
        }


    }
}
