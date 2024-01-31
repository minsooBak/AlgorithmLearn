using System;

public class Solution {
    char StringToNumber(string str)
    {
        switch(str)
        {
            case "zero":  return '0';
            case "one":   return '1';
            case "two":   return '2';
            case "three": return '3';
            case "four":  return '4';
            case "five":  return '5';
            case "six":   return '6';
            case "seven": return '7';
            case "eight": return '8';
            case "nine":  return '9';
        }
        return ' ';
    }
    
    public int solution(string s) {
        string answer = "";
        string str = "";
        foreach(char c in s)
        {
            if(c < 'a' || c > 'z')
            {
                if(str != "")
                {
                    answer += StringToNumber(str);
                    str = "";
                }
                 answer += c;
            }else
            {
                str += c;
                char a = StringToNumber(str);
                if(a != ' ')
                {
                    answer += a;
                    str = "";
                }
            }
        }
        return int.Parse(answer);
    }
}

