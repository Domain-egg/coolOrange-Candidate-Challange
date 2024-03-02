using System;

namespace coolOrange_CandidateChallenge
{
    public class Task : IPriority, IComplexity, IComparable<Task>
    {
        private string _name;
        private Priority _priority;
        private int _complexity;

        public string GetName()
        {
            return _name;
        }

        public Task(string name, int priorityLevel, int complexityLevel)
        {
            _name = name;
            SetPriority(priorityLevel);
            SetComplexity(complexityLevel);
        }

        public void SetPriority(int level)
        {
            _priority = (Priority)level;
        }

        public int GetPriority()
        {
            return (int)_priority;
        }

        public void SetComplexity(int level)
        {
            _complexity = level;
        }

        public int GetComplexity()
        {
            return _complexity;
        }

        public int CompareTo(Task that)
        {
            if (this.GetComplexity() <  that.GetComplexity()) return -1;
            if (this.GetComplexity() == that.GetComplexity()) return 0;
            return 1; 
        }
        
    }
}