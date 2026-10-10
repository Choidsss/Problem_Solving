using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        List<int> list = new List<int>();
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int answer = 0;
        int index = 0;

        for (int i = 0; i < tangerine.Length; i++)
        {
            if (dic.ContainsKey(tangerine[i]))
            {
                dic[tangerine[i]]++;
            }
            else
            {
                dic.Add(tangerine[i], 1);
            }
        }

        foreach (KeyValuePair<int, int> pair in dic.OrderByDescending((x) => x.Value))
        {
            list.Add(pair.Key);
        }

        while (true)
        {
            dic[list[index]]--;
            k--;

            if (k != 0 && dic[list[index]] == 0)
            {
                index++;
                answer++;
            }
            else if (k == 0)
            {
                answer++;
                break;
            }
        }

        return answer;
    }
}