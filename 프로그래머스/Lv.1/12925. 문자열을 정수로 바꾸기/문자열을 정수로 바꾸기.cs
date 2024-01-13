public class Solution {
    public int solution(string s) {
        var str = s.Split("-");
        if(str.Length == 2)
            return int.Parse(str[1]) * -1;
        
        return int.Parse(str[0]);
    }
}