using System;
using System.Text;

public class Solution {
    
    private const int MAXSIZE = 500;
    
    public string solution(int[] food) {
        string answer = "";
        StringBuilder sb = new StringBuilder(MAXSIZE);
        
        for(int i = 1; i < food.Length; i++)
        {
            int sum = food[i] / 2;
            if(sum > 0)
            {
                for(int j = 0; j < sum; j++)
                {
                    sb.Append(i);
                }
                answer += sb.ToString();
                sb.Clear();
            }
        }
        char[] str = answer.ToCharArray();
        Array.Reverse(str);
        answer = $"{answer}0{new string(str)}";
		
        return answer;
    }
}