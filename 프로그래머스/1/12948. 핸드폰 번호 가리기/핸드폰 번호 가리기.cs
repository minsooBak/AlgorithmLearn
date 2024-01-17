public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        var str = phone_number.ToCharArray();
        for(int i = 0; i < str.Length; i++)
        {
            if(i < str.Length - 4)
                answer += "*";
            else
                answer += str[i];
        }
        
        return answer;
    }
}