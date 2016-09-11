<Query Kind="Program" />

void Main()
{
	
foreach (int i in CountTo10()) {
 System.Console.WriteLine(i);
 if (i == 5) break;
}
}

public IEnumerable<int> CountTo10()
{
 try {
  for (int i = 1; i <= 10; i++) {
   yield return i;
  }
 } finally {
  System.Console.WriteLine("finally");
 }
}

