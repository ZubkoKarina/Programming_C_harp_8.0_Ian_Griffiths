using System;
using System.Data;

class Program_3_31{
    static void Main(string[] args){
        //
    }

    public class Bar{
        private static DateTime _firstUser;
        static Bar(){
            Console.WriteLine("Bar`s static constructor");
            _firstUser = DateTime.Now;
        }
    }
}

