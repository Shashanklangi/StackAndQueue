﻿
namespace StackAndQueues
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue!!");
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.DisplayQueue();
        }
    }
}