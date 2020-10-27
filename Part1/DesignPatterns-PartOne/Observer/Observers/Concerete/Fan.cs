using System;
using System.Collections.Generic;
using System.Text;
using Observer.Observers.Abstract;
using Observer.Subjects.Abstract;

namespace Observer.Observers.Concerete
{

    //Concerete Observer
    public class Fan : IFan
    {
        public void Update(ICelebirity celebirity)
        {
           Console.WriteLine($"Fan notified.Tweet of {celebirity.FullName}:{celebirity.Tweet}");
        }
    }
}
