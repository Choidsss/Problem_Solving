public class Solution
{
    public int solution(int n)
    {
        const int Devide = 1234567;
        int[] fibonacci = new int[2] { 0, 1 };
        int answer = 0;
        int cnt = 0;

        while (true)
        {
            cnt++;

            int temp = (fibonacci[0] + fibonacci[1]) % Devide;
            fibonacci[0] = fibonacci[1];
            fibonacci[1] = temp;

            if (cnt == n)
            {
                answer = fibonacci[0];//n번째 수
                break;
            }
        }

        return answer;
    }
}