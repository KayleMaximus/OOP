using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Store
{
    abstract class Technical_Details 
    {


        //Product's Details
        protected int vGACapacity;
        protected int RamCapacity;
        protected int DiskCapacity;
        protected string VGABrand;
        protected string CPUname;
        protected string RamGen;
        protected string Disktype;

        protected int VGACapacity
        {
            get => vGACapacity;
            set
            {
                if (value < 1 || value > 8)
                    throw new Exception($"{nameof(value) } Must Less Than 8 And Bigger Than 1!");
                vGACapacity = value;
            }
        }

        //Constructor For PC / Laptop
        public Technical_Details(string vgabrand, int vgacap, string cpuname, string ramgen, int ramcap, string disktype, int diskcap) 
        {
            this.RamGen         = ramgen;
            this.CPUname        = cpuname;
            this.Disktype       = disktype;
            this.VGABrand       = vgabrand;
            this.RamCapacity    = ramcap;
            this.VGACapacity    = vgacap;
            this.DiskCapacity   = diskcap;
        }

        //Constructor For Laptop (esspecially without Vram)
        public Technical_Details(string vgabrand, string cpuname, string ramgen, int ramcap, string disktype, int diskcap) 
        {
            this.RamGen         = ramgen;
            this.CPUname        = cpuname;
            this.Disktype       = disktype;
            this.VGABrand       = vgabrand;
            this.RamCapacity    = ramcap;
            this.DiskCapacity   = diskcap;
        }


        public abstract void output();
        
    }


}
