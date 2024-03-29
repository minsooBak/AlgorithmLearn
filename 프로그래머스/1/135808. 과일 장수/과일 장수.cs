using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        Array.Sort(score, (a, b) => b.CompareTo(a));
        for(int i = 0; i <= score.Length - m; i+=m)
        {
            answer += score[i + (m - 1)] * m;
        }
        return answer;
    }
}