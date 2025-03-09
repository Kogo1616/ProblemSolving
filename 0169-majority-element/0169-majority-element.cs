public class Solution {
    public int MajorityElement(int[] nums) {
        return nums
        .GroupBy(x => x)
        .Select(x => new
        {
            key = x.Key,
            value = x.Select(x => x)
        })
        .MaxBy(x => x.value.Count())
        .value
        .FirstOrDefault();
    }
}