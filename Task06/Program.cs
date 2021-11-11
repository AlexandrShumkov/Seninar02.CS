//Создать массив из 30 случайных чисел от 1 до 100 и вывести их на экран.
int[] CreateArray(int n)
{
    int[] a=new int[n];
    Random random=new Random();
    for(int i=0;i<a.Length;i++) a[i]=random.Next(0,101);
    return a;
}

void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++) Console.Write(a[i]+" ");
}

int[] arr=CreateArray(30);
PrintArray(arr);
//произведение элементов массива,которые имеют четное значение и не оканчиваются на 0.
int p=1;
for(int i=0;i<arr.Length;i++)
if(arr[i]%2==0 && arr[i]%10!=0) {
    p=p*arr[i];
}

Console.WriteLine();
Console.WriteLine(p);