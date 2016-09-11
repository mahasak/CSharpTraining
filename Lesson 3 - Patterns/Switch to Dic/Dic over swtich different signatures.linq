<Query Kind="Program" />

public static Dictionary<int, Delegate> dico = new Dictionary<int, Delegate>();

static void Main()
{
	// store
	
	dico[1] = new Func<int, int, int>(Func1);
	dico[2] = new Func<int, int, int, int>(Func2);

	// and later invoke
	var args1 = new object[] { 1, 2 };
	var args2 = new object[] { 1, 2, 3 };
	var res = dico[1].DynamicInvoke(args1);
	Console.WriteLine(res);
	var res2 = dico[2].DynamicInvoke(args2);
	Console.WriteLine(res2);
}

public static int Func1(int arg1, int arg2)
{
	return arg1 + arg2;
}

public static int Func2(int arg1, int arg2, int arg3)
{
	return arg1 + arg2 + arg3;
}

