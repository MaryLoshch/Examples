int[] array = { 1, 26, 8, 73, 34, 315, 64, 7, 8 };
int N = array.Length;
int find = 8;

int index = 0;
while (index < N)
{
    
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}