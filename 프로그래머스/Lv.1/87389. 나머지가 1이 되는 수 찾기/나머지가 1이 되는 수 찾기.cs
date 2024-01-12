using System;

public class Solution {
    public int solution(int n) {
        int answer = n < 3 || n > 1000000 ? -1 : n;
        if(answer != -1)
        {
            for(int i = 1; i <= n; i++)
            {
                answer = ((n % i) != 0) ? ((n % i) < answer ? n % i : answer) : answer;
                if(answer == 1)
                    return i;
            }
        }
        return answer == -1 ? 0 : answer;
    }
}