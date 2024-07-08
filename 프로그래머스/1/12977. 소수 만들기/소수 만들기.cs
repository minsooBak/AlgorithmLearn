using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int num_len = nums.Length;
        for(int i = 0; i < num_len - 2; ++i)
        {
            int num1 = nums[i];
            for(int j = i + 1; j < num_len - 1; ++j)
            {
                int sum = num1 + nums[j];
                for(int k = j + 1; k < num_len; ++k)
                {
                    int result = sum + nums[k];
                    bool isCheck = true;
                    for(int r = 2; r * r <= result; ++r)
                    {
                       if(result % r == 0)
                       {
                           isCheck = false;
                           break;
                       }
                    }
                    
                    if(isCheck)
                        answer++;
                }
            }
        }
        return answer;
    }
}