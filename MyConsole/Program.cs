using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using HmacGenerator;

namespace MyConsole
{
    class Program
    {
        static string GetJson()
        {
            return "{\"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\", \"name\":\"Chaiwat Matarak\"}";
        }

        static void Main(string[] args)
        {
            Ex11();
        }

        static void Ex10(string plainTextData = "foobar")
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            var csp = new RSACryptoServiceProvider(2048);

            //how to get the private key
            var privKey = csp.ExportParameters(true);

            //and the public key ...
            var pubKey = csp.ExportParameters(false);

            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();

                File.WriteAllText("public.txt", pubKeyString);

                //==================
                xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, privKey);
                var privateKeyString = sw.ToString();

                File.WriteAllText("private.txt", privateKeyString);
            }

            //converting it back
            {
                //get a stream from the string
                var sr = new System.IO.StringReader(pubKeyString);
                //we need a deserializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //get the object back from the stream
                pubKey = (RSAParameters) xs.Deserialize(sr);
            }

            //conversion for the private key is no black magic either ... omitted

            //we have a public key ... let's get a new csp and load that key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(pubKey);

            //we need some data to encrypt
            // var plainTextData = "foobar";

            Console.WriteLine("Before PlainText = {0}", plainTextData);

            //for encryption, always handle bytes...
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

            //we might want a string representation of our cypher text... base64 will do
            var cypherText = Convert.ToBase64String(bytesCypherText);

            /*
             * some transmission / storage / retrieval
             * 
             * and we want to decrypt our cypherText
             */

            //first, get our bytes back from the base64 string ...
            bytesCypherText = Convert.FromBase64String(cypherText);

            //we want to decrypt, therefore we need a csp and load our private key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privKey);

            //decrypt and strip pkcs#1.5 padding
            bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

            //get our original plainText back...
            plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);

            Console.WriteLine("After CypherText = {0}", cypherText);
            Console.WriteLine("After PlainText = {0}", plainTextData);
        }

        static void Ex11(string json = "foobar")
        {
            string pubKeyString = File.ReadAllText("public1.xml");
            string privKeyString = File.ReadAllText("private1.xml");

            // ===========
            var xs = new XmlSerializer(typeof(RSAParameters));
            var pubKey = (RSAParameters) xs.Deserialize(new StringReader(pubKeyString));
            var privKey = (RSAParameters) xs.Deserialize(new StringReader(privKeyString));

            // ===========
            var mypub1 = File.ReadAllText("public1");
            var mypriv2 = File.ReadAllText("private2");
            var mypub2 = File.ReadAllText("public2");

            var csp = new RSACryptoServiceProvider();
            // pubKey = csp.ExportParameters(false);
            // pubKey.Modulus = Convert.FromBase64String(mypub2);
            csp.ImportParameters(pubKey);
            csp.ImportParameters(privKey);

            var jsonBytes = Encoding.Unicode.GetBytes(json);
            var jsonBytesEncrypted = csp.Encrypt(jsonBytes, false);
            var jsonBytesCypher = Convert.ToBase64String(jsonBytesEncrypted);

            // ===========
            jsonBytesEncrypted = Convert.FromBase64String(jsonBytesCypher);
            jsonBytes = csp.Decrypt(jsonBytesEncrypted, false);
            json = Encoding.Unicode.GetString(jsonBytes);

            Console.WriteLine("PlainText = {0}", json);
            Console.WriteLine("CypherText = {0}", jsonBytesCypher);
        }

        static void Ex01()
        {
            var text = GetJson();
            var generator = new Hmac512Generator();

            var result = generator.GetSignature(text);

            Console.WriteLine(result);
        }

        static void Ex02()
        {
            var secret = "8a64c35116e906b79d0763d0354b8a5e7ad31515c0774e8cb9a3e2034fc0219f";

            using(var rsa = new RSACryptoServiceProvider())
            {
                // rsa.PersistKeyInCsp = false;
                // var publicRsa = rsa.ExportParameters(false);

                // rsa.ImportParameters(publicRsa);

                var text = GetJson();
                var generator = new Hmac512Generator();

                var hashed = generator.GetSignature(text);

                Console.WriteLine(hashed);
            }
        }
    }
}