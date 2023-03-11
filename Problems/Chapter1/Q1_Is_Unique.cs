using System.Collections.Generic;

namespace Jogadev.CTCI.Problems.Chapter1;
public class IsUnique : IProblem<string, bool>
{
    public bool ExecuteSolution(string input)
    {
        return _hashMapSolution(input);
    }

    private bool _hashMapSolution(string input)
    {
        var map = new Dictionary<char, bool>();
        foreach(var c in input)
        {
            if(map.ContainsKey(c)) return false;

            map.Add(c, true);
        }

        return true;
    }
}