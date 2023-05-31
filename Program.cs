public class Solution {
    public static void Main(string[] args)
    {
        Dictionary<string, int> charIntSet = new Dictionary<string, int>()
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };

        while (true)
        {
            string userInput;
            int value = 0;
            int curValue = 0;
            Console.WriteLine("Please enter a number:");
            userInput = Console.ReadLine().ToUpper();

            if (userInput.Length == 1)
            {
                if (charIntSet.ContainsKey(userInput)) {
                    value = charIntSet[userInput];
                    Console.WriteLine(value);
                } else {
                    Console.WriteLine("No such number");
                }
            }
            else
            {
                for (int i = userInput.Length - 1; i >= 0; i--)
                {

                    curValue = charIntSet[userInput[i].ToString()];
                    if (i != 0)
                    {
                        var test2 = charIntSet[userInput[i].ToString()];
                        var test = charIntSet[userInput[i - 1].ToString()];
                        while (i != 0 && charIntSet[userInput[i].ToString()] == charIntSet[userInput[i - 1].ToString()])
                        {
                            curValue = curValue + charIntSet[userInput[i].ToString()];
                            i--;
                            
                        }
                    }
                
                    else if (charIntSet[userInput[i].ToString()] != 1)
                    {
                        curValue = charIntSet[userInput[i].ToString()];
                    }
                    if (value > curValue)
                    {
                        value = value - curValue;
                    }
                    else
                    {
                        value = value + curValue;
                    }
                }
                Console.WriteLine(value);
            }
        }
    }
}