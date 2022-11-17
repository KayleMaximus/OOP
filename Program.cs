using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==================================  Welcome To Zeus's Gaming Computer Store!  ==========================================");
            WareHouse.input();
            Coustomer coustomer1 = new Coustomer();
            coustomer1.input();
            coustomer1.output();
            coustomer1.Opinion(WareHouse.InfoList, WareHouse.DetailList);



            //Lessons Learnt From This Project
            //Should Have Build More Functions Instead Of All In One (Maybe Due To Learning New Way Of Programming In A New Language
            //Shouldn't Put 1 Objects Into 2 list (Detail and Info)
            //Alway Console.Writeline(); everytime done info sth
            //List starts From 0
            //Always describe what the variables do when the are born








        }
    }
}
