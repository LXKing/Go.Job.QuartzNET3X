﻿using System;
using System.Threading;
using Go.Job.BaseJob;

namespace TestJob
{
    public class Job : BaseJob
    {
        public override void Run()
        {
            //string path1 = @"C:\Users\Administrator\Desktop\Job.txt";
            ////string path1 = @"C:\Users\gongwei.LONG\Desktop\Job.txt";
            //using (FileStream fs = new FileStream(path1, FileMode.Append, FileAccess.Write))
            //{
            //    byte[] bytes = Encoding.Default.GetBytes(DateTime.Now + Environment.NewLine);
            //    fs.Write(bytes, 0, bytes.Length);
            //}

            //string name = Thread.GetDomain().FriendlyName;
            //Tools.FileHelper.WriteString(name);

            //Thread.Sleep(10000);
            Console.WriteLine($"{DateTime.Now} : Job123 Run......");
        }
    }
}
