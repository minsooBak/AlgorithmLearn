public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] str = s.Split(" ");
        for(int i = 0; i < str.Length; i++)
        {
            var c = str[i].ToCharArray();
            for(int j = 2; j < c.Length + 2; j++)
            {
                if(j % 2 == 0)
                {
                    answer += c[j - 2].ToString().ToUpper();
                }else
                {
                    answer += c[j - 2].ToString().ToLower();
                }
            }
            if(i != str.Length - 1)
                answer += " ";
        }
        
        return answer;
    }
}