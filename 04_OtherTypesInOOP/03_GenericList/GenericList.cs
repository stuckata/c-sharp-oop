using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GenericList<T> where T : IComparable<T>
{
	private const int CAPACITY = 16;
	private T[] arrList;
	private int arrLength;
	private int count;

	public GenericList(int capacity = CAPACITY)
	{
		arrList = new T[capacity];
	}

	public int ArrLength
	{
		get
		{
			return this.arrList.Length;
		}
	}

	public int Count
	{
		get
		{
			return this.count;
		}
	}
}

