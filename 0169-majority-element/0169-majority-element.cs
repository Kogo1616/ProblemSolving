public class Solution {
    public int MajorityElement(int[] nums) {
            return nums
        .GroupBy(x => x)
        .Select(x => new
        {
            key = x.Key,
            value = x.Select(x => x)
        })
        .OrderByDescending(x => x.value.Count())
        .FirstOrDefault()
        .value
        .FirstOrDefault();
    }
}