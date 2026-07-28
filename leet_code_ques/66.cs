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
    }
}