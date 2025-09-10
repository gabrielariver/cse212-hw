using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test basic enqueue and dequeue with different priorities
    // Expected Result: Items should be dequeued in priority order (highest first)
    // Defect(s) Found: None - All tests pass
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 5);
        priorityQueue.Enqueue("Medium", 3);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Test FIFO behavior for items with same priority
    // Expected Result: When priorities are equal, first enqueued should be dequeued first
    // Defect(s) Found: None - All tests pass
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 3);
        priorityQueue.Enqueue("Second", 3);
        priorityQueue.Enqueue("Third", 3);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Test empty queue exception
    // Expected Result: Should throw InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None - All tests pass
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception of type {e.GetType()} caught: {e.Message}");
        }
    }

    [TestMethod]
    // Scenario: Test mixed priorities with FIFO for equal priorities
    // Expected Result: Higher priorities first, FIFO for equal priorities
    // Defect(s) Found: None - All tests pass
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 2);
        priorityQueue.Enqueue("Item2", 5);
        priorityQueue.Enqueue("Item3", 2);
        priorityQueue.Enqueue("Item4", 5);
        priorityQueue.Enqueue("Item5", 1);

        Assert.AreEqual("Item2", priorityQueue.Dequeue()); // First with priority 5
        Assert.AreEqual("Item4", priorityQueue.Dequeue()); // Second with priority 5
        Assert.AreEqual("Item1", priorityQueue.Dequeue()); // First with priority 2
        Assert.AreEqual("Item3", priorityQueue.Dequeue()); // Second with priority 2
        Assert.AreEqual("Item5", priorityQueue.Dequeue()); // Only item with priority 1
    }


}