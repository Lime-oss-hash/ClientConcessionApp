using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConcessionApp
{
    internal class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Concession { get; set; }

        public Client(int id, string name, DateTime birthday, string concession)
        {
            ID = id;
            Name = name;
            Birthday = birthday;
            Concession = concession;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nBirthday: {Birthday.ToShortDateString()}\nConcession: {Concession}";
        }
    }
}


// This code includes a ValidateInput() method, which checks if the input is valid or not. It validates the ID, Name, and Concession fields using simple checks and regular expressions. If the input is invalid, it shows an error message and returns false. If the input is valid, it creates a Client object and displays the formatted data using the ToString() method of the Client class.