public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int count = 0;
        for (int x = 0; x < nums.Length; x++)
        {
            if (nums[x] != 0)
            {
                int temp = nums[x];
                nums[x] = nums[count];
                nums[count] = temp;
                count++;
            }
        }
    }
}