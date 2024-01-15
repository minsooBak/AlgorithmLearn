using System;
public class Solution {
    public long solution(long n) {
        
        long answer =  (long)Math.Ceiling(Math.Sqrt(n));
        answer = answer == Math.Sqrt(n) ? (long)Math.Pow(answer + 1, 2) : -1;
        
        return answer;
    }
}