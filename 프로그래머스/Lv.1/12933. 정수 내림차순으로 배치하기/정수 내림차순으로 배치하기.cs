using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        int size = (int)Math.Floor(Math.Log10(n) + 1);
        int[] a = new int[size];
        for(int i = 0; i < size; i++)
        {
            a[i] = (int)(n % 10);
            n /= 10;
        }
        
        for(int i = a.Length - 1; i > 0; i --)
        {
            for(int j = 0; j < i; j++)
            {
                if(a[j] < a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j+1] = temp;
                }
            }
        }
        
        for(int i = 0; i < size; i++)
        {
            answer += (long)(a[i] * Math.Pow(10, (size - 1) - i));
        }
        
        return answer;
    }
}