using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            if(commands[i, 1] - commands[i, 0] == 0)
            {
                answer[i] = array[commands[i, 0] - 1];
            }else
            {
                List<int> result = new List<int>(commands[i, 1] - commands[i, 0] + 1);
                for(int j = commands[i, 0] - 1; j < commands[i, 1]; j++)
                {
                    result.Add(array[j]);
                }
                result.Sort();
                answer[i] = result[commands[i, 2] - 1];
                result.Clear();
            }
        }
        return answer;
    }
}