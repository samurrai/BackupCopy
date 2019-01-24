using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public class HDD : Storage
    {
        public double Speed { get; set; }
        public int SectionsAmount { get; set; }
        public double SectionsVolume { get; set; }

        public override string GetCommonInfo()
        {
            return $"{GetName()}, {GetModel()}";
        }

        public override string GetFullInfo()
        {
            return $"{GetName()}, {GetModel()}, {Speed}, {SectionsAmount}, {SectionsVolume}";
        }

        public override bool CopyToDevice()
        {
            return true;
        }

        public override double GetFreeMemoryVolume()
        {
            return SectionsVolume * SectionsAmount - OccupiedMemoryVolume;
        }

        public override double GetMemoryVolume()
        {
            return SectionsVolume * SectionsAmount;
        }
    }
}
