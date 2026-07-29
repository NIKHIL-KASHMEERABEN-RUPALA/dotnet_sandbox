public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        // here we extract length of digits array
        for(int i = n-1 ; i>=0 ; i--)
        {

            if (digits[i] < 9)
            {
                digits[i] = digits[i]+1;
                return digits;

            }
            
            digits[i] = 0;
            // if we encounter 9 then initialize it to zero
        }
        // if we made it till the end of for loop , it means all elements are 9 
        int[] arr = new int[n+1];
        arr[0] = 1;

        // all the array element by default are zero and 0th index we intialized to 1

        return arr;
    }
}