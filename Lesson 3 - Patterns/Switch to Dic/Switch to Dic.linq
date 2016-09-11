<Query Kind="Program" />

// Traditional Switch statement
private static int DoSwitch(string arg)
{
	switch (arg)
	{
		case "a": return 0;
		case "b": return 1;
		case "c": return 2;
		case "d": return 3;// as options get added, complexity increases
	}
	return -1;
}

//Replacement for switch statement
private static Dictionary<string, Func<int>> dict = new Dictionary<string, Func<int>>
	{
		{"a", () => 0 },
		{"b", () => 1 },
		{"c", () => 2 },
		{"d", () => 3 },// options are put into independant code blocks that can be easily tested outside of the main flow
	};

private static int DoDictionary(string arg)
{
	return dict[arg]();
}

public void Main()
{
	Console.WriteLine(DoSwitch("a"));
	Console.WriteLine(DoDictionary("a"));
}