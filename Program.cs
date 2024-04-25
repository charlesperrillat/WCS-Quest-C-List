namespace _1_List;

class Program
{
    static void Main(string[] args)
    {
        List<string> stringCollection = new List<string>();

        stringCollection.Add("Hello");
        stringCollection.Add("Hi");
        stringCollection.Add("Bonjour");

        stringCollection.RemoveAt(0);
        stringCollection.Remove("Bonjour");
        stringCollection[0] = "Salut";

        for (int i = 0; i < stringCollection.Count; i++)
            Console.WriteLine(stringCollection[i]);
    }
}

