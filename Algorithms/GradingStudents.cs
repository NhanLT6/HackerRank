using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms {

	internal class GradingStudents {

		public static List<int> GetResult(List<int> grades) {
			var finalGrades = new List<int>();

			foreach (var grade in grades) {
				// Next multiple of 5 - grade < 3
				var nexMultipleOf5 = GetNextMultipleOf5(grade);
				var minusResult = nexMultipleOf5 - grade;

				if (minusResult < 3 && nexMultipleOf5 > 38) {
					finalGrades.Add(nexMultipleOf5);
					continue;
				}

				// Case else
				finalGrades.Add(grade);
			}

			return finalGrades;
		}

		private static int GetNextMultipleOf5(int current) {
			while (true) {
				if ((current % 5) == 0) {
					return current;
				}

				current++;
			}
		}

		public static List<int> GetInput() {
			int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

			List<int> grades = new List<int>();

			for (int i = 0; i < gradesCount; i++) {
				int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
				grades.Add(gradesItem);
			}

			return grades;
		}
	}
}