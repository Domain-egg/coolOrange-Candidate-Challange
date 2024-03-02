namespace coolOrange_CandidateChallenge
{
    public interface IPriority
    {
        Priority SetPriority(int level);
        int GetPriority(Priority priority);
    }
}