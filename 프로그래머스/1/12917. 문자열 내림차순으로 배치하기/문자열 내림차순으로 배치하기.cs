public class Solution {
    public string solution(string s) {
        char[] str = s.ToCharArray();
        System.Array.Sort(str);
        System.Array.Reverse(str);
        return string.Concat(str);
    }
}