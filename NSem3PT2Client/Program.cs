using System;
using NSem3PT2;

namespace NSem3PT2Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            if (!q)
            {
                q = q < new QueueNode(1);
                q = q < new QueueNode(2);
                q = q < new QueueNode(3);
                q = q < new QueueNode(4);
                q = q < new QueueNode(5);
                Console.WriteLine(q);
                QueueNode d = new QueueNode(0);
                q = q > d;
                Console.WriteLine(d);
                q = q > d;
                Console.WriteLine(d);
                q = q > d;
                Console.WriteLine(d);
                Console.WriteLine(q);
            }

            Queue q2 = new Queue(1, 2, 3, 5, 6, 7);
            Console.WriteLine(q2);
            if (q2)
            {
                QueueNode d = new QueueNode(0);
                q2 = q2 > d;
                q2 = q2 > d;
                Console.WriteLine(q2);
                q2 = q2 < new QueueNode(3);
                q2 = q2 < new QueueNode(4);
                q2 = q2 < new QueueNode(5);
                Console.WriteLine(q2);
                q2 = q2 > d;
                q2 = q2 > d;
                q2 = q2 > d;
                q2 = q2 > d;
                q2 = q2 > d;
                q2 = q2 > d;
                q2 = q2 > d;
                Console.WriteLine(q2);
            }


            q = q < new QueueNode(30);
            q = q < new QueueNode(40);
            q = q < new QueueNode(50);
            Console.WriteLine(q);
            double[] arr = (double[])q;
            QueueNode d2 = new QueueNode(0);
            q = q > d2 > d2;
            Console.WriteLine(q);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Queue q3 = arr;
            Console.WriteLine();
            Console.WriteLine(q3);
            q3[1] = 500;
            Console.WriteLine(q3);
            Console.WriteLine(q == q3);
        }
    }
}
