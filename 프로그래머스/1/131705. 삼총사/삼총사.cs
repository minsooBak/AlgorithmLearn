using System;

public class Solution {
    public int solution(int[] number) {
        int result = 0;
        int index = 1;
        for(int i = 0; i < number.Length - 2; index++)
        {
            if(index == number.Length - 1)
            {
                i++;
                index = i + 1;
            }
            int answer = number[i] + number[index];
            for(int j = index + 1; j < number.Length; j++)
            {
                if(answer + number[j] == 0)
                    result++;
            }
        }
        return result;
    }
}