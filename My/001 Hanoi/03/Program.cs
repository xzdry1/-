﻿using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string X="A";
            string Y="B";
            string Z="C";
            Hanoi h=new Hanoi();
            long result=h.Process(4,X,Y,Z);
            System.Console.WriteLine(result);
        }
    }

    class Hanoi{
        private int count;

        public long Process(int n,string X,string Y,string Z){
            if(n==1){
                count++;
                System.Console.WriteLine("{0} {1}->{2}",count,X,Z);
            }else{
                Process(n-1,X,Z,Y);
                count++;
                System.Console.WriteLine("{0} {1}->{2}",count,X,Z);
                Process(n-1,Y,X,Z);
            }
            return count;
        }
    }
}
