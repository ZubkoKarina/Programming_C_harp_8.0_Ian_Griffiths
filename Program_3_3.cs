using System;

namespace classExample{
    public class Program3_3{
        public static void Main(string[] args){
            Console.WriteLine(Counter.TotalCount);
            Counter c1 = new Counter();
            var c2 = c1;
            Console.WriteLine("c1: " + c1.GetNextValue());
        }

        public class Counter{
            private int _count;
            private static int _totalCount;

            public int GetNextValue(){
                this._count +=1;
                _totalCount +=1;
                return _count;
            }
            public static int TotalCount => _totalCount;
        }
    }
}
