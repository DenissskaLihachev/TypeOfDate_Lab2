
class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[50];
        Console.Write("Введите максимальное число: "); int max = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите минимальное число: "); int min = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        GetRandomArr(ref array, min, max);
        ShowArr(array);
        Console.ReadKey();
    }
    static void ShowArr(int[] arr)
    {
        for (int i = 0; i  < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
    }
    static void GetRandomArr(ref int[] arr, int min, int max)
    {
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            var num = random.Next(min, max);

            if (arr.Contains(num))
            {
                i--;
            }
            else
            {
                arr[i] = num;
            }
        }
    }
}