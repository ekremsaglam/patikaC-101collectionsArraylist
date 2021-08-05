using System;
using System.Collections;
using System.Collections.Generic;

namespace collectionsArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste =new ArrayList();
            liste.Add("ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //verilere erişim
            Console.WriteLine(liste[0]);

            foreach(var item in liste){
                Console.WriteLine(item);
            }

            Console.WriteLine("*********Add Range********");
            int[] sayilar = {1,4,5,6,7,8,56,25,6,5,56,2,5,56,23,56,56,5,52};
            liste.AddRange(sayilar);
            foreach(var item in liste){
                Console.WriteLine(item);
            }
            List<string> renkler = new List<string>();
            renkler.Add("mavi");
            renkler.Add("turuncu");
            liste.AddRange(renkler);
            Console.WriteLine("*********Sort********");
            



        }
    }
}
