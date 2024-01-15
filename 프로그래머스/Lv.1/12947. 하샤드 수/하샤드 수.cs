using System;
public class Solution {
    public bool solution(int x) {
        int size = (int)Math.Floor(Math.Log10(x));
        int num = x;
        int result = 0;
        for(int i = 0; i < size; i++)
        {
            result += (int)num % 10;
            num /= 10;
        }
        result += num;
        return x % result == 0 ? true : false;
    }
}