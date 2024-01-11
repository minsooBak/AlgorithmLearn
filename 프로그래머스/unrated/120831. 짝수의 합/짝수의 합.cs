using System;

public class Solution {
    public int solution(int n) {
        if(n <= 0 || n > 1000)
            return 0;
        int size = n / 2;
        int answer = 0;
        n -= n % 2;
        for(int i = 0; i <= size; i++)
        {
            answer += n - (i * 2);
        }
        
        return answer;
    }
}