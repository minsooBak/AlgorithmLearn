public class Solution {
    public int solution(int num) {
        if(num == 1)
            return 0;
        
        int count = 500;
        while(num != 1 && count != 0)
        {
            if(num % 2 == 0)
            {
                num /= 2;
            }else if(num % 2 == 1)
            {
                num = (num * 3) + 1;
            }
            count--;
        }
        
        return count == 0 ? -1 : 500-count;
    }
}