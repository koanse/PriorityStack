using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityStack
{
	public class StackPr
	{
		private int[] values;
		private int[] priorities;

		public StackPr()
		{
			values = new int[] {};
			priorities = new int[] {};
		}

		public void Clear()
		{
			values = new int[] { };
			priorities = new int[] { };
		}

		public void Push(int value, int priority)
		{
			int insertIndex;
			for (insertIndex = 0; insertIndex < values.Length; insertIndex++)
			{
				if (priorities[insertIndex] <= priority)
				{
					break;
				}
			}

			var oldValues = values;
			var oldPriorities = priorities;
			values = new int[oldValues.Length + 1];
			priorities = new int[oldPriorities.Length + 1];

			for (var i = 0; i < insertIndex; i++)
			{
				values[i] = oldValues[i];
				priorities[i] = oldPriorities[i];
			}

			values[insertIndex] = value;
			priorities[insertIndex] = priority;

			for (var i = insertIndex; i < oldValues.Length; i++)
			{
				values[i + 1] = oldValues[i];
				priorities[i + 1] = oldPriorities[i];
			}
		}

		public int Pop()
		{
			if (values.Length == 0)
			{
				throw new ArgumentException("Нет данных");
			}
			var oldValues = values;
			var oldPriorities = priorities;
			values = new int[oldValues.Length - 1];
			priorities = new int[oldPriorities.Length - 1];
			for (var i = 0; i < values.Length; i++)
			{
				values[i] = oldValues[i + 1];
				priorities[i] = oldPriorities[i + 1];
			}

			return oldValues[0];
		}

		public override string ToString()
		{
			var start = values.FirstOrDefault();
			var end = values.LastOrDefault();
			var startPr = priorities.FirstOrDefault();
			var endPr = priorities.LastOrDefault();

			var result = string.Empty;
			for (var i = 0; i < values.Length; i++)
			{
				result += $"{values[i]} ({priorities[i]}), ";
			}
			return result + Environment.NewLine + $"Начало стека: {start} ({startPr})"
				+ Environment.NewLine + $"Конец стека: {end} ({endPr})";
		}
	}
}
