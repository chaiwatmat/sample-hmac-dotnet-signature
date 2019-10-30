using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using HmacGenerator;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "[{\"id\":\"10000\"},{\"id\":\"10001\"}]";
            var generator = new Hmac512Generator();

            var result = generator.GetSignature(text);

            Console.WriteLine(result);
        }
    }
}
