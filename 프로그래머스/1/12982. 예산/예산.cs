using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int size = d.Length;
        for(int i = 0; i < size - 1; ++i)
        {
            for(int j = i + 1; j < size; ++j)
            {
                if(d[i] > d[j])
                {
                    int temp = d[i];
                    d[i] = d[j];
                    d[j] = temp;
                }
            }
        }
        
        int k = 0;
        while(0 < budget && k < size)
        {
            budget -= d[k++];
            if(budget >= 0)
                ++answer;
            else
                break;
        }
        
        return answer;
    }
}