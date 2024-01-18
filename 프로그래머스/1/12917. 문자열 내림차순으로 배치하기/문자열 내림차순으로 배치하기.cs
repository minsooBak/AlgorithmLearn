public class Solution {
    public string solution(string s) {
        char[] str = s.ToCharArray();
        for(int i = str.Length - 1; i > 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                //소문자끼리 비교하여 큰것을 앞으로
                if( (str[j] <= 'Z' && str[j] >= 'A') )
                {
                    if (str[j + 1] < str[j])
                        continue;
                    
                    char temp = str[j];
                    str[j] = str[j + 1];
                    str[j + 1] = temp;
                }
                else if(str[j] < str[j + 1])
                {
                    char temp = str[j];
                    str[j] = str[j + 1];
                    str[j + 1] = temp;
                }
            }
        }
        return string.Concat(str);
    }
}