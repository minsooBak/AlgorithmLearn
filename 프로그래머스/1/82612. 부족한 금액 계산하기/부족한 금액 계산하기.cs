using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long result = 0;
        for(int i = 1; i <= count; i++)
        {
            result += (long)(price * i);
        }
        result -= money;
        return result > 0 ? result : 0;
    }
}