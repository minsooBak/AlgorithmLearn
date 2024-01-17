using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        var str = s.ToCharArray();
        int index = s.Length / 2;
        if(s.Length % 2 == 1)
        {
            answer += str[index];
        }
        else
        {
            answer += str[index - 1];
            answer += str[index];
        }
        return answer;
    }
}