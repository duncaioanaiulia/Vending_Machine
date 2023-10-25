using System;
using System.Globalization;

class Program
{
    private static int billAccepted = 10;

    public static void Main()
    {
        var nums = InputNumebers();

        int sum = nums.Sum();

        var coverValue = CoverValue(sum);
        
        if(coverValue == 0)
        {
            Console.WriteLine("Error: Please contact admin");
            return;
        }

        do
        {
            Console.WriteLine(string.Format("Please insert {0} lei coin for {1} time :", billAccepted, coverValue));
            Console.WriteLine("(Press any key for insert)");
            Console.ReadKey();
            coverValue--;
        }
        while (coverValue > 0);


        Console.WriteLine(nums);
    }

    private static int[] InputNumebers()
    {
        Console.WriteLine("Please add 3 products:");
        string console = Console.ReadLine();
        string[] tokens = console.Split(" ");
        IList<int> nums = new List<int>();
        int oneNum;
        foreach (string s in tokens)
        {
            if (Int32.TryParse(s, out oneNum))
                nums.Add(oneNum);
        }
        return nums.ToArray();
    }

    private static int CoverValue(int sum)
    {
        int coverValue = sum / billAccepted;
        return coverValue > 0 ? coverValue + 1 : 0;
    }

    private bool IsCorrectBill(int value) => value == 10;
}
