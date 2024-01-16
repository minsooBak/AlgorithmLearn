public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[arr.Length];
        int count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
                answer[count++] = arr[i];
        }
        int[] result = new int[count];
        
        for(int i = 0; i < count; i++)
            result[i] = answer[i];
        
        if(count == 0)
            return new int[] {-1};
        
        for(int i = count - 1; i > 0; i--)
        {
            for(int j = 0; j < i; j ++)
            {
                if(result[j] > result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }
        return result;
    }
}