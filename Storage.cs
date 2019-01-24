using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public abstract class Storage
    {
        private string _name;
        private string _model;

        public double OccupiedMemoryVolume { get; set; }

        public abstract double GetMemoryVolume();
        public abstract bool CopyToDevice();
        public abstract double GetFreeMemoryVolume();
        public abstract string GetCommonInfo();
        public abstract string GetFullInfo();


        #region Getters And Setters
        public string GetName()
        {
            return _name;
        }
        public string GetModel()
        {
            return _model;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public void SetModel(string model)
        {
            _model = model;
        }
        #endregion
    }
}
