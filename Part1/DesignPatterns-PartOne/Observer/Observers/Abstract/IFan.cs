using System;
using System.Collections.Generic;
using System.Text;
using Observer.Subjects.Abstract;

namespace Observer.Observers.Abstract
{

    //Base Observer
    public interface IFan
    {
        void Update(ICelebirity celebirity);
    }
}
