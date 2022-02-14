/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINITION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ISM6225_Assignment_2_Spring_2022
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Question 1:
            //Console.WriteLine("Question 1:");
            //int[] nums1 = { 0, 1, 2, 3, 12 };
            //Console.WriteLine("Enter the target number:");
            //int target = Int32.Parse(Console.ReadLine());
            //int pos = SearchInsert(nums1, target);
            //Console.WriteLine("Insert Position of the target is : {0}", pos);
            //Console.WriteLine("");

            //Question2:
            //Console.WriteLine("Question 2");
            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            //string[] banned = { "hit" };
            //string commonWord = MostCommonWord(paragraph, banned);
            //Console.WriteLine("Most frequent word is {0}:", commonWord);
            //Console.WriteLine();

            //Question 3:
            //Console.WriteLine("Question 3");
            //int[] arr1 = { 2, 2, 3, 4 };
            //int lucky_number = FindLucky(arr1);
            //Console.WriteLine("The Lucky number in the given array is {0}", lucky_number);
            //Console.WriteLine();

            //Question 4:
            //Console.WriteLine("Question 4");
            //string secret = "1807";
            //string guess = "7810";
            //string hint = GetHint(secret, guess);
            //Console.WriteLine("Hint for the guess is :{0}", hint);
            //Console.WriteLine();


            //Question 5:
            //Console.WriteLine("Question 5");
            //string s = "ababcbacadefegdehijhklij";
            //List<int> part = PartitionLabels(s);
            //Console.WriteLine("Partation lengths are:");
            //for (int i = 0; i < part.Count; i++)
            //{
            //    Console.Write(part[i] + "\t");
            //}
            //Console.WriteLine();

            //Question 6:
            //Console.WriteLine("Question 6");
            //int[] widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            //string bulls_string9 = "abcdefghijklmnopqrstuvwxyz";
            //List<int> lines = NumberOfLines(widths, bulls_string9);
            //Console.WriteLine("Lines Required to print:");
            //for (int i = 0; i < lines.Count; i++)
            //{
            //    Console.Write(lines[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Question 7:
            //Console.WriteLine("Question 7:");
            //string bulls_string10 = "()[]{}";
            //bool isvalid = IsValid(bulls_string10);
            //if (isvalid)
            //    Console.WriteLine("Valid String");
            //else
            //    Console.WriteLine("String is not Valid");

            //Console.WriteLine();
            //Console.WriteLine();


            //Question 8:
            //Console.WriteLine("Question 8");
            //string[] bulls_string13 = { "gin", "zen", "gig", "msg" };
            //int diffwords = UniqueMorseRepresentations(bulls_string13);
            //Console.WriteLine("Number of with unique code are: {0}", diffwords);
            //Console.WriteLine();
            //Console.WriteLine();

            //Question 9:
            Console.WriteLine("Question 9");
            int[,] grid = { { 0, 1, 2, 3, 4 }, { 24, 23, 22, 21, 5 }, { 12, 13, 14, 15, 16 }, { 11, 17, 18, 19, 20 }, { 10, 9, 8, 7, 6 } };
            int time = SwimInWater(grid);
            Console.WriteLine("Minimum time required is: {0}", time);
            Console.WriteLine();

            //Question 10:
            Console.WriteLine("Question 10");
            string word1 = "horse";
            string word2 = "ros";
            int minLen = MinDistance(word1, word2);
            Console.WriteLine("Minimum number of operations required are {0}", minLen);
            Console.WriteLine();
        }


        /*
        
        Question 1:
        Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        Note: The algorithm should have run time complexity of O (log n).
        Hint: Use binary search
        Example 1:
        Input: nums = [1,3,5,6], target = 5
        Output: 2
        Example 2:
        Input: nums = [1,3,5,6], target = 2
        Output: 1
        Example 3:
        Input: nums = [1,3,5,6], target = 7
        Output: 4
        */

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                //Write your Code here.
                int middle = 0;
                int start = 0;
                int end = nums.Length - 1;
                //Because you do not want to iterate if the target is smaller than the first element or bigger than the last element.
                if (target < nums[start])
                {
                    return start;
                }
                else if (target > nums[end])
                {
                    return end+1;
                }
                else
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        middle = (end + start) / 2;
                        //Binary Search, always compares if the target equals mid.
                        if (nums[middle] == target)
                        {
                            return middle;
                        }
                        //Considers the first half of the list if the target is less than the mid.
                        else if (nums[middle] > target)
                        {
                            end = middle - 1;
                        }
                        //Considers the second half of the list if the target is greater than the mid.
                        else
                        {
                            start = middle + 1;
                        }
                        
                    }
                }
                //If the element is nowhere to be found, returns the next position if the last known start.
                if (start < end)
                    return start + 1;
                else
                    return end + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         
        Question 2
       
        Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.
        The words in paragraph are case-insensitive and the answer should be returned in lowercase.

        Example 1:
        Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
        Output: "ball"
        Explanation: "hit" occurs 3 times, but it is a banned word. "ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
        Note that words in the paragraph are not case sensitive, that punctuation is ignored (even if adjacent to words, such as "ball,"), and that "hit" isn't the answer even though it occurs more because it is banned.

        Example 2:
        Input: paragraph = "a.", banned = []
        Output: "a"
        */

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            try
            {

                //write your code here.

                //Identifies the special characters
                char[] splitter = new char[6] { '.', '?', ',', ' ', ';','"' };
                char single = Convert.ToChar("'");
                splitter[5] = single;
                int max = 0;
                //splits the paragraph to array using the special characters
                string[] paragraphCut = paragraph.ToLower().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                string common = "";
                
                //dictionary to count the occurence of each word
                var dict = new Dictionary<string, int>();
                
                foreach(var word in paragraphCut)
                {
                    //not considering banned words
                    if (banned.Contains(word))
                    {
                        dict[word] = 0;
                    }
                    else
                    {
                        if (dict.ContainsKey(word))
                        {
                            dict[word]++;
                        }
                        else
                        {
                            //if word doesn't exist, setting word count to 1
                            dict[word] = 1;
                        }
                    }

                }
                foreach(KeyValuePair<string, int> word in dict)
                {
                    //assigning the max repeated word to "common"
                    if(word.Value > max)
                    {
                        max = word.Value;
                        common = word.Key;
                    }
                    

                }
                

                return common;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        Question 3:
        Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.
        Return the largest lucky integer in the array. If there is no lucky integer return -1.
 
        Example 1:
        Input: arr = [2,2,3,4]
        Output: 2
        Explanation: The only lucky number in the array is 2 because frequency[2] == 2.

        Example 2:
        Input: arr = [1,2,2,3,3,3]
        Output: 3 
        Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.

        Example 3:
        Input: arr = [2,2,2,3,3]
        Output: -1
        Explanation: There are no lucky numbers in the array.
         */

        public static int FindLucky(int[] arr)
        {
            try
            {

                //write your code here.
                int max = -1;
                //dictionaries to count occurences of each digit.
                var dict = new Dictionary<int, int>();
                foreach(int i in arr)
                {
                    if (dict.ContainsKey(i))
                    {
                        dict[i]++;
                    }
                    else
                        //if digit doesn't exist, setting digit count to 1
                        dict[i] = 1;
                }
                foreach(KeyValuePair<int, int> i in dict)
                {
                    //setting max = digit if the number of times the digit repeats is equal to the digit itself.
                    if(i.Value > max && i.Key == i.Value)
                    {
                        max = i.Value;
                    }

                }
                return max;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        
        Question 4:
        You are playing the Bulls and Cows game with your friend.
        You write down a secret number and ask your friend to guess what the number is. When your friend makes a guess, you provide a hint with the following info:
        •	The number of "bulls", which are digits in the guess that are in the correct position.
        •	The number of "cows", which are digits in the guess that are in your secret number but are located in the wrong position. Specifically, the non-bull digits in the guess that could be rearranged such that they become bulls.
        Given the secret number secret and your friend's guess guess, return the hint for your friend's guess.
        The hint should be formatted as "xAyB", where x is the number of bulls and y is the number of cows. Note that both secret and guess may contain duplicate digits.
 
        Example 1:
        Input: secret = "1807", guess = "7810"
        Output: "1A3B"
        Explanation: Bulls relate to a '|' and cows are underlined:
        "1807"
          |
        "7810"

        */

        public static string GetHint(string secret, string guess)
        {
            try
            {
                //write your code here.

                int bulls = 0;
                int cows = 0;
                //dictionaries to count the number of occurences of each digit
                var dict = new Dictionary<char, int>();
                for (int i = 0; i < secret.Length; i++)
                {
                    if (dict.ContainsKey(secret[i]))
                    {
                        //incrementing digit count if the digit exists
                        dict[secret[i]]++;
                    }
                    else
                    {
                        //initializing the digit count to 1 if the digit doesn't exist
                        dict[secret[i]] = 1;
                    }
                }

                for (int i = 0; i < secret.Length; i++)
                {
                    // Separate for loop for the bulls count to ensure the digits are all accounted for and are not considered for cows.
                    if (secret[i] == guess[i])
                    {
                        bulls++;
                        
                        //decrement digit count once a match is found
                        dict[secret[i]]--;
                    }
                }
                for (int i = 0; i < secret.Length; i++)
                {
                    if (secret[i] != guess[i])
                    {
                        // if a digit is not matched look for the digit in the rest of the string
                        for (int j = 0; j < secret.Length; j++)
                        {
                            if (secret[i] == guess[j] && dict[secret[i]] > 0)
                            {
                                cows++;
                                //decrement digit count once a match is found
                                dict[secret[i]]--;
                            }
                        }
                    }
                }
                string result = Convert.ToString(bulls) + 'A' + Convert.ToString(cows) + 'B';
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /*
        Question 5:
        You are given a string s. We want to partition the string into as many parts as possible so that each letter appears in at most one part.
        Return a list of integers representing the size of these parts.

        Example 1:
        Input: s = "ababcbacadefegdehijhklij"
        Output: [9,7,8]
        Explanation:
        The partition is "ababcbaca", "defegde", "hijhklij".
        This is a partition so that each letter appears in at most one part.
        A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.

        */

        public static List<int> PartitionLabels(string s)
        {
            try
            {
                //write your code here.

                char[] input = s.ToCharArray();
                int[] position = new int[500];
                for (int i = 0; i < input.Length; i++)
                {
                    //Console.WriteLine(input[i]);
                    //gets the latest position of all each character
                    position[input[i]] = i;
                }
                int left = 0, right = 0;
                List<int> output = new List<int>();
                while (left < input.Length)
                { 
                    // right will be allocated to the latest entry of the first element.
                    right = position[input[left]];
                    for (int i = left; i < right; i++)
                    {
                        //updates right to the last element position of the first part.
                        right = Math.Max(right, position[input[i]]);
                    }
                    //Adds the position of the last element to the list.
                    output.Add(right - left + 1);
                    //the position of left is updated to the next part.
                    left = right + 1;
                }
                return output;

                
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
        Question 6

        You are given a string s of lowercase English letters and an array widths denoting how many pixels wide each lowercase English letter is. Specifically, widths[0] is the width of 'a', widths[1] is the width of 'b', and so on.
        You are trying to write s across several lines, where each line is no longer than 100 pixels. Starting at the beginning of s, write as many letters on the first line such that the total width does not exceed 100 pixels. Then, from where you stopped in s, continue writing as many letters as you can on the second line. Continue this process until you have written all of s.
        Return an array result of length 2 where:
             •	result[0] is the total number of lines.
             •	result[1] is the width of the last line in pixels.
 
        Example 1:
        Input: widths = [10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], s = "abcdefghijklmnopqrstuvwxyz"
        Output: [3,60]
        Explanation: You can write s as follows:
                     abcdefghij  	 // 100 pixels wide
                     klmnopqrst  	 // 100 pixels wide
                     uvwxyz      	 // 60 pixels wide
                     There are a total of 3 lines, and the last line is 60 pixels wide.



         Example 2:
         Input: widths = [4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], 
         s = "bbbcccdddaaa"
         Output: [2,4]
         Explanation: You can write s as follows:
                      bbbcccdddaa  	  // 98 pixels wide
                      a           	 // 4 pixels wide
                      There are a total of 2 lines, and the last line is 4 pixels wide.

         */

        public static List<int> NumberOfLines(int[] widths, string s)
        {
            try
            {
                //write your code here.

                int lines = 1;
                int ans = 0;
                foreach(char i in s)
                {
                    //The position of the item in the widths array will be the ascii value of the element - 65
                    //The ascii value of 'a' is 65
                    int width = widths[Convert.ToInt32(i)-Convert.ToInt32('a')];
                    //the final width will be added to ans, as long as the final width < 100
                    ans += width;
                    if (ans > 100)
                    {
                        //Number of lines are incremented when the total-width is greater than 100
                        lines += 1;
                        //ans has to be set back to the previous width when it exceeds 100.
                        ans = width;
                    }
                }
                return new List<int>() {lines, ans };
            }
            catch (Exception)
            {
                throw;
            }

        }


        /*
        
        Question 7:

        Given a string bulls_string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
            1.	Open brackets must be closed by the same type of brackets.
            2.	Open brackets must be closed in the correct order.
 
        Example 1:
        Input: bulls_string = "()"
        Output: true

        Example 2:
        Input: bulls_string  = "()[]{}"
        Output: true

        Example 3:
        Input: bulls_string  = "(]"
        Output: false

        */

        public static bool IsValid(string bulls_string10)
        {
            try
            {
                //write your code here.
                //bool res = false;
                //The string length has to be even for it to be valid.

                string last;
                if (bulls_string10.Length % 2 != 0)
                    return (false);
                //Maintaining a stack for the string.
                Stack<String> myStack = new Stack<String>(bulls_string10.Length);
                for (int i = 0; i < bulls_string10.Length; i++)
                {
                    
                    if (bulls_string10[i] == '(' || bulls_string10[i] == '[' || bulls_string10[i] == '{')
                    {
                        //Parantheses are added to the stack if an open paranthesis is encountered.
                        myStack.Push(Convert.ToString(bulls_string10[i]));
                    }

                    if (myStack.Any() == false)
                    {
                        //return false if the stack is empty.
                        return (false);
                    }


                    if (bulls_string10[i] == ')')
                    {
                        //if the paranthesis ends with a ')' and the top position of the stack is '(', remove the open paranthesis from the stack.
                        //Else, return false
                        last = myStack.Peek();
                        if (last == "(")
                        {
                            myStack.Pop();
                        }
                        if (last == "{" || last == "[")
                            return (false);
                    }
                    if (bulls_string10[i] == '}')
                    {
                        //if the paranthesis ends with a '}' and the top position of the stack is '{', remove the open paranthesis from the stack.
                        //Else, return false
                        last = myStack.Peek();
                        if (last == "{")
                        {
                            myStack.Pop();
                        }
                        if (last == "(" || last == "[")
                            return (false);
                    }
                    if (bulls_string10[i] == ']')
                    {
                        //if the paranthesis ends with a ']' and the top position of the stack is '[', remove the open paranthesis from the stack.
                        //Else, return false
                        last = myStack.Peek();
                        if (last == "[")
                        {
                            myStack.Pop();
                        }
                        if (last == "{" || last == "(")
                            return (false);
                    }
                }


                //At the end, the final stack should always be empty.

                return (myStack.Count() == 0);

            }
            catch (Exception)
            {
                throw;
            }


        }



        /*
         Question 8
        International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:
        •	'a' maps to ".-",
        •	'b' maps to "-...",
        •	'c' maps to "-.-.", and so on.

        For convenience, the full table for the 26 letters of the English alphabet is given below:
        [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
            •	For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
        Return the number of different transformations among all words we have.
 
        Example 1:
        Input: words = ["gin","zen","gig","msg"]
        Output: 2
        Explanation: The transformation of each word is:
        "gin" -> "--...-."
        "zen" -> "--...-."
        "gig" -> "--...--."
        "msg" -> "--...--."
        There are 2 different transformations: "--...-." and "--...--.".

        */

        public static int UniqueMorseRepresentations(string[] words)
        {
            try
            {
                //write your code here.
                int j = 65;
                var dict = new Dictionary<string, string>();
                string[] morse = new string[26] {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
                foreach (string i in morse)
                {
                    string ch = Convert.ToString(Convert.ToChar(j)).ToLower();
                    dict[ch] = i;
                    //Console.WriteLine(ch);
                    j++;
                }
                string word = "";
                var dict2 = new Dictionary<string, int>();
                foreach (string i in words)
                {
                    //Console.WriteLine(i.Length);
                    for (int k = 0; k < i.Length; k++)
                    {
                        word += dict[Convert.ToString(i[k])];
                    }
                    if (dict2.ContainsKey(word))
                    {
                        dict2[word]++;
                    }
                    else
                    {
                        dict2[word] = 1;
                    }
                    word = "";
                }
                //foreach (KeyValuePair<string, int> var in dict2)
                //{
                //    Console.WriteLine(var);
                //}

                return dict2.Count;
            }
            catch (Exception)
            {
                throw;
            }

        }




        /*
        
        Question 9:
        You are given an n x n integer matrix grid where each value grid[i][j] represents the elevation at that point (i, j).
        The rain starts to fall. At time t, the depth of the water everywhere is t. You can swim from a square to another 4-directionally adjacent square if and only if the elevation of both squares individually are at most t. You can swim infinite distances in zero time. Of course, you must stay within the boundaries of the grid during your swim.
        Return the least time until you can reach the bottom right square (n - 1, n - 1) if you start at the top left square (0, 0).

        Example 1:
        Input: grid = [[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]
        Output: 16
        Explanation: The final route is shown.
        We need to wait until time 16 so that (0, 0) and (4, 4) are connected.

        */

        public static int SwimInWater(int[,] grid)
        {
            //try
           // {
                //write your code here.
                int n = grid.Length;
                int left = grid[0,0];
                int right = n * n - 1;
                int ans = -1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    var result = CanReach(grid, mid);
                    if (result)
                    {
                        ans = mid;
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                return ans;

           // }
            //catch (Exception)
            //{

             //   throw;
           // }

            bool CanReach(int[,] grid, int height)
            {
                int[] dirY = new int[] { -1, 0, 1, 0 };
                int[] dirX = new int[] { 0, 1, 0, -1 };
                int n = grid.Length;
                Queue<int> qy = new Queue<int>();
                Queue<int> qx = new Queue<int>();
                qy.Enqueue(0);
                qx.Enqueue(0);
                bool[][] visited = new bool[n][];
                for (int i = 0; i < n; i++)
                {
                    visited[i] = new bool[n];
                }

                visited[0][0] = true;

                while (qy.Count > 0)
                {
                    int sz = qy.Count;
                    for (int k = 0; k < sz; k++)
                    {
                        int curY = qy.Dequeue();
                        int curX = qx.Dequeue();
                        if (curY == n - 1 && curX == n - 1)
                            return true;
                        for (int dir = 0; dir < 4; dir++)
                        {
                            int nextY = curY + dirY[dir];
                            int nextX = curX + dirX[dir];
                            Console.WriteLine("nextX: "+nextX+" nextY: "+nextY);
                            if (nextY >= 0 && nextY < n && nextX >= 0 && nextX < n && !visited[nextY][nextX] && grid[nextY,nextX] <= height)
                            {
                                visited[nextY][nextX] = true;
                                qy.Enqueue(nextY);
                                qx.Enqueue(nextX);
                            }
                        }
                    }
                }
                return false;
            }
        }

        /*
         
        Question 10:
        Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
        You have the following three operations permitted on a word:

        •	Insert a character
        •	Delete a character
        •	Replace a character
         Note: Try to come up with a solution that has polynomial runtime, then try to optimize it to quadratic runtime.

        Example 1:
        Input: word1 = "horse", word2 = "ros"
        Output: 3
        Explanation: 
        horse -> rorse (replace 'h' with 'r')
        rorse -> rose (remove 'r')
        rose -> ros (remove 'e')

        */

        public static int MinDistance(string word1, string word2)
        {
            try
            {
                //write your code here.
                return 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
