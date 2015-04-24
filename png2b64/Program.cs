using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace png2b64
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("Wrong args");
            }
            string b64 = ToB64(args[0]);

            if (args.Length > 1)
            {
                StreamWriter file = new StreamWriter(args[1]);
                file.WriteLine(b64);
                file.Close();
            }
            else
            {
                Console.Out.WriteLine(b64);
            }
        }

        static public string ToB64(string path)
        {
            return Convert.ToBase64String(File.ReadAllBytes(path));
        }

    }
}
