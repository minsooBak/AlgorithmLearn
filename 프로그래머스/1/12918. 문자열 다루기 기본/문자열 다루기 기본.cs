public class Solution {
    public bool solution(string s) {
        if(s.Length != 4 && s.Length != 6)
            return false;
        
        var str = s.ToCharArray();
        foreach(char c in str)
        {
            if(c < '0' || c >'9')
                return false;
        }
        return true;
    }
}