using System.Collections.Generic;

class costume
{
    public void main()
    {
        string[,] items = new string[3, 2]
        {
            { "yellow_hat", "headgear" },
            { "blue_sunglasses", "eyewear" },
            { "green_turban", "headgear" }
        };

         Console.WriteLine(solution(items) == 5);
    }
    
    public int solution(string[,] clothes) {
        int answer = 0;
        Dictionary<string, int> costumes = new Dictionary<string, int>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (!costumes.ContainsKey(clothes[i, 1]))
            {
                costumes.Add(clothes[i, 1], 2);
            }
            else
            {
                costumes[clothes[i, 1]]++;
            }
        }

        foreach (var item in costumes.Keys)
        {
            if (answer == 0)
            {
                answer = costumes[item];
                continue;
            }
            
            answer *= costumes[item];
        }
        return answer - 1;
    }
}