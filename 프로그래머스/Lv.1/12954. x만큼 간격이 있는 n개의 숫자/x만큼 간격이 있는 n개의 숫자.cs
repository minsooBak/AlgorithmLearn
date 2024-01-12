public class Solution {
    public long[] solution(int x, int n) {
        if(n > 1000) return null;
        long[] answer = new long[n];
        for(int i = 0; i < n; i++)
        {
            answer[i] = (long)x * (i + 1);
        }
        return answer;
    }
}