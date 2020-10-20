using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace domzad_19_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"D:\HomeWorkText\domzad 19-10-2020\domzad 19-10-2020\CLIENT2.txt";
            ArrayList data = new ArrayList();
            List<Client> clients  = new List<Client>();
            List<string> base_data = new List<string>();
            using (StreamReader sr = new StreamReader(writePath, System.Text.Encoding.Default))
            {
                string temp;
                while ((temp = sr.ReadLine()) != null)
                {
                    string full_text = temp;
                    data.Add(temp);
                }
                foreach (string d in data)
                {
                    string[] data_list = d.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < data_list.Length; j++)
                    {
                        base_data.Add(data_list[j]);
                    } 
                }
                int count = 0;
                for (int i = 0; i < base_data.Count / 3; i++)
                {
                    clients.Add(new Client("","",""));
                }
                for (int c = 0; c < clients.Count; c++)
                {
                    clients[c].id_input = base_data[count];
                    clients[c].serial_input = base_data[count + 1];
                    clients[c].name_input = base_data[count + 2];
                    count += 3;
                }    
            }
            for (int m = 0; m < clients.Count; m++)
            {
                Console.WriteLine($"ID--{clients[m].id_input};SERIAL NUMBER--{clients[m].serial_input};CLIENT`S NAME--{clients[m].name_input}");
            }
            Console.WriteLine("Kakogo clienta perezapisat?");
            int client_choose = int.Parse(Console.ReadLine());
            clients[client_choose - 1].id_input = Console.ReadLine();
            clients[client_choose - 1].serial_input = Console.ReadLine();
            clients[client_choose - 1].name_input = Console.ReadLine();
            for (int m = 0; m < clients.Count; m++)
            {
                Console.WriteLine($"ID--{clients[m].id_input};SERIAL NUMBER--{clients[m].serial_input};CLIENT`S NAME--{clients[m].name_input}");
            }
            Console.ReadKey();
        } 
    }
}
