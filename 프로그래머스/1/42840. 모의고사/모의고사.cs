using System;

public class Solution {
    public int[] solution(int[] answers) {
        int[] a = new int[] {1, 2, 3, 4, 5};
        int[] b = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] c = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        int result1 = 0, result2 = 0, result3 = 0;
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == a[i % a.Length]) result1++;
            if(answers[i] == b[i % b.Length]) result2++;
            if(answers[i] == c[i % c.Length]) result3++;
        }
        
        if(result1 > result2)
        {
            if(result1 > result3)
                return new int[] {1};
            else if(result1 == result3)
                return new int[] {1, 3};
            else
                return new int[] {3};
        }
        else if(result2 > result1)
        {
            if(result2 > result3)
                return new int[] {2};
            else if(result2 == result3)
                return new int[] {2, 3};
            else
                return new int[] {3};
        }
        else
        {
            if(result1 > result3)
                return new int[] {1, 2};
            else if(result1 == result3)
                return new int[] {1, 2, 3};
            else
                return new int[] {3};
        }
    }
}