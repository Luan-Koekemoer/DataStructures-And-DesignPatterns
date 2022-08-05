using libDesignPatterns;
using libDataStructures;

class Program{
    static void Main(string[] args){
        System.Console.WriteLine("Hello world");
        SmartQueue<string> sq = new SmartQueue<string>();


        System.Console.WriteLine(sq.IsEmpty());
        sq.Enqueue("hi", 1);
        sq.Enqueue("benson", 10);
  
        string s = sq.Peek();

        System.Console.WriteLine(sq.Peek());
        System.Console.WriteLine(s);
        

        SmartQueue<int> sq2 = new SmartQueue<int>();
        sq2.Enqueue(2);

        int i = sq2.Peek();
        sq.Enqueue("charne", 4);
        sq.Enqueue("i", 10);
        sq.Enqueue("miss", 1);
        sq.Enqueue("you");


        // string s = sq.Dequeue();

        foreach (var item in sq)
        {
            Console.WriteLine(item);
        }
        // Console.WriteLine(s);

        // while (!sq.IsEmpty())
        // {
        //     Console.Write(sq.Dequeue() + " ");
        // }
        // Console.WriteLine();

    }
}