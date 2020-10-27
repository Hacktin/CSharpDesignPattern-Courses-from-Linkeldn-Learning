using System;
using System.Collections.Generic;
using System.Text;
using Observer.Observers.Abstract;
using Observer.Subjects.Abstract;

namespace Observer.Subjects.Concerete
{
    public class TSwift : ICelebirity
    {
        private string _tweet;



        private delegate void TweetUpdate(ICelebirity celebirity);

        private event TweetUpdate onTweetUpdate;

        public TSwift(string tweet)
        {
            this._tweet = tweet;
        }
        public string FullName => "Taylor Swift";

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
            onTweetUpdate += fan.Update;
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            if (onTweetUpdate != null)
            {
                onTweetUpdate(this);
            }
        }

        public void RemoveFollower(IFan fan)
        {
            onTweetUpdate -= fan.Update;
        }
    }
}
