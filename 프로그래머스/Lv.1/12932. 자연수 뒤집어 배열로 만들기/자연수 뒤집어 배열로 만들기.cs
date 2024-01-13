using System;
public class Solution {
    public int[] solution(long n) {
        int size = (int)Math.Floor(Math.Log10(n)) + 1;
        int[] answer = new int[size];
        for(int i = 0; i < size; i++)
        {
            answer[i] = (int)( n %  10);
            n = n / 10;
        }
        return answer;
    }
}