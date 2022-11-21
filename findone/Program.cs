int[]array = {14,2,4,4,55,66,7,88,9};

int n = array.Length;
int find = 4;

int index= 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}