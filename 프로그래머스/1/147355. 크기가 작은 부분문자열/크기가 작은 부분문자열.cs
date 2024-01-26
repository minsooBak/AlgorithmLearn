using System;

public class Solution {
    public int solution(string t, string p) {
        long answer = long.Parse(p);
        int result = 0;
        for(int i = 0; i < t.Length - p.Length + 1; i++)
        {
            if(long.Parse(t.Substring(i, p.Length)) <= answer)
            {
                result++;
            }
        }
        return result;
    }
}