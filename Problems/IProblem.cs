namespace Jogadev.CTCI.Problems;

public interface IProblem<TInput, TResult>
{
    TResult ExecuteSolution(TInput input);
}