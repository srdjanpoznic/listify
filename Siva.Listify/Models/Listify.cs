using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Siva.Listify.Models
{
	public class Listify : List<int>, IList<int>
	{
		private readonly int _from;
		private readonly int _to;

		public Listify(int from, int to)
		{
			_from = @from;
			_to = to;
		}

		// TODO solution 1 
		public int this[int index]
		{
			get { return GetValueOfIndex(index); }
			set => throw new NotImplementedException();
		}

		//// TODO solution 2
		//public int this[int index]
		//{
		//	get { return GetValueOfIndexUsingKeyValue(index); } 
		//	set => throw new NotImplementedException();
		//}

		// Used in solution 1
		private int GetValueOfIndex(int index)
		{
			var localIndex = 0;
			foreach (var item in GetList())
			{
				if (localIndex == index)
					return item;

				localIndex++;
			}

			throw new IndexOutOfRangeException();
		}

		// Used in solution 1
		private IEnumerable<int> GetList()
		{
			var index = 0;
			for (int i = _from; i <= _to; i++)
			{
				Console.WriteLine($"Int: {index++} : {i}");
				yield return i;
			}
		}

		// Used in solution 2
		private int GetValueOfIndexUsingKeyValue(int index)
		{
			foreach (var keyValuePair in GetListKeyValue())
			{
				if (keyValuePair.Key == index)
					return keyValuePair.Value;
			}

			throw new IndexOutOfRangeException();
		}

		// Used in solution 2
		private IEnumerable<KeyValuePair<int, int>> GetListKeyValue()
		{
			var index = 0;
			for (int i = _from; i <= _to; i++)
			{
				yield return new KeyValuePair<int, int>(index, i);
				Console.WriteLine($"KeyValue: {index++} : {i}");
			}
		}


		public IEnumerator<int> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(int item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(int item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(int[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public bool Remove(int item)
		{
			throw new NotImplementedException();
		}

		public int Count { get; }
		public bool IsReadOnly { get; }
		public int IndexOf(int item)
		{
			throw new NotImplementedException();
		}

		public void Insert(int index, int item)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}
	}
}


