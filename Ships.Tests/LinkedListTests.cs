using GA.Collections;
using Xunit;

public class LinkedListTests
{
	[Fact]
	public void TestBasicAdd()
	{
		GA.Collections.LinkedList<int> list = new GA.Collections.LinkedList<int>();
		list.Add(1);
		list.Add(6);
		list.Add(-1);

		Assert.Equal(3, list.Count);
	}

	[Fact]
	public void TestRemove()
	{
		GA.Collections.LinkedList<int> list = new GA.Collections.LinkedList<int>();

		list.Add(1);
		list.Add(6);
		list.Add(-1);

		Assert.True(list.Remove(6));
		Assert.Equal(2, list.Count);
		Assert.DoesNotContain(6, list);
	}
	
	[Fact]
	public void TestContains()
	{
		GA.Collections.LinkedList<int> list = new GA.Collections.LinkedList<int>();

		list.Add(1);
		list.Add(6);
		list.Add(-1);

		Assert.True(list.Contains(6));
		Assert.DoesNotContain(10, list);
		// after installin the new version of .Net my Assert.False did not work. it did work while i used .net 8.0
		// Changed Assert.False to Assert.DoesNotContain with microsoft learns help
		// I couldn't find any solution for Assert.True and honestly i dont know why this did happen.
	}
}