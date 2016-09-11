<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Go();
}
// http://stackoverflow.com/questions/25009437/running-multiple-async-tasks-and-waiting-for-them-all-to-complete
async Task Go()
{
	var task1 = PrintAnswerToLife();
	var task2 = PrintAnswerToLife();
	await task1; 
	await task2;
	Console.WriteLine ("Done");
}

async Task PrintAnswerToLife()
{
	int answer = await GetAnswerToLife();
	Console.WriteLine (answer);
}

async Task<int> GetAnswerToLife()
{
	await Task.Delay (5000);
	int answer = 21 * 2;
	return answer;
}