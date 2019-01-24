using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public class Flash : Storage
    {
        public double Speed { get; set; }
        public double MemoryVolume { get; set; }


        public override string GetCommonInfo()
        {
            return $"{GetName()}, {GetModel()}";
        }

        public override string GetFullInfo()
        {
            return $"{GetName()}, {GetModel()}, {Speed}, {Speed}, {MemoryVolume}";
        }

        public override bool CopyToDevice()
        {
            return true;
        }

        public override double GetFreeMemoryVolume()
        {
            return MemoryVolume - OccupiedMemoryVolume;
        }

        public override double GetMemoryVolume()
        {
            return MemoryVolume;
        }
    }
}
