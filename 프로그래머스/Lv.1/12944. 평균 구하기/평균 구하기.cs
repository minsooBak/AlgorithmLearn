public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        foreach(int num in arr)
            answer += (num > -10000 || num < 10000) ? num : 0;
        return answer / arr.Length;
    }
}