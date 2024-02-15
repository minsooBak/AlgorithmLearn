using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score, (a, b) => (a > b) ? -1 : 1);
        for(int i = 0; i <= score.Length - m; i+=m)
        {
            answer += score[i + (m - 1)] * m;
        }
        return answer;
    }
}