using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxX = 0, maxY = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if(sizes[i, 0] < sizes[i, 1])
            {
                maxX = sizes[i, 1] > maxX ? sizes[i, 1] : maxX;
                maxY = sizes[i, 0] > maxY ? sizes[i, 0] : maxY;
            }
            else
            {
                maxX = sizes[i, 0] > maxX ? sizes[i, 0] : maxX;
                maxY = sizes[i, 1] > maxY ? sizes[i, 1] : maxY;
            }
        }
        return maxX * maxY;
    }
}