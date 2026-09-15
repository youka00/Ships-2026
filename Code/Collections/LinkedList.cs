using System.Collections;
using System.Collections.Generic;
// https://www.geeksforgeeks.org/dsa/doubly-linked-list-tutorial/ 
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-10.0
namespace GA.Collections
{
	public class LinkedList<T> : ICollection<T>
	{
		protected class Node
		{
			public T Value { get; set; }
			public Node Next { get; set; }
			public Node Previous {get; set;}

			// i had to install .Net 10.0 and after I did the code broke from here even tho it worked before that
			// I used Copilots explaining to solve this one and i am not sure if this is the best solution..
			public Node() : this(default, null, null)
			{
			}

			public Node(T value, Node next = null, Node previous = null)
			{
				Value = value;
				Next = next;
				Previous = previous;
			}
		}

		/// <summary>
		/// The head of the linked list. When the list is empty, this will be null.
		/// </summary>
		protected Node Head { get; set; } = null;

		public int Count { get; private set; } = 0;

		public virtual bool IsReadOnly => false;

		public void Add(T item)
		{
			if (IsReadOnly)
			{
				throw new System.NotSupportedException("The collection is read-only.");
			}

			Node node = new Node(item);

			if (Head == null)
			{
				Head = node;
			}
			else
			{
				Node current = Head;
				while (current.Next != null)
				{
					current = current.Next;
				}

				current.Next = node;
				node.Previous = current;
			}

			Count++;
		}

		public void Clear()
		{
			if (IsReadOnly)
			{
				throw new System.NotSupportedException("The collection is read-only.");
			}

			Head = null;
			Count = 0;
		}

		public bool Contains(T item)
		{
			Node current = Head;
			while (current != null)
			{
				if (EqualityComparer<T>.Default.Equals(current.Value, item))
				{
					return true;
				}

				current = current.Next;
			}

			return false;
		}

		public virtual void CopyTo(T[] array, int arrayIndex)
		{
			throw new System.NotImplementedException("Not nesessary for this example :D");
		}

		public IEnumerator<T> GetEnumerator()
		{
			Node current = Head;
			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}

		public bool Remove(T item)
		{
			if (IsReadOnly)
			{
				throw new System.NotSupportedException("This collection is read-only");
			}

			Node current = Head;
			Node previous = null;

			while (current != null)
			{
				if (EqualityComparer<T>.Default.Equals(current.Value, item))
				{
					if (previous != null)
					{
						// Removing any other element than the first.
						previous.Next = current.Next;
					}
					else
					{
						// Removing the first element.
						Head = current.Next;
					}

					Count--;
					return true;
				}

				previous = current;
				current = current.Next;
			}

			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

	}
}