
using System.Globalization;

namespace AlgorithmProblem
{
    public class Algorithms
    {

        public static List<int> GetVowelPositions(string s)
        {
            List<int> vowelsPosition = new List<int>();

            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

            for (int i = 0; i < s.Length; i++)
            {
                foreach (var item in vowels)
                {
                    if (s[i] == item)
                    {
                        vowelsPosition.Add(i);
                    }
                }

            }
            return vowelsPosition;
        }


       



        // Number 4
        public static string ReplaceCharacter(string str, char c1, char c2)
        {
            List<char> result = new List<char>();

            foreach (char ch in str)
            {
                if (ch == c1)
                {
                    result.Add(c2);
                }
                else
                {
                    result.Add(ch);
                }
            }

            return new string(result.ToArray());

        }






        // question2
        public static string ShiftLetters(string inputString)
        {
            char[] newChars = new char[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];

                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    newChars[i] = (currentChar == 'z') ? 'a' : (char)(currentChar + 1);
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    newChars[i] = (currentChar == 'Z') ? 'A' : (char)(currentChar + 1);
                }
                else
                {
                    newChars[i] = currentChar;
                }
            }
            return new string(newChars);
        }


        




        // Number3
        public static string TransFormCase(string inputString)
        {
            char[] newChars = new char[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];

                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    newChars[i] = (currentChar == 'z') ? 'a' : (char)(currentChar - 32);
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')/,
                {
                    newChars[i] = (currentChar == 'Z') ? 'A' : (char)(currentChar + 32);
                }
                else
                {
                    newChars[i] = currentChar;
                }
            }
            return new string(newChars);
        }


        

        // NUMBER 5.
        public static string SwapPairs(string s)
        {
            char[] arr = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (i + 1 >= s.Length)
                    {
                        arr[i] = s[i];
                    }
                    else
                    {
                        arr[i] = s[i + 1];
                    }

                }
                else
                {
                    arr[i] = s[i - 1];
                }
                
            }
             return new string(arr);
        }

       
    }

}