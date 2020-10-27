using System;
using Observer.Observers.Concerete;
using Observer.Subjects.Concerete;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan=new Fan();

            GClooney firstGClooney=new GClooney("I love your songs");
            TSwift secondGClooney=new TSwift("My wife loves your songs");


            firstGClooney.AddFollower(fan);
            secondGClooney.AddFollower(fan);

            firstGClooney.Tweet = "I love your songs very much!!!";
            secondGClooney.Tweet = "My wife and I love your songs";
        }
    }
}
