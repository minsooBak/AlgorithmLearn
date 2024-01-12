using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int count = 1;
        float result = (float)(n % 10);
        while(count <= n)
        {
            answer += (int)result / (1 * count);
            count *= 10;
            result = n % (10 * count);
        }
        return answer;
    }
}