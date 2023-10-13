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

            var p = new Process();
            p.StartInfo.FileName = "ping";

            if (args.Length == 1)
            {
                // TODO Sanitize argument
                p.StartInfo.ArgumentList.Add(args[0]);
            }
            else
            {
                p.StartInfo.ArgumentList.Add(IpAddress);
            }
            p.Start();
            p.WaitForExit();
        }
    }
}
