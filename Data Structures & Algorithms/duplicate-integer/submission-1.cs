public class Solution {
    public bool hasDuplicate(int[] nums) {
            HashSet<int> hs = new HashSet<int>();
            foreach (int item in nums){
                hs.Add(item);
            }

            if (hs.Count()!=nums.Length)
            return true;

        return false;
    }
}