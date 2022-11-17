using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    class PC : Technical_Details
    {
        private string Case;

        public PC(string vgabrand, int vgacap, string cpuname, string ramgen, int ramcap, string disktype, int diskcap, string CASE) : 
            base(vgabrand, vgacap, cpuname, ramgen, ramcap, disktype, diskcap)
        {
            this.Case = CASE;
            WareHouse.countpc++;
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
            Console.WriteLine("Case             : " + this.Case);
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
