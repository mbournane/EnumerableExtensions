using System.Linq;
namespace EnumerableExtensions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Veuillez saisir un entier: ");
        int nb = Int32.Parse(Console.ReadLine());
        int[] intTab = new int[nb];

        for(int i = 0; i<= nb - 1;i++)
        {
            intTab[i] = i;
        }

        int sum = intTab.Aggregate((x, y) => x + y);

        foreach(int n in intTab)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine("La mayenne: " + sum/nb);

    }
}
