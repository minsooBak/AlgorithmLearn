using System;

public class Solution {
    public int solution(int age) {
        if(age <= 0 && age > 120)
            return 0;
        
        return (2022 - age) + 1;
    }
}