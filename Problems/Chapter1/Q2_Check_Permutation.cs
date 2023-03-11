namespace Jogadev.CTCI.Problems.Chapter1;
public class CheckPermutation : IProblem<Tuple<string, string>, Boolean>
{
    public bool ExecuteSolution(Tuple<string, string> input)
    {
        (string s1, string s2) = input;
        if(s1.Length != s2.Length) return false;

        return _hashMapSolution(s1, s2);
    }

    private bool _hashMapSolution(string s1, string s2)
    {
        var counts = new Dictionary<char, int>();
        var i = 0;
        while(i < s1.Length)
        {
            _increaseValueByKey(counts, s1[i]);
            _increaseValueByKey(counts, s2[i]);
            i++;
        }

        return counts.All(pair => pair.Value == 2); 
    }

    private void _increaseValueByKey(Dictionary<char, int> dict, char key)
    {
        var currentCount = 0;
        dict.TryGetValue(key, out currentCount);
        dict[key] = currentCount + 1;
    }
}