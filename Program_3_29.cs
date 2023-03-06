using System;

class Program_3_29{
    static void Main(string[] args){
        ItemWithId my_date = new ItemWithId("karina", 22);
        Console.WriteLine(my_date.GetName());
    }

    public class ItemWithId{
        private static int _lastId;
        private int _id;
        private string _name;

        public ItemWithId():this(null){
        }

        public ItemWithId(string name):this(name, ++_lastId) {
        }

        public ItemWithId(string name, int id){
            _name = name;
            _id = id;
        }

        public string GetName(){
            return _name;
        }
    }
}