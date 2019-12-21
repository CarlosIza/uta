using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principal
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("commit1");
			List<int> carlos = new List<int>();
			carlos.Add(8);

			foreach (var item in carlos)
			{
				Console.WriteLine(item);
			}
		}
	}
}
