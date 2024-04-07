/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINIDTION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ISM6225_Spring_2024_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        /*
 * This function removes duplicates from a sorted integer array in-place and returns the number of unique elements.
 * The function iterates through the array, comparing each element with its previous element to detect duplicates.
 * If an element is different from its previous one, it is placed in the next position in the array.
 * The index variable keeps track of the position where the next unique element should be placed.
 * Finally, the function returns the index, representing the count of unique elements in the modified array.*/
        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Check if the array is empty
                if (nums.Length == 0)
                    return 0;

                // Initialize the index to track the position of unique elements
                int index = 1;

                // Iterate through the array starting from the second element
                for (int i = 1; i < nums.Length; i++)
                {
                    // If the current element is different from the previous one, add it to the unique elements
                    if (nums[i] != nums[i - 1])
                    {
                        // Place the unique element in the next position in the array
                        nums[index++] = nums[i];
                    }
                }

                // Return the count of unique elements (represented by the index)
                return index;
            }
            catch (Exception)
            {
                // If an exception occurs, rethrow it
                throw;
            }
        }

        /*
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        /*
     MoveZeroes function moves all the non-zero elements of the input array to the beginning while maintaining their relative order. 
     It accomplishes this by iterating through the array, swapping non-zero elements with the element at the current index (tracked by the 'index' variable).

     Parameters:
         - nums: An integer array containing elements to be processed.

     Returns:
         - An IList<int> containing the modified array with non-zero elements moved to the beginning.

     Algorithm:
         - Initialize 'index' to 0.
         - Iterate through the array 'nums'.
         - For each non-zero element encountered, swap it with the element at 'index' position and increment 'index'.
         - After iterating through the array, all non-zero elements will be moved to the beginning.

     Example:
         Input: [0, 1, 0, 3, 12]
         Output: [1, 3, 12, 0, 0]
         Explanation: The non-zero elements (1, 3, 12) are moved to the beginning while maintaining their relative order.*/

        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                // Initialize 'index' to track the position where non-zero elements should be placed.
                int index = 0;

                // Iterate through the array 'nums'.
                for (int i = 0; i < nums.Length; i++)
                {
                    // If the current element is non-zero.
                    if (nums[i] != 0)
                    {
                        // Swap the current non-zero element with the element at 'index' position.
                        int temp = nums[index];
                        nums[index] = nums[i];
                        nums[i] = temp;

                        // Move to the next position for non-zero elements.
                        index++;
                    }
                }

                // Return the modified array.
                return nums;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                // Sort the input array in ascending order
                Array.Sort(nums);

                // Create a list to store the result triplets
                IList<IList<int>> result = new List<IList<int>>();

                // Loop through the array, considering each number as the potential first number in the triplet
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // Skip duplicate values to avoid duplicate triplets
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                    {
                        // Set pointers for the two remaining elements in the triplet
                        int left = i + 1, right = nums.Length - 1, sum = 0 - nums[i];

                        // Continue searching for the other two numbers until the pointers meet
                        while (left < right)
                        {
                            // Check if the sum of the current triplet equals zero
                            if (nums[left] + nums[right] == sum)
                            {
                                // Add the triplet to the result list
                                result.Add(new List<int> { nums[i], nums[left], nums[right] });

                                // Skip duplicate values for both left and right pointers
                                while (left < right && nums[left] == nums[left + 1]) left++;
                                while (left < right && nums[right] == nums[right - 1]) right--;

                                // Move the pointers to continue searching for other triplets
                                left++;
                                right--;
                            }
                            // If the sum is less than zero, move the left pointer to increase the sum
                            else if (nums[left] + nums[right] < sum) left++;
                            // If the sum is greater than zero, move the right pointer to decrease the sum
                            else right--;
                        }
                    }
                }

                // Return the list of unique triplets that sum up to zero
                return result;
            }
            catch (Exception)
            {
                // Handle any exceptions by rethrowing them
                throw;
            }
        }

        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                int maxCount = 0; // Initialize the maximum count of consecutive ones
                int count = 0; // Initialize the current count of consecutive ones

                // Iterate through each element in the array
                foreach (int num in nums)
                {
                    // If the current element is 1
                    if (num == 1)
                    {
                        count++; // Increment the count of consecutive ones
                        maxCount = Math.Max(maxCount, count); // Update the maximum count if necessary
                    }
                    else
                    {
                        count = 0; // Reset the count if the current element is not 1
                    }
                }

                return maxCount; // Return the maximum count of consecutive ones
            }
            catch (Exception)
            {
                throw; // Catch any exceptions and rethrow
            }
        }


        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        /*
     BinaryToDecimal function converts a binary number to its equivalent decimal representation.

     Parameters:
         binary: An integer representing a binary number.

     Returns:
         The decimal equivalent of the binary number.

     Algorithm:
         1. Initialize decimalValue to 0 and baseValue to 1.
         2. Iterate while the binary number is greater than 0:
             a. Get the last digit of the binary number by taking its modulo 10.
             b. Divide the binary number by 10 to remove the last digit.
             c. Multiply the last digit by the baseValue and add it to the decimalValue.
             d. Multiply the baseValue by 2 to move to the next position in the binary number.
         3. Return the calculated decimalValue.

     Throws:
         Exception: Any exception thrown during the execution of the function is propagated.*/
        public static int BinaryToDecimal(int binary)
        {
            try
            {
                // Initialize variables to store decimal value and base value
                int decimalValue = 0;
                int baseValue = 1;

                // Iterate through each digit of the binary number
                while (binary > 0)
                {
                    // Get the last digit of the binary number
                    int lastDigit = binary % 10;
                    // Remove the last digit from the binary number
                    binary = binary / 10;
                    // Add the contribution of the last digit to the decimal value
                    decimalValue += lastDigit * baseValue;
                    // Move to the next position in the binary number
                    baseValue *= 2;
                }

                // Return the calculated decimal value
                return decimalValue;
            }
            catch (Exception)
            {
                // Propagate any exception thrown during the execution
                throw;
            }
        }


        /*

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.
 

        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                // Check if the array contains less than 2 elements, 
                // then the maximum gap between elements is 0.
                if (nums.Length < 2)
                    return 0;

                // Sort the input array in ascending order.
                Array.Sort(nums);

                // Initialize a variable to keep track of the maximum gap.
                int maxGap = 0;

                // Iterate through the sorted array starting from the second element.
                for (int i = 1; i < nums.Length; i++)
                {
                    // Calculate the difference between the current element and the previous element.
                    int currentGap = nums[i] - nums[i - 1];

                    // Update the maximum gap if the current gap is greater.
                    maxGap = Math.Max(maxGap, currentGap);
                }

                // Return the maximum gap found in the sorted array.
                return maxGap;
            }
            catch (Exception)
            {
                // If an exception occurs during execution (unlikely in this context), rethrow the exception.
                throw;
            }
        }


        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        /*
    This function calculates the largest perimeter of a triangle that can be formed using elements from the given integer array nums.

    The function first sorts the array in ascending order using Array.Sort(nums).

    Then, it iterates through the sorted array starting from the end (i = nums.Length - 1) and checks if it's possible to form a triangle with the current element (nums[i]) and the two preceding elements (nums[i - 1] and nums[i - 2]). This is done by checking if the sum of the two smaller sides (nums[i - 1] and nums[i - 2]) is greater than the largest side (nums[i]).

    If such a triangle can be formed, the function returns the perimeter of that triangle (nums[i] + nums[i - 1] + nums[i - 2]).

    If no such triangle can be formed with any triplet of elements in the array, the function returns 0.

    This function assumes that the input array nums contains at least three elements.*/

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                Array.Sort(nums);

                for (int i = nums.Length - 1; i >= 2; i--)
                {
                    if (nums[i] < nums[i - 1] + nums[i - 2])
                        return nums[i] + nums[i - 1] + nums[i - 2];
                }

                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        /*
     This function removes all occurrences of a specified substring 'part' from the input string 's'.
     It iterates through the string 's' and removes the leftmost occurrence of 'part' each time it is found.
     This process continues until no more occurrences of 'part' are found in 's'.

     Parameters:
         s (string): The input string from which occurrences of 'part' will be removed.
         part (string): The substring to be removed from the input string 's'.

     Returns:
         string: The modified string after removing all occurrences of 'part'.

     Throws:
         Exception: If any unexpected error occurs during the execution of the function.

     Note: The method uses the 'Contains', 'IndexOf', and 'Remove' methods of the string class to achieve the removal of occurrences of 'part' efficiently.*/
        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                // Loop until all occurrences of 'part' are removed from 's'
                while (s.Contains(part))
                {
                    // Find the index of the leftmost occurrence of 'part' in 's'
                    int index = s.IndexOf(part);

                    // Remove the occurrence of 'part' from 's'
                    s = s.Remove(index, part.Length);
                }

                // Return the modified string after removing all occurrences of 'part'
                return s;
            }
            catch (Exception)
            {
                // Propagate any exceptions that occur during execution
                throw;
            }
        }


        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}
