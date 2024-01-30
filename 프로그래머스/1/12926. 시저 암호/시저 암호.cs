using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        foreach(char c in s)
        {
           if(c != ' ')
           {
               int temp = 0;
               if(c <= 'Z')
               {
                   temp = c + n;
                   if(temp > 'Z') temp = ('A' - 1) + (temp - 'Z');
               }
               else if(c <= 'z')
               {
                   temp = c + n;
                   if(temp > 'z') temp = ('a' - 1) + (temp - 'z'); 
               }
               answer += Convert.ToChar(temp);
           }
            else
            {
                answer += ' ';
            }
        }
        return answer;
    }
}