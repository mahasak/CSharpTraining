<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var sw = new Stopwatch();
	sw.Start();
	Task<int> primeNumberTask = Task.Run(() =>
   Enumerable.Range(2, 3000000).Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));

	Console.WriteLine("Task running...");
	Console.WriteLine("The answer is " + primeNumberTask.Result);
	Console.WriteLine(sw.ElapsedMilliseconds);
	DisplayPrimeCounts();
	sw.Stop();
}

void DisplayPrimeCounts()
{
	for (int i = 0; i < 10; i++)
		Console.WriteLine (GetPrimesCount (i*1000000 + 2, 1000000) +
			" primes between " + (i*1000000) + " and " + ((i+1)*1000000-1));
	
	Console.WriteLine ("Done!");
}

int GetPrimesCount(int start, int count)
{
	var sw = new Stopwatch();
	sw.Start();
	
	var a =	ParallelEnumerable.Range (start, count).Count (n =>
			Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0));

	Console.WriteLine(sw.ElapsedMilliseconds);
	sw.Stop();
	return a;
}