public class Solution {
    public int solution(string s) {
        var c = s.ToCharArray();
        int answer = 0;
        s = "";
        
        if(c[0] == '+' || c[0] == '-')
            answer = 1;
        
        for(int i = answer; i < c.Length; i++)
            s += c[i];

        answer = int.Parse(s); 
        return c[0] == '-' ? answer * -1 : answer;
    }
}