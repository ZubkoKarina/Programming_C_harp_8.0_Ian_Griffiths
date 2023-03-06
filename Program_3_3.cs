using System;

namespace classExample{
    public class Program3_3{
        public static void Main(string[] args){
            Console.WriteLine(Counter.TotalCount);
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
