internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is the first line.");
        string bob = "bob";
        int three = 3;
        float threePoint = 34.4f;
        string res = $"Hello, {bob}! You have {three} in your inbox. The temperature is {threePoint} celsius.";
        Console.WriteLine(res);
        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.WriteLine("View English output:");
        Console.WriteLine($@"  c:\Exercise\{projectName}\data.txt");

        Console.WriteLine($"{russianMessage}");
        Console.WriteLine($@"  c:\Exercise\{projectName}\ru-RU\data.txt");

        Console.WriteLine((94m - 32m) * 5m / 9m);

        IDictionary<string, int> dict = new Dictionary<string, int>() {
    {"Sophia", 0 },
    {"Nicolas", 0 },
    {"Zahirah", 0 },
    {"Jeong", 0 },
};

        dict["Sophia"] += 93;
        dict["Sophia"] += 87;
        dict["Sophia"] += 98;
        dict["Sophia"] += 95;
        dict["Sophia"] += 100;

        dict["Nicolas"] += 80;
        dict["Nicolas"] += 83;
        dict["Nicolas"] += 82;
        dict["Nicolas"] += 88;
        dict["Nicolas"] += 85;

        dict["Zahirah"] += 84;
        dict["Zahirah"] += 96;
        dict["Zahirah"] += 73;
        dict["Zahirah"] += 85;
        dict["Zahirah"] += 79;

        dict["Jeong"] += 90;
        dict["Jeong"] += 92;
        dict["Jeong"] += 98;
        dict["Jeong"] += 100;
        dict["Jeong"] += 97;

        Console.WriteLine($"Student     Grade       Average");
        foreach (string key in dict.Keys)
        {
            Console.WriteLine($"{key}       {dict[key]}     {(decimal)dict[key] / 5}");
        }


        IDictionary<string, IDictionary<string, List<int>>> Report = new Dictionary<string, IDictionary<string, List<int>>>();

        Report["Sophia Johnson"] = new Dictionary<string, List<int>>()
{
    { "English 101       ", new List<int>(){4, 3} },
    { "Algebra 101       ", new List<int>(){3, 3} },
    { "Biology 101       ", new List<int>(){3, 4} },
    { "Computer Science I", new List<int>(){3, 4} },
    { "Psychology 101    ", new List<int>(){4, 3} },

};


        foreach (string key in Report.Keys)
        {
            Console.WriteLine($"Steudent: {Report[key]}");
            Console.WriteLine("Course               Grade           Credit Hours");
            int sum = 0;
            int credits = 0;
            foreach (string course in Report[key].Keys)
            {
                Console.WriteLine($"{course}     {Report[key][course][0]}        {Report[key][course][1]}");
                sum += Report[key][course][0] * Report[key][course][1];
                credits += Report[key][course][1];
            }
            Console.WriteLine($"Final GPA:                  {Math.Round((decimal)sum / credits, 2)}");

        }

        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);
        Console.WriteLine(largerValue);

        Random random = new Random();
        int expires = random.Next(12);
        int percentage = 0;
        Console.WriteLine(expires);
        if (expires < 1)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (expires == 1)
        {
            percentage = 10;
            Console.WriteLine($"Your subscription expires within a day!\r\nRenew now and save {percentage}%!\r\n");
        }
        else if (expires <= 5)
        {
            percentage = 20;
            Console.WriteLine($"Your subscription expires in {expires} days.\r\nRenew now and save {percentage}%!\r\n");
        }
        else if (expires <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
    }
}