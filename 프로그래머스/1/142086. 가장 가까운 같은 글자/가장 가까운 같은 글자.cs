using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        Dictionary<char, int> result = new Dictionary<char, int>(s.Length);
        for(int i = 0; i < s.Length; i++)
        {
            if(result.TryGetValue(s[i], out _))
            {
                answer[i] = i - result[s[i]];
                result[s[i]] = i;
                continue; 
            }
            result[s[i]] = i;
            answer[i] = -1;
        }
        return answer;
    }
}