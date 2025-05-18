using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue two items with the same highest priority and one with lower priority.
    // Expected Result: "A" is dequeued before "B" because both have the same highest priority, so FIFO should apply.
    // Defect(s) Found: PriorityQueue uses `>=` comparison in Dequeue, which causes it to return the last item
    //                  with the highest priority, breaking FIFO behavior for equal priorities.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 15);
        priorityQueue.Enqueue("B", 15);
        priorityQueue.Enqueue("C", 10);

        string result1 = priorityQueue.Dequeue();
        string result2 = priorityQueue.Dequeue();

        Assert.AreEqual("A", result1);
        Assert.AreEqual("B", result2);
    }

    [TestMethod]
    // Scenario: Enqueue three items with different priorities and dequeue them all.
    // Expected Result: Items are dequeued in the order of their priority: High (10), then Medium (5), then Low (1).
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        string result1 = priorityQueue.Dequeue();
        string result2 = priorityQueue.Dequeue();
        string result3 = priorityQueue.Dequeue();

        Assert.AreEqual("High", result1);
        Assert.AreEqual("Medium", result2);
        Assert.AreEqual("Low", result3);
    }
    // Add more test cases as needed below.
}