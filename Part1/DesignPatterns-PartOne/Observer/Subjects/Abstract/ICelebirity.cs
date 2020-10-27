using System;
using System.Collections.Generic;
using System.Text;
using Observer.Observers.Abstract;

namespace Observer.Subjects.Abstract
{
    public interface ICelebirity
    {
        string FullName { get; }

        string Tweet { get; set; }

        void Notify(string tweet);

        void AddFollower(IFan fan);


        void RemoveFollower(IFan fan);
    }
}
