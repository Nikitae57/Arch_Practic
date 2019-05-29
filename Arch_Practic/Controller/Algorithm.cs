using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch_Practic.Model;

namespace Arch_Practic.Controller
{
	public static class Algorithm
	{
		private static long min;
		private static List<int> minWay;

		private static List<bool> doneVertex;
		private static List<List<int>> _matrix;

		private static long currentLength;
		private static Stack<int> currentWay;

		private static void Voyager(int point)
		{
			doneVertex[point] = true;
			currentWay.Push(point);

			if (doneVertex.All(x => x == true))
			{
				currentLength += _matrix[point][0];

				if (currentLength < min)
				{
					min = currentLength;
					minWay = currentWay.ToList();
				}

				currentLength -= _matrix[point][0];
			}
			else
			{
				for (int i = 0; i < _matrix.Count; i++)
				{
					if (!doneVertex[i])
					{
						currentLength += _matrix[point][i];
						Voyager(i);
						currentLength -= _matrix[point][i];
					}
				}
			}

			doneVertex[point] = false;
			currentWay.Pop();
		}

		public static int GetMinWay(List<List<int>> matrix, out List<int> way)
		{
			min = long.MaxValue;
			currentLength = 0;

			currentWay = new Stack<int>();
			minWay = new List<int>();

			_matrix = matrix;
			doneVertex = new List<bool>();

			Voyager(0);

			way = minWay;

			if (min > int.MaxValue)
			{
				return int.MaxValue;
			}
			else
			{
				return Convert.ToInt32(min);
			}
		}
	}
}
