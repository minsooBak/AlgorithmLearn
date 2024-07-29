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
        
        int sum = 0;
        int k = 0;
        while(sum <= budget && k < size)
        {
            sum += d[k++];
            ++answer;
        }
        
        if(sum > budget)
            --answer;
        
        return answer;
    }
}