﻿using Client.HelloWorldServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldClient client = new HelloWorldClient("BasicHttpBinding_IHelloWorld");
            Name person = new Name();
            person.FirstName = "Julius";
            person.LastName = "Bacosa";
            Console.WriteLine(client.SayHello(person));
            Console.ReadLine();
        }
    }
}
