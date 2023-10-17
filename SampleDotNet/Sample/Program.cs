/*
 * Copyright (C) 2023 AsteroMitH
 */
using System.Diagnostics;
using System.Net;

using Database;

namespace Sample
{
    public class SampleMain
    {
        private const string AdminIp = "12.34.56.78";
        private const string Password = "super secret password";

        private SampleMain()
        {
            // Empty
        }

        public static void Main(string[] args)
        {
            const string Url = "https://admin:password@some.host";

            // TODO Add more stuff here
            var ParsedAdminIp = IPAddress.Parse(AdminIp);
            Console.WriteLine("Hey there! We'll contact " + ParsedAdminIp);
            Console.WriteLine(Url);

            var p = new Process();
            p.StartInfo.FileName = "ping";

            if (args.Length == 2)
            {
                DBAccess.ExecuteRawSql(args[0], args[1]);
            }
            else if (args.Length == 1)
            {
                // TODO Sanitize argument
                p.StartInfo.ArgumentList.Add(args[0]);
            }
            else
            {
                p.StartInfo.ArgumentList.Add(AdminIp);
            }
            p.Start();
            p.WaitForExit();
        }
    }
}
