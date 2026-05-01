using System; 

class URI {

    static void Main(string[] args) { 
        float r = float.Parse(Console.ReadLine());
        float a = 3.14159f * r * r;
        Console.WriteLine($"A={a:F4}");
    }
}