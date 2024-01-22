public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = m > n ? n : m;
        int max = m > n ? m : n;
        int result = max;
        
        while(result != 0)
        {
            result = max % min;
            max = min;
            min = result;
        }
        answer[0] = max;
        
        n /= max;
        m /= max;
        answer[1] = m * n * max;

        return answer;
    }
}