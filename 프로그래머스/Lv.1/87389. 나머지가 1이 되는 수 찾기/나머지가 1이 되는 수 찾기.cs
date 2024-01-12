using System;

public class Solution {
    public int solution(int n) {
        int answer = n < 3 || n > 1000000 ? -1 : n;
        if(answer != -1)
        {
            for(int i = 1; i <= n; i++)
            {
                answer = n % i;
                if(answer == 1)
                    return i;
            }
        }
        return answer == -1 ? 0 : answer;
    }
}