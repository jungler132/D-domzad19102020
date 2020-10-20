using System;
using System.Collections.Generic;
using System.Text;

namespace domzad_19_10_2020
{
    class Client
    {
        public string id_input;
        public string serial_input;
        public string name_input;
        public Client(string id_input, string serial_input, string name_input)
        {
            this.id_input = id_input;
            this.serial_input = serial_input;
            this.name_input = name_input;
        }
    }
}
