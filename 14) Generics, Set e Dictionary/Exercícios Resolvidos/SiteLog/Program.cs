using System;
using System.IO;
using System.Collections.Generic;
using SiteLog.Entities;

namespace SiteLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            HashSet<LogRecord> logs = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vectLine = sr.ReadLine().Split(' ');
                        string userName = vectLine[0];
                        DateTime instant = DateTime.Parse(vectLine[1]);
                        LogRecord log = new LogRecord(userName, instant);
                        logs.Add(new LogRecord(userName, instant));
                    }
                }

                Console.WriteLine("Total users: " + logs.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
