using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwo
{
    public abstract class Generator
    {
        public bool HasPowerSource { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public bool HasStarted { get; set; }
        public bool _OilLevel { get; set; }
        public bool ReFillOil { get; set; }



        public virtual bool Start()
            // checking if the Generator HaspowerSource but not Started
        {
            if (HasPowerSource && !HasStarted)
            {
                HasStarted = true;
                return true;
            }
            else
                return false;
        }

        public abstract bool Stop();
        
         
            
    }
}
