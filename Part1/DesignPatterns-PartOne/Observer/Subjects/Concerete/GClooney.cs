using System;
using System.Collections.Generic;
using System.Text;
using Observer.Observers.Abstract;
using Observer.Subjects.Abstract;

namespace Observer.Subjects.Concerete
{
    public class GClooney : ICelebirity
    {
        private readonly List<IFan> fans=new List<IFan>();

        private string _tweet;

        public GClooney(string tweet)
        {
            this._tweet = tweet;
        }

        public string FullName => "George GCloney";

        public string Tweet
        {
            get
            {
                return _tweet;
            }

            set
            {
                Notify(value);
            }
        }

        public void AddFollower(IFan fan)
        {
            fans.Add(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;

            foreach(var fan in fans)
            {
                fan.Update(this);
            }
        }

        public void RemoveFollower(IFan fan)
        {

            fans.Remove(fan);
        }
    }
}
