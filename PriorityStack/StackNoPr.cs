using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityStack
{
	public class StackNoPr
	{
		private int[] values;

		public StackNoPr()
		{
			values = new int[] {};
		}

		public void Clear()
		{
			values = new int[] { };
		}

		public void Push(int value)
		{
			var oldValues = values;
			values = new int[oldValues.Length + 1];
			values[0] = value;
			for (var i = 1; i < values.Length; i++)
			{
				values[i] = oldValues[i - 1];
			}
		}

		public int Pop()
		{
			if (values.Length == 0)
			{
				throw new ArgumentException("Нет данных");
			}
			var oldValues = values;
			values = new int[oldValues.Length - 1];
			for (var i = 0; i < values.Length; i++)
			{
				values[i] = oldValues[i + 1];
			}

			return oldValues[0];
		}

		public override string ToString()
		{
			var start = values.FirstOrDefault();
			var end = values.LastOrDefault();
			return string.Join(",", values.Select(x => x.ToString())) + Environment.NewLine + $"Начало стека: {start}"
				+ Environment.NewLine + $"Конец стека: {end}";
		}
	}
}
