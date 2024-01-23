using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string str = "";
        while(n != 0)
        {
            str += n % 3;
            n/=3;
        }
        long a = long.Parse(str);
        int count = 0;
        while (a != 0)
        {
            answer += (int)(a % 10) * (int)Math.Pow(3, count++);
            a /= 10;
        }
        return answer;
    }
}