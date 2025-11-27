namespace Interview_Practice
{
    public class StringPractice
    {
        public static void Reverse(string actual)
        {
            Console.WriteLine("Actual string: " + actual);

            char[] actualArr = actual.ToCharArray();
            char[] reversedArr = new char[actualArr.Length];

            int j = 0;
            for (int i = actualArr.Length - 1; i >= 0; i--)
            {
                reversedArr[j++] = actualArr[i];
            }

            string reversed = new string(reversedArr);
            Console.WriteLine("Reverse string: " + reversed);
        }
        public static void LetterCount(string actual)
        {
            Console.WriteLine("Actual string: " + actual);
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in actual)
            {
                if (letterCount.ContainsKey(c))
                    letterCount[c]++;
                else
                    letterCount[c] = 1;
            }

            Console.WriteLine("Letter counts:");
            foreach (var item in letterCount)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}
