using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public class DVD : Storage
    {
        public double WriteSpeed { get; set; }
        public double ReadSpeed { get; set; }
        public string Type { get; set; }
        private const double oneSidedTypeMemory = 4.7;
        private const double twoSidedTypeMemory = 9;

        public override string GetCommonInfo()
        {
            return $"{GetName()}, {GetModel()}";
        }

        public override string GetFullInfo()
        {
            return $"{GetName()}, {GetModel()}, {WriteSpeed}, {ReadSpeed}, {Type}";
        }

        public override bool CopyToDevice()
        {
            return true;
        }

        public override double GetFreeMemoryVolume()
        {
            if (Type == "Односторонний")
            {
                return oneSidedTypeMemory - OccupiedMemoryVolume;
            }
            else
            {
                return twoSidedTypeMemory - OccupiedMemoryVolume;
            }
        }

        public override double GetMemoryVolume()
        {
            if (Type == "Односторонний")
            {
                return oneSidedTypeMemory;
            }
            else
            {
                return twoSidedTypeMemory;
            }
        }
    }
}
