// using GA.Collections;
using Xunit;

public class PriorityQueueTest
{
    /// <summary>
    /// Test that Peek return the item with highest priority without remowing it from the queuee
    /// </summary>
    [Fact]
    public void TestPeek()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        // add items with different priorities
        queue.Enqueue(5);
        queue.Enqueue(2);
        queue.Enqueue(8);

        Assert.Equal(2, queue.Peek());
    }


    /// <summary>
    /// Tests that (contains) returns true when the queue contains the given item
    /// </summary>
    [Fact]
    public void TestContainsTrue()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        queue.Enqueue(5);
        queue.Enqueue(2);
        queue.Enqueue(8);

        // cheks that an item that exists is found
        Assert.True(queue.Contains(5));
    }

    /// <summary>
    /// Tests that (contains) returns false when queue does not containthe given item
    /// </summary>
    [Fact]
    public void TestContainFalse()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        queue.Enqueue(5);
        queue.Enqueue(2);
        queue.Enqueue(8);
        queue.Enqueue(1);
        queue.Enqueue(9);
        queue.Enqueue(4);

        Assert.False(queue.Contains(3));
    }

    /// <summary>
    /// Tests that Dequeue removes and returns the item with the highest priority
    /// </summary>

    [Fact]
    public void TestDequeue()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        queue.Enqueue(8);
        queue.Enqueue(1);
        queue.Enqueue(9);
        queue.Enqueue(4);

        // the smalest number SHOULD be returned first
        Assert.Equal(1, queue.Dequeue());

    }

    /// <summary>
    /// Tests that Clear removes all items from the priority queue
    /// </summary>

    [Fact]

    public void TestClear()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        queue.Enqueue(8);
        queue.Enqueue(1);
        queue.Enqueue(9);
        queue.Enqueue(4);

        queue.Clear(); // Removes all items


        // The queue SHOULD contain 0 items
        Assert.Equal(0, queue.Count);

    }

    /// <summary>
    /// Tests that priority queue remains correctly ordered after adding items
    /// </summary>

    [Fact]

    public void TestIsConsistent()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        queue.Enqueue(8);
        queue.Enqueue(1);
        queue.Enqueue(9);
        queue.Enqueue(7);

        Assert.True(queue.IsConsistent());
    }

    [Fact]
    public void TestClearEmpty()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        queue.Clear();

        Assert.Equal(0, queue.Count);
    }

    [Fact]

    public void TestNegativeNumbers()
    {
        GA.Collections.PriorityQueue<int> queue = new GA.Collections.PriorityQueue<int>();

        queue.Enqueue(-2);
        queue.Enqueue(-9);
        queue.Enqueue(-3);
        queue.Enqueue(-6);
        queue.Enqueue(-7);
        queue.Enqueue(-1);

        Assert.Equal(-9, queue.Dequeue());
    }

}