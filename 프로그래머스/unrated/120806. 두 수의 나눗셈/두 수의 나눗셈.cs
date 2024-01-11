using System;

public class Solution {
    public int solution(int num1, int num2) {
        if( (num1 <= 0 && num1 > 100) || (num2 <= 0 && num2 > 100))
            return 0;
        
        float answer = (float)num1 / num2 * 1000f;
        return (int)answer;
    }
}