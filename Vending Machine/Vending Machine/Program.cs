using System;
using System.Globalization;

// Intrebare :  De ce cand am lucrat cu double am avut erroare de scadere ? 
// La varianta :  [3, 3, 3.9] la <change> pe double imi dadea  0.090000 ... 
class Program
{
    private const int BillAccepted = 10;

    private const double Coins50 = 0.5;
    private const double Coins10 = 0.1;

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine();
            VendingMachine();
        }
    }

    public static void VendingMachine()
    {
        float[] nums = InputNumebers();

        float sumProducts = nums.Sum();

        var coverValue = CoverValue(sumProducts);
        
        if(coverValue < 0)
        {
            RestartProgram();
            return;
        }

        float maxBillInserted = coverValue * BillAccepted;

        do
        {
            Console.WriteLine(string.Format("Please insert {0} lei coin for {1} time :", BillAccepted, coverValue));
            Console.WriteLine("(Press any key to insert)");
            Console.ReadKey();
            coverValue--;
        }
        while (coverValue > 0);

        Console.WriteLine("Wait for your tips:");

        float change = maxBillInserted - sumProducts;

        int num50Coins = (int) (change / Coins50);

        int num10Coins = (int) ((change- (num50Coins * Coins50)) / Coins10); 

        Console.WriteLine(string.Format("{0:N2}", change) + string.Format(" lei in {0} on 50 coins and {1} in 10 coins", num50Coins, num10Coins));
    }

    private static float[] InputNumebers()
    {

        Console.WriteLine("Please add 3 products:");
        string console = Console.ReadLine();
        string[] tokens = console.Split(new char[] { ' ', ','});
        IList<float> nums = new List<float>();
        float oneNum;
        foreach (string s in tokens)
        {
            if (float.TryParse(s, out oneNum))
                nums.Add(oneNum);
        }
        return nums.ToArray();
    }

    private static int CoverValue(float sum)
    {
        float coverValue = sum / BillAccepted;
        return coverValue > 0 ? (int)coverValue + 1 : 0;
    }

    private static void RestartProgram()
    {
        Console.WriteLine("Error: Repeat");
        Console.WriteLine();
        InputNumebers();
    }
}
