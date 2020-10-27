using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Singleton
{
    public class Policy
    {
        private static Policy _instance;

        public static Policy Instance
        {
            get
            {
                if (_instance == null)
                {
                   _instance=new Policy();
                    
                }

                return _instance;
            }
        }

        public Policy()
        {

        }

        private int Id { get; set; } = 123;


    }
}
