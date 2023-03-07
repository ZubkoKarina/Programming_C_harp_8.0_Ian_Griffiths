using System;

public class HasProperty{
    public int X {get; set;}
}

class Program_3_68{
    static void Main(string[] args){
        var o = new HasProperty();
        o.X = 234;
        o.X += 345;
        Console.WriteLine(o.X);
    }
}