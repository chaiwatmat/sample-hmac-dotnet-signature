using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var secret = "8a64c35116e906b79d0763d0354b8a5e7ad31515c0774e8cb9a3e2034fc0219f";
            var text = "[{\"id\":\"10000\"},{\"id\":\"10001\"}]";

            var key = Enumerable.Range(0, secret.Length)
                     .Where(x => x % 2 == 0)
                     .ToList()
                     .Select(x => Convert.ToByte(secret.Substring(x, 2), 16))
                     .ToArray();

            var bytes = Encoding.UTF8.GetBytes(text);

            var hmac = new HMACSHA512(key);
            var computedHash = hmac.ComputeHash(bytes);

            var bitConverted = BitConverter.ToString(computedHash).Replace("-", "").ToLower();

            Console.WriteLine(bitConverted);
        }
    }
}
