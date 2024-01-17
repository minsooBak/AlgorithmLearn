using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;
        for(int i = 0; i < numbers.Length; i++)
        {
            switch(numbers[i])
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        answer -= numbers[i];
                        break;
                    }
            }
        }
        return answer;
    }
}