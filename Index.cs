using System;
using System.Collections.Generic;
using System.Text;

namespace domzad_19_10_2020
{
        class Index
        {
            Client[] data;
            public Index()
            {
                data = new Client[99];
            }
            public Client this[int index]
            {
                get
                {
                    return data[index];
                }
                set
                {
                    data[index] = value;
                }
            }
        }
}
