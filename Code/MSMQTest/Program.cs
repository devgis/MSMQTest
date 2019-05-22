using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSMQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMessageQueue queue = new MyMessageQueue();
            string qpath = "FormatName:Direct=TCP:192.168.0.102//private$//corp"; //".//Private$//myQueue2"
            qpath = ".\\private$\\corp";
            queue.Createqueue(qpath);
            queue.SendMessage();
            queue.GetAllMessage();
            queue.ReceiveMessage();
            //queue.ClealMessage();
            Console.Read();
        }
    }
}
