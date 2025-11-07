using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with distinct priorities and dequeue all.
    // Expected Result: Highest priority (Charlie) is dequeued first, then Bob, then Alice.
    // Defect(s) Found: Dequeue did not remove item from queue. Highest priority search skipped last.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 1);
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Charlie", 3);

        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Alice", priorityQueue.Dequeue());

        //Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The earliest inserted item with that priority (Bob) is dequeued first. 
    // Defect(s) Found: >= comparison removed later item insteas of earlier one.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 1);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Charlie", 5);
        priorityQueue.Enqueue("David", 3);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
        Assert.AreEqual("David", priorityQueue.Dequeue());
        Assert.AreEqual("Alice", priorityQueue.Dequeue());


       // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    // Scenario: Try to dequeu from an empty queue.
    // Expected Result: InvalidOperationExpeception with message "The queue is empty."
    // Defect(s) Found: None after fix.
    [TestMethod]
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    // Scenario: Ensure adds to the back (FIFO order maintained for equal priorities)
    // Expected Results: For equal priorities, remove in order of insertion.
    // Defect(s) Found: ?= logic reversed order incorrectly

    public void TestPriorityQueue_MaintainsFIFOForEqualPriorities()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("X", 10);
        priorityQueue.Enqueue("Y", 10);
        priorityQueue.Enqueue("Z", 10);

        Assert.AreEqual("X", priorityQueue.Dequeue());
        Assert.AreEqual("y", priorityQueue.Dequeue());
        Assert.AreEqual("Z", priorityQueue.Dequeue());

    }
}