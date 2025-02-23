public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 0)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                int x = nums[i + j]; //0
                int y = nums[i + j + 1]; //3
                nums[i + 1 + j] = x;
                nums[i + j] = y;
            }
        }

        if (nums[i] == 0)
        {
            i--;
        }

        count++;
        if (count == nums.Length)
        {
            break;
        }
    }
    }
}