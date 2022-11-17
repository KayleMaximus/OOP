using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    class Laptop : Technical_Details
    {
        private double Screen;

        //Laptop With Vram
        public Laptop (string vgabrand, int vgacap, string cpuname, string ramgen, int ramcap, string disktype, int diskcap, double screen) : 
               base(vgabrand, vgacap, cpuname, ramgen, ramcap, disktype, diskcap)
        {
            this.Screen = screen;
            WareHouse.countlap++;
        }

        public Laptop(string vgabrand, string cpuname, string ramgen, int ramcap, string disktype, int diskcap, double screen) :
               base(vgabrand, cpuname, ramgen, ramcap, disktype, diskcap)
        {
            this.Screen = screen;
            WareHouse.countlap++;
        }

        public override void output()
        {
            //base.output();
            Console.WriteLine("CPU              : " + this.CPUname);
            Console.WriteLine("VGA's Name       : " + this.VGABrand);
            Console.WriteLine("VGA's Capacity   : " + this.VGACapacity + " GB");
            Console.WriteLine("Ram's Generation : " + this.RamGen);
            Console.WriteLine("Ram's Capacity   : " + this.RamCapacity + " GB");
            Console.WriteLine("Disk             : {0} ,{1} GB", this.Disktype, this.DiskCapacity);
            Console.WriteLine("Screen           : " + this.Screen + " Inch");
            Bill bill = new Bill();
            bill.BillOut();
            #region Dùng bảng Mã Ascii để tạo hình trái tim 
            byte keycode = 3;
            char heart = (char)(keycode);
            for (int i = 0; i < 60; i++)
            {
                Console.Write(heart + " ");
            }
            #endregion
        }

    }
}
