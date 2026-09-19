using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        List<int> measure = new List<int>();
        int totalSize = brown + yellow;

        for (int i = 1;i <= Math.Sqrt(totalSize);i++)
        {
            if(totalSize % i == 0)
            {
                measure.Add(i);
                measure.Add(totalSize / i);
            }
        }

        for (int i = measure.Count - 1; i >= 0; i -= 2)
        {
            answer[0] = measure[measure.Count - i];
            answer[1] = measure[measure.Count - (i + 1)];

            int yellowWidth = answer[0] - 2;
            int yellowHeight = answer[1] - 2;

            if (yellowWidth * yellowHeight == yellow)
            {
                return answer;
            }
            else
            {
                continue;
            }
        }

        return answer;
    }
}