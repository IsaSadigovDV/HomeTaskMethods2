//Task 1


void Finder(int[] numbers, int number)
{
	foreach (var item in numbers)
	{
		if (number == item)
		{
			Console.WriteLine("Var");
			return;
		}
	}
	Console.WriteLine("Yoxdu");

}

int[] arr = { 2, 4, 5 };
Finder(arr, 4);

// *******************************
// Task 2

int MaxFind(params int[] numbers)
{
	int Max = numbers[0];
	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] > Max)
		{
			Max = numbers[i];
		}

	}
	return Max;
}

int[] a = { 2, 5, 6,3,9};
Console.WriteLine(MaxFind(a));