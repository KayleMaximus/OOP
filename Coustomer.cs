using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    class Coustomer
    {
        protected string name; 
        protected string phone;
        private string adress;
        private string email;
        public int money;

        public Coustomer()
        {

        }

        public void input()
        {
            Console.Write("Your Name: ");
            this.name = Console.ReadLine();
            #region Dùng bảng Mã Ascii để tạo hình khung nhạc
            byte keycode3 = 14;
            char music = (char)(keycode3);
            for (int i = 0; i < 35; i++)
            {
                Console.Write(music + " ");
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine(music + "      We Really Glad That *" + this.name + "* Visit Our Store! (*^____^*)    " + music);
            Console.WriteLine(music + "      We Would Like To Get To Know You A Little Better (>'-'<)     " + music);

            #region Dùng bảng Mã Ascii để tạo hình trái tim trong câu xin info
            byte keycode1 = 3;
            char heart = (char)(keycode1);
            #endregion

            Console.WriteLine(music + "      PLease Share Us Some Of Your Infos " + heart + "                         " + music);

            #region Dùng bảng Mã Ascii để tạo hình khung nhạc
            for (int i = 0; i < 35; i++)
            {
                Console.Write(music + " ");
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine();
            Console.Write("Let Us Know Your Phone Number: ");
            this.phone = Console.ReadLine();
            Console.Write("Your Adress: ");
            this.adress = Console.ReadLine();
            Console.Write("Your Email: ");
            this.email = Console.ReadLine();

            #region Ascii
            byte keycode2 = 4;
            char exclamation = (char)(keycode2);
            byte keycode4 = 5;
            char smileface = (char)(keycode4);
            #endregion
            Console.WriteLine();
            Console.WriteLine(exclamation + "" + exclamation + "" + exclamation + "    Please Note That Our Store's Products Are Devided Into 3 Segments    " + exclamation + exclamation + exclamation);
            Console.WriteLine("       " + smileface + "   Popular   " + smileface + "         5.000.000 - 10.000.000 (VND)");
            Console.WriteLine("       " + smileface + "    Middle   " + smileface + "        10.000.000 - 20.000.000 (VND)");
            Console.WriteLine("       " + smileface + "  High-class " + smileface + "             above   20.000.000 (VND)");
            Console.WriteLine();
            Console.WriteLine("And How Much Money You Would Love Pay For A New Device?");
            Console.Write("Your Budget (VND): ");
            this.money = int.Parse(Console.ReadLine());
            while (this.money <= 5000000)
            {
                Console.WriteLine("You Can't Even Take A Girl Out With That Little Money!!!");
                Console.Write("Need Me Bank Money? (Y/N): ");
                string opinion = Console.ReadLine();

                if (opinion.IndexOf("Y") != -1 || opinion.IndexOf("y") != -1)
                {
                    Console.WriteLine();
                    Console.WriteLine("( $ _ $ ) ( $ _ $ ) ( $ _ $ )");
                    Console.WriteLine("Lucky For You I Played Bitcoin! :) ");
                    Console.Write("Your Budget (For Now): ");
                    this.money = 999000000;
                    WareHouse.Outputprice(this.money);
                    Console.WriteLine("( $ _ $ ) ( $ _ $ ) ( $ _ $ )");
                    Console.WriteLine();
                }
            }
        }
        //Methods
        public void output()
        {
            Console.Clear();
            #region Dùng bảng Mã Ascii để tạo hình trái tim 
            byte keycode = 3;
            char heart = (char)(keycode);
            for (int i = 0; i < 60; i++)
            {
                Console.Write(heart + " ");
            }
            #endregion

            # region xử lý in thông tin
            Console.WriteLine("Please Confirm Your Infos For Futher Better Service! (UwU) ");
            Console.WriteLine("Your Name        : " + this.name);
            Console.WriteLine("Your Email       : " + this.email);
            Console.Write("Your Budget      : ");
            WareHouse.Outputprice(this.money);
            Console.WriteLine("Your Adress      : " + this.adress);
            Console.WriteLine("Your Phone Number: " + this.phone);
            #endregion  

            #region Dùng bảng Mã Ascii để tạo hình trái tim 
            for (int i = 0; i < 60; i++)
            {
                Console.Write(heart + " ");
            }
            #endregion
            Console.WriteLine();
        }

//        private void 

        public void Opinion(List <ProductSummary> Info , List<Technical_Details> Detail )
        {
            int kick = 0;
            int back = 1;               //đánh dấu đã chọn phân khúc để thực hiện 1. chọn sp 2. là in hóa đơn
            int choice;
            int choice1;
            #region xử lý coustomer choice
            do
            {
                #region xử lý menu chọn mua pc / laptop
                Console.WriteLine("=========================================  What Would You Love To Buy?  ================================================");
                Console.WriteLine("1:PC");
                Console.WriteLine("2:Laptop");
                Console.WriteLine("3:Quit");
                Console.Write("Your Choice: " );
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                #endregion

                switch (choice)
                {
                    #region xử lý lựa chọn pc
                    case 1:                     //Chọn mua PC
                        do
                        {


                            #region xử lý menu giá tiền pc
                            Console.WriteLine("==========================      Please Chose Segment That Suits Your Budget The Most      ==============================");
                            Console.WriteLine("1:  5.000.000 - 10.000.000 VND");
                            Console.WriteLine("2: 10.000.000 - 20.000.000 VND");
                            Console.WriteLine("3:            > 20.000.000 VND");
                            Console.WriteLine("4: Back to menu");
                            Console.Write(    "Your Choice: " );
                            choice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            #region Dùng bảng Mã Ascii để tạo hình trái tim 
                            byte keycode = 3;
                            char heart = (char)(keycode);
                            for (int i = 0; i < 60; i++)
                            {
                                Console.Write(heart + " ");
                            }
                            #endregion

                            #endregion

                            #region xử lý lựa chọn phân khúc pc                           
                            switch (choice1)
                            {
                                case 1:                 //chọn sản phẩm pc dưới 10tr
                                    #region check số tiền so với segment phổ thông đã chọn
                                    //ko thêm code cho case này vì đã có hàm input đảm bảo số tiền luôn lớn hơn 5tr 
                                    #endregion
                                    #region xử lý in thông tin pc dưới 10tr
                                    Console.Clear();
                                    for (int i = 0; i < WareHouse.countpc; i++)
                                    {
                                        if (Info[i].Price < 10000000)
                                        {

                                            Info[i].OutputPC();
                                            Detail[i].output();
                                            /*PC pc = (PC)Detail[i];
                                            pc.output();*/
                                        }
                                    }
                                    #endregion
                                    back = 0;
                                    break;
                                case 2:                 //Chọn mua sản phẩm pc tầm trung (10tr - 20tr)
                                    #region Check số tiền so với segment tầm trung đã chọn
                                    if (this.money < 10000000)
                                    {
                                        Console.WriteLine("Your Budget Can't Affort This Segment!");
                                        Console.Write("Your Current Budget: ");
                                        WareHouse.Outputprice(this.money);
                                        Console.Write("Do You Want To Add Some Money To Your Budget? (Y/N): ");
                                        string addmoney = Console.ReadLine();
                                        if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                        {
                                            Console.Write("Amount Of Money You Want To Add: ");
                                            int moneyadded = int.Parse(Console.ReadLine());
                                            this.money += moneyadded;
                                            if(this.money < 10000000)
                                            do
                                            {
                                                Console.WriteLine("Your Budget STILL Can't Affort This Segment! Please Add Some More Or I'll Kick You Out!  (¬_¬ )");
                                                Console.Write("Your Current Budget: ");
                                                WareHouse.Outputprice(this.money);
                                                Console.Write("DO YOU WANT TO ADD SOME MONEY TO YOUR BUDGET!!!? (Y/N): ");
                                                addmoney = Console.ReadLine();
                                                if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                                {
                                                    Console.Write("Amount Of Money You Want To Add: ");
                                                    moneyadded = int.Parse(Console.ReadLine());
                                                    this.money += moneyadded;
                                                }
                                                else
                                                {
                                                    kick = 1;
                                                    break;
                                                } 
                                                    
                                            } while (this.money < 10000000);
                                            else
                                            {
                                                #region Dùng bảng Mã Ascii để tạo hình trái tim 
                                                for (int i = 0; i < 60; i++)
                                                {
                                                    Console.Write(heart + " ");
                                                }
                                                #endregion
                                            }

                                        }
                                        else
                                        {
                                            kick = 1;
                                            break;
                                        }

                                    }
                                    #endregion
                                    #region xử lý in thông tin  pc tầm trung (10-20tr)
                                    Console.Clear();
                                    for (int i = 0; i < WareHouse.countpc; i++)
                                    {
                                        if (Info[i].Price >= 10000000 && Info[i].Price <= 20000000)
                                        {
                                            Info[i].OutputPC();
                                            PC pc = (PC)Detail[i];
                                            pc.output();
                                        }
                                    }
                                    #endregion
                                    back = 0;
                                    break;
                                case 3:                 //Chọn mua sản phẩm pc cao cấp ( < 20tr)
                                    #region Check số tiền so với segment cao cấp đã chọn
                                    if (this.money < 20000000)
                                    {
                                        Console.WriteLine("Your Budget Can't Affort This Segment!");
                                        Console.Write("Your Current Budget: ");
                                        WareHouse.Outputprice(this.money);
                                        Console.Write("Do You Want To Add Some Money To Your Budget? (Y/N): ");
                                        string addmoney = Console.ReadLine();
                                        if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                        {
                                            Console.Write("Amount Of Money You Want To Add: ");
                                            int moneyadded = int.Parse(Console.ReadLine());
                                            this.money += moneyadded;
                                            if (this.money <= 20000000)
                                                do
                                                {
                                                    Console.WriteLine("Your Budget STILL Can't Affort This Segment! Please Add Some More Or I'll Kick You Out!  (¬_¬ )");
                                                    Console.Write("Your Current Budget: ");
                                                    WareHouse.Outputprice(this.money);
                                                    Console.Write("DO YOU WANT TO ADD SOME MONEY TO YOUR BUDGET!!!? (Y/N): ");
                                                    addmoney = Console.ReadLine();
                                                    if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                                    {
                                                        Console.Write("Amount Of Money You Want To Add: ");
                                                        moneyadded = int.Parse(Console.ReadLine());
                                                        this.money += moneyadded;
                                                    }
                                                    else
                                                    {
                                                        kick = 1;
                                                        break;
                                                    }

                                                } while (this.money <= 20000000);
                                            else
                                            {
                                                #region Dùng bảng Mã Ascii để tạo hình trái tim 
                                                /*byte keycode = 3;
                                                char heart = (char)(keycode);*/
                                                for (int i = 0; i < 60; i++)
                                                {
                                                    Console.Write(heart + " ");
                                                }
                                                #endregion
                                            }

                                        }
                                        else
                                        {
                                            kick = 1;
                                            break;
                                        }                                    }
                                    #endregion
                                    #region xử lý in thông tin pc cao cấp ( < 20 tr )
                                    Console.Clear();

                                    for (int i = 0; i < WareHouse.countpc; i++)
                                    {
                                        if (Info[i].Price > 20000000)                                        
                                        {
                                            Info[i].OutputPC();
                                            PC pc = (PC)Detail[i];
                                            pc.output();
                                        }
                                    }
                                    #endregion
                                    back = 0;
                                    break;
                                default:                //Trở lại menu chọn mua pc/ laptop
                                    #region xử lý back trở lại menu
                                    {
                                        Console.Clear();
                                        this.output();
                                        back = 1;
                                        break;
                                    }
                                    #endregion
                                    break;              //Không ảnh hưởng code. để cho đồng đều
                            }
                            #endregion

                            #region xử lý chọn mua pc (nhập mã product)
                            int productpos = new int();
                            if (back == 0 && kick != 1)
                            {
                                string buyID;
                                Console.WriteLine("=========================================  Which PC You Wanna Buy?  ================================================");
                                Console.Write("PC's ID You Want To Buy: ");
                                buyID = Console.ReadLine();

                                Console.Clear();
                                Console.WriteLine("=========================================  Which PC You Wanna Buy?  ================================================");
                                Console.WriteLine("PC's ID You Want To Buy: " + buyID);

                                #region Dùng bảng Mã Ascii để tạo hình trái tim 
                                for (int i = 0; i < 60; i++)
                                {
                                    Console.Write(heart + " ");
                                }
                                #endregion

                                for (int i = 0; i < WareHouse.countpc; i++)
                                {
                                    if (buyID == Info[i].ProductID)
                                    {
                                        Info[i].OutputPC();
                                        PC pc = (PC)Detail[i];
                                        pc.output();
                                        productpos = i;             //Use For Order Bill And Remove From The WareHouse
                                                                    //break;
                                    }
                                }
                            }
                            else break;    
                            Console.WriteLine();
                            #endregion

                            #region xử lý phá vòng lặp để xuất hóa đơn
                            if (back == 0 && kick != 1)
                            {
                                //gọi hóa đơn
                                Bill bill = new Bill(this.name, this.phone, this.money, Info, productpos);
                                bill.BillOut();
                                break;          //Break Do while print menu
                            }
                            else break;                                
                            #endregion

                        } while (choice1 <= 3);
                        break;
                    #endregion

                    #region xử lý lựa chọn mua laptop
                    case 2:                         //Chọn mua laptop
                        do
                        {
                            #region kick khách hàng không làm mà đòi có ăn (nếu chọn segment cao hơn với budget mà ko chịu thêm tiền )
                            if (kick == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Security!!!!! (¬_¬ ) (¬_¬ ) (¬_¬ ) ");
                                Console.WriteLine("*KICKED");
                                Console.WriteLine("You Died");
                                break;
                            }
                            #endregion

                            #region xử lý menu giá tiền laptop
                            Console.WriteLine("==========================      Please Chose Segment That Suits Your Budget The Most      ==============================");
                            Console.WriteLine("1:  5.000.000 - 10.000.000 VND");
                            Console.WriteLine("2: 10.000.000 - 20.000.000 VND");
                            Console.WriteLine("3:            > 20.000.000 VND");
                            Console.WriteLine("4: Back to menu");
                            Console.Write("Your Choice: ");
                            choice1 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            #region Dùng bảng Mã Ascii để tạo hình trái tim 
                            byte keycode = 3;
                            char heart = (char)(keycode);
                            for (int i = 0; i < 60; i++)
                            {
                                Console.Write(heart + " ");
                            }
                            #endregion

                            #endregion

                            #region xử lý lựa chọn phân khúc laptop
                            switch (choice1)
                            {
                                case 1:             //chọn sản phẩm laptop dưới 10tr
                                    #region check số tiền so với segment phổ thông đã chọn
                                    // ko thêm code cho case này vì đã có hàm input đảm bảo số tiền luôn lớn hơn 5tr 
                                    #endregion
                                    #region xử lý in thông tin laptop dưới 10tr
                                    Console.Clear();
                                    for (int i = WareHouse.total - WareHouse.countlap; i < WareHouse.total; i++)
                                    {
                                        if (Info[i].Price < 10000000)
                                        {
                                            Info[i].OutputLaptop();
                                            Laptop lap = (Laptop)Detail[i];
                                            lap.output();
                                        }
                                    }
                                    #endregion
                                    back = 0;
                                    break;
                                case 2:                 //Chọn mua sản phẩm laptop tầm trung (10tr - 20tr)
                                    #region Check số tiền so với segment tầm trung đã chọn
                                    if (this.money < 10000000)
                                    {
                                        Console.WriteLine("Your Budget Can't Affort This Segment!");
                                        Console.Write("Your Current Budget: ");
                                        WareHouse.Outputprice(this.money);
                                        Console.Write("Do You Want To Add Some Money To Your Budget? (Y/N): ");
                                        string addmoney = Console.ReadLine();
                                        if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                        {
                                            Console.Write("Amount Of Money You Want To Add: ");
                                            int moneyadded = int.Parse(Console.ReadLine());
                                            this.money += moneyadded;
                                            if (this.money < 10000000)
                                                do
                                                {
                                                    Console.WriteLine("Your Budget STILL Can't Affort This Segment! Please Add Some More Or I'll Kick You Out!  (¬_¬ )");
                                                    Console.Write("Your Current Budget: ");
                                                    WareHouse.Outputprice(this.money);
                                                    Console.Write("DO YOU WANT TO ADD SOME MONEY TO YOUR BUDGET!!!? (Y/N): ");
                                                    addmoney = Console.ReadLine();
                                                    if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                                    {
                                                        Console.Write("Amount Of Money You Want To Add: ");
                                                        moneyadded = int.Parse(Console.ReadLine());
                                                        this.money += moneyadded;
                                                    }
                                                    else
                                                    {

                                                        kick = 1;
                                                        break;
                                                    }

                                                } while (this.money < 10000000);
                                            else
                                            {
                                                #region Dùng bảng Mã Ascii để tạo hình trái tim 

                                                for (int i = 0; i < 60; i++)
                                                {
                                                    Console.Write(heart + " ");
                                                }
                                                #endregion
                                            }

                                        }
                                        else
                                        {
                                            kick = 1;
                                            break;
                                        }
                                        
                                    }
                                    #endregion
                                    #region xử lý in thông tin laptop tầm trung (10-20tr)
                                    Console.Clear();
                                    for (int i = WareHouse.total - WareHouse.countlap; i < WareHouse.total; i++)
                                    {
                                        if (Info[i].Price >= 10000000 && Info[i].Price <= 20000000)
                                        {
                                            Info[i].OutputLaptop();
                                            Laptop lap = (Laptop)Detail[i];
                                            lap.output();
                                        }
                                    }
                                    #endregion
                                    back = 0;
                                    break;
                                case 3:                 //Chọn mua sản phẩm laptop cao cấp ( < 20tr)
                                    #region Check số tiền so với segment cao cấp đã chọn
                                    if (this.money < 20000000)
                                    {
                                        Console.WriteLine("Your Budget Can't Affort This Segment!");
                                        Console.Write("Your Current Budget: ");
                                        WareHouse.Outputprice(this.money);
                                        Console.Write("Do You Want To Add Some Money To Your Budget? (Y/N): ");
                                        string addmoney = Console.ReadLine();
                                        if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                        {
                                            Console.Write("Amount Of Money You Want To Add: ");
                                            int moneyadded = int.Parse(Console.ReadLine());
                                            this.money += moneyadded;
                                            if (this.money <= 20000000)
                                                do
                                                {
                                                    Console.WriteLine("Your Budget STILL Can't Affort This Segment! Please Add Some More Or I'll Kick You Out!  (¬_¬ )");
                                                    Console.Write("Your Current Budget: ");
                                                    WareHouse.Outputprice(this.money);
                                                    Console.Write("DO YOU WANT TO ADD SOME MONEY TO YOUR BUDGET!!!? (Y/N): ");
                                                    addmoney = Console.ReadLine();
                                                    if (addmoney.IndexOf("Y") != -1 || addmoney.IndexOf("y") != -1)
                                                    {
                                                        Console.Write("Amount Of Money You Want To Add: ");
                                                        moneyadded = int.Parse(Console.ReadLine());
                                                        this.money += moneyadded;
                                                    }
                                                    else
                                                    {
                                                        kick = 1;
                                                        break;
                                                    }

                                                } while (this.money <= 20000000);
                                            else
                                            {
                                                #region Dùng bảng Mã Ascii để tạo hình trái tim 
                                                for (int i = 0; i < 60; i++)
                                                {
                                                    Console.Write(heart + " ");
                                                }
                                                #endregion
                                            }

                                        }
                                        else
                                        {
                                            kick = 1;
                                            break;
                                        }
                                    }
                                    #endregion
                                    #region xử lý in thông tin laptop cao cấp ( < 20tr)
                                    Console.Clear();
                                    for (int i = WareHouse.total - WareHouse.countlap; i < WareHouse.total; i++)
                                    {
                                        if (Info[i].Price > 20000000)
                                        {
                                            Info[i].OutputLaptop();
                                            Laptop lap = (Laptop)Detail[i];
                                            lap.output();
                                        }
                                    }
                                    #endregion
                                    back = 0;
                                    break;
                                default:                //Trở lại menu chọn mua pc/ laptop
                                    #region xử lý back trở lại menu
                                    {
                                        Console.Clear();
                                        this.output();
                                        break;
                                    }
                                    #endregion
                                    break;              //Không ảnh hưởng code. để cho đồng đều
                            }
                            #endregion

                            #region xử lý chọn mua laptop (nhập mã product)
                            int productpos = new int();
                            if(back == 0 )
                            {
                                string buyID;
                                Console.WriteLine("=========================================  Which Lap You Wanna Buy?  ================================================");
                                Console.Write("Laptop's ID You Want To Buy: ");
                                buyID = Console.ReadLine();

                                Console.Clear();
                                Console.WriteLine("=========================================  Which Lap You Wanna Buy?  ================================================");
                                Console.WriteLine("Laptop's ID You Want To Buy: " + buyID);

                                #region Dùng bảng Mã Ascii để tạo hình trái tim 
                                for (int i = 0; i < 60; i++)
                                {
                                    Console.Write(heart + " ");
                                }
                                #endregion
                                for (int i = WareHouse.total - WareHouse.countlap; i < WareHouse.total; i++)
                                {
                                    if (buyID == Info[i].ProductID)
                                    {
                                        Info[i].OutputLaptop();
                                        Laptop lap = (Laptop)Detail[i];
                                        lap.output();
                                        productpos = i;             //Use For Order Bill And Remove From The WareHouse
                                                                    //break;
                                    }
                                }
                            }    
                            Console.WriteLine();    
                            #endregion

                            #region xử lý phá vòng lặp để xuất hóa đơn
                            if (back == 0 && kick != 1)
                            {
                                //gọi hóa đơn
                                Bill bill = new Bill(this.name, this.phone, this.money, Info, productpos);
                                bill.BillOut();
                                break;          //Break Do while print menu
                            }
                            #endregion

                        } while (choice1 <= 3);
                        break;
                    #endregion

                    #region xử lý rời của hàng
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Have A Good Day!");
                            Console.WriteLine("We're Selling Your Info To The Black Market! ( >.< ) ");
                            Console.WriteLine("Thank You For Visiting Our Store! Please Come Again Another Time!");
                            break;
                        }
                    #endregion

                }

                #region xử lý phá vòng lặp để xuất hóa đơn

                #region Phá vòng lập ngay và kick khách hàng không làm mà đòi có ăn (nếu chọn segment cao hơn với budget mà ko chịu thêm tiền )
                if (kick == 1)      //kick dùng để phá dòng loop tạo menu / laptop
                {
                    Console.Clear();
                    Console.WriteLine("Security!!!!! (¬_¬ ) (¬_¬ ) (¬_¬ ) ");
                    Console.WriteLine("*KICKED");
                    Console.WriteLine("You Died");
                    break;          //phá vòng lặp do while tạo menu pc/laptop
                }
                #endregion
                if (kick == 1 || back == 0) break;
                #endregion

            } while (choice <= 2);
            #endregion
        }
    }
}
       
    
