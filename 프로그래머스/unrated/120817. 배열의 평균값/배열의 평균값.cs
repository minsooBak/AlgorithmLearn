using System;

public class Solution {
    public double solution(int[] numbers) {
        if(numbers.Length > 100)
            return 0;
        double answer = 0;
        foreach(int number in numbers)
        {
            if(number <= 0 || number >= 1000)
                continue;
            
            answer += number;
        }
        return answer / numbers.Length;
    }
}