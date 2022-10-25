using System;

namespace WeekTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lister lister196 = new Lister();
            lister196.Name = "Lister196";
            lister196.HasPowerSource = false;
            lister196.Rating = 12;
            lister196.HasStarterEaten =false;
            bool hasStarted = lister196.Start();

            if (hasStarted)
            {
                Console.WriteLine(lister196.Name + " is running ...");
            }
            else
                Console.WriteLine(lister196.Name + " is failed to start.");
           

        }
    }
}
