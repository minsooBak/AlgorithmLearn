public class Solution {
    public string[] solution(string[] strings, int n) {
        for(int i = strings.Length - 1; i > 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                if(strings[j][n] > strings[j + 1][n])
                {
                    var temp = strings[j];
                    strings[j] = strings[j + 1];
                    strings[j + 1] = temp;
                }else if(strings[j][n] == strings[j + 1][n])
                {
                    if(strings[j].CompareTo(strings[j + 1]) > 0)
                    {
                        var temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;
                    }
                }
            }
        }
        return strings;
    }
}