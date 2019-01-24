using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    class Program
    {
        private static Flash flashMemory = new Flash();
        private static DVD DVDDisk = new DVD();
        private static HDD removableHDD = new HDD();
        private Storage[] devices = new Storage[] { flashMemory, DVDDisk, removableHDD};

        public double GetMemory()
        {
            double memory = 0;
            for (int i = 0; i < devices.Length; i++)
            {
                memory += devices[i].GetMemoryVolume();
            }
            return memory;
        }

        public bool CopyTo()
        {
            return true;
        }

        public double CopyTime()
        {
            double time = 0;
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i] is Flash)
                {
                    time += (devices[i] as Flash).Speed;
                }
                if (devices[i] is HDD)
                {
                    time += (devices[i] as HDD).Speed;
                }
                else
                {
                    time += (devices[i] as DVD).WriteSpeed;
                }
            }
            return time;
        }

        public int DevicesAmount(double memory)
        {
            int devicesAmount = 0;
            int q = 0;
            for (double i = memory; i > 0; q++)
            {
                i /= devices[q].GetMemoryVolume();
                devicesAmount++;
            }
            return devicesAmount * 3;
        }

        static void Main(string[] args)
        {

        }
    }
}
