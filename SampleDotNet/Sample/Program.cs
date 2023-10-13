/*
 * Copyright (C) 2023 AsteroMitH
 */
using System.Diagnostics;

namespace Sample
{
    public class SampleMain
    {
        private const string IpAddress = "12.34.56.78";
        private const string Password = "super secret password";

        private SampleMain()
        {
            // Empty
        }

        public static void Main(string[] args)
        {
            // TODO Add more stuff here
            Console.WriteLine("Hey there! We'll contact " + IpAddress);

            if (args.Length == 1)
            {
                var p = new Process();
                p.StartInfo.FileName = "/usr/bin/find";
                p.StartInfo.ArgumentList.Add(args[0]);
                p.StartInfo.ArgumentList.Add(Password);
                p.Start();
                p.WaitForExit();
            }
        }
    }
}
