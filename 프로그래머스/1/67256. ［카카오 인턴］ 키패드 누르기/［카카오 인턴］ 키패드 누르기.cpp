#include <string>
#include <vector>

using namespace std;

string solution(vector<int> numbers, string hand) {
    string answer = "";
    int L = 10;
    int R = 12;
    for(int number : numbers)
    {
        switch(number)
        {
            case 1:
            case 4:
            case 7:
                L = number;
                answer += "L";
                break;
            case 3:
            case 6:
            case 9:
                R = number;
                answer += "R";
                break;
            default:
                if(number == 0) number = 11;
                
                int leftDistance = abs((L - number) / 3) + abs((L - number) % 3);
                int rightDistance = abs((R - number) / 3) + abs((R - number) % 3);
                if(leftDistance < rightDistance)
                {
                    answer += "L";
                    L = number;
                }
                else if(leftDistance == rightDistance)
                {
                   if(hand == "left")
                    {
                        answer += "L";
                        L = number;
                    }
                    else
                    {
                        answer += "R";
                        R = number;
                    }
                }
                else
                {
                    answer += "R";
                    R = number;
                }
                break;
        }
    }
    return answer;
}