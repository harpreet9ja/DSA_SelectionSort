// See https://aka.ms/new-console-template for more information


int[] input = {2,5,3,10,4,6,7};

for (int i = 0; i < input.Length; i++)
{
    int currIndex = i;
    for(int j = i+1; j < input.Length; j++)
    {
        if (input[j] < input[currIndex])
        {
            currIndex = j;
        }            
    }
    int temp = input[i];
    input[i] = input[currIndex];
    input[currIndex] = temp;
}

foreach (var item in input)
{
    Console.WriteLine(item);
}