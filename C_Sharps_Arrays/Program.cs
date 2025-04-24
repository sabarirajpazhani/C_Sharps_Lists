using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
namespace C_Sharps_Arrays
{
    public class Program
    {
        public static void CreatingList()
        {
            List<int> l = new List<int>();
            l.Add(10);
            l.Add(20);
            l.Add(30);
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }

            List<object> obj = new List<object>();
            obj.Add("Sabari");
            obj.Add(1);
            obj.Add('c');
            obj.Add(null);
            foreach(var i in obj)
            {
                Console.WriteLine(i);
            }
        }

        public static void addRange()
        {
            int[] arr = new int[3] { 1, 2, 4 };
            List<int> l = new List<int>();
            l.Add(5);
            l.Add(4);
            l.AddRange(arr);

            l.ForEach(x => Console.WriteLine(x));
        }
        
        public static void retriving()
        {
            List<int> l = new List<int>() { 1, 2, 3, 4 };

            Console.WriteLine(l[3]);
        }
        public static void insertElement()
        {
            List<char> ch = new List<char>();
            ch.Add('d');
            ch.Add('e');
            ch.Add('r');
            ch.Add('t');

            ch.Insert(3, 's');
            ch.InsertRange(3, new[] { 'q', 'o', 'p', 'd' });
            ch.ForEach(x => Console.WriteLine(x));
        }

        public static void containsMethod()
        {
            List<char> ch = new List<char>();
            ch.Add('d');
            ch.Add('e');
            ch.Add('r');
            ch.Add('t');

            Console.WriteLine(ch.Contains('d'));
        }
        public static void removeElements()
        {
            List<int> l = new List<int>() { 1, 2, 3, 4 };
            l.Remove(2);
            l.RemoveAt(2);

            l.ForEach(x => Console.WriteLine(x));
        }
        static void Main(String [] args)
        {
            //CreatingList();
            //addRange();
            //retriving();
            //insertElement();
            //containsMethod();
            removeElements();



        }
    }
}