public class Solution {
    public string solution(int a, int b) {
        string[] answer = {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        int index = 0;
        int[] mon = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        for(int i = 0; i < a - 1; i++)
        {
            index += mon[i];
        }
        index = (index + b - 1) % 7;
        
        return answer[index];
    }
}