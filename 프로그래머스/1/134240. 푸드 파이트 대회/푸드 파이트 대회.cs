using System;
using System.Collections.Generic;

public class Solution {
    
    private const int MAXSIZE = 4500;
    
    public string solution(int[] food) {
        string answer = "";
        List<int> result = new List<int>(MAXSIZE);
        
        for(int i = 1; i < food.Length; i++)
        {
            int sum = food[i] / 2;
            if(sum > 0)
            {
                for(int j = 0; j < sum; j++)
                {
                    result.Add(i);
                }
            }
        }
        answer = String.Join("", result);
        answer += "0";
        result.Reverse();
        answer += String.Join("", result);
        return answer;
    }
}