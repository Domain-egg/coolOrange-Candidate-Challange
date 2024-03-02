using System;
using coolOrange_CandidateChallenge;
using NUnit.Framework;

namespace coolOrange_CandidateChallengeTest
{
    [TestFixture]
    public class TaskTests
    {
        
        [Test]
        public void TaskConstructor_ShouldInitializeProperties()
        {
            string name = "TestTask";
            int priorityLevel = 2;
            int complexityLevel = 3;

            Task task = new Task(name, priorityLevel, complexityLevel);

            Assert.AreEqual(name, task.GetName());
            Assert.AreEqual(priorityLevel, task.GetPriority());
            Assert.AreEqual(complexityLevel, task.GetComplexity());
        }

        [Test]
        public void SetPriority_ShouldSetPriorityCorrectly()
        {
            Task task = new Task("TestTask", 1, 1);

            task.SetPriority(3);

            Assert.AreEqual(3, task.GetPriority());
        }

        [Test]
        public void SetComplexity_ShouldSetComplexityCorrectly()
        {
            Task task = new Task("TestTask", 1, 1);

            task.SetComplexity(5);

            Assert.AreEqual(5, task.GetComplexity());
        }

        [Test]
        public void CompareTo_ShouldCompareComplexityCorrectly()
        {
            Task task1 = new Task("Task1", 1, 3);
            Task task2 = new Task("Task2", 5, 2);
            Task task3 = new Task("Task3", 10, 4);

            Assert.AreEqual(-1,task1.CompareTo(task2));
            Assert.AreEqual(-1,task2.CompareTo(task3));
            Assert.AreEqual(-1,task1.CompareTo(task3));
            Assert.AreEqual(1,task3.CompareTo(task1));
            Assert.AreEqual(0, task1.CompareTo(task1));
        }

        [Test]
        public void Print_ShouldReturnFormattedString()
        {
            Task task = new Task("TestTask", 2, 3);

            string result = task.Print();

            StringAssert.Contains("TestTask", result);
            StringAssert.Contains("priority: 2",result);
            StringAssert.Contains("complexity: 3", result);
        }
    }
    
}