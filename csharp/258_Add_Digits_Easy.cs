//258. Add Digits (Easy)
public class Solution {
    public int AddDigits(int num) {
        return 1 + ((num-1) % 9);
    }
}
