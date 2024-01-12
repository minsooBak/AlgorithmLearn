public class Solution {
    public int solution(int n) {
        int answer = 0;
        answer = n <= 0 || n > 3000 ?  -1 : 0;
        
        if(answer != -1)
        {
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                    answer += n / i;
            }
        }

        
        return answer == -1 ? 0 : answer;
    }
}