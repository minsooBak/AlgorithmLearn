using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> result = new List<int>(k + 1);
        for(int i = 0; i < score.Length; i++)
        {
            result.Add(score[i]);
            result.Sort((n1, n2) => n2.CompareTo(n1));
            if(result.Count > k)
            {
                result.RemoveAt(k);
            }
            answer[i] = result[result.Count - 1];
        }
        return answer;
    }
}