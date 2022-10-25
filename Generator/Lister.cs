using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwo
{
    public class Lister : Generator
    {
        public bool HasStarterEaten { get; set; }
        public override bool Equals(object obj)
        {
            if (HasStarterEaten)
            {return base.Start();}
            else
                { return false; }   
            
        }

        public override bool Stop()
        {
            if (HasStarted)
            {
                HasStarted = false;
                return true;
            }
            else
            {
                return false;
            }
        }

       
        
    }
}

