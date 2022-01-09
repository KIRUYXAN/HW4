//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) Добавьте статический метод для считывания массива из текстового файла.
//Метод должен возвращать массив целых чисел;
//в)Добавьте обработку ситуации отсутствия файла на диске.
cOne.one(); 
public static class cOne
{
    public static void one()
    {
        string name = "";
        da(ref name);
        int pair = 0;
        int n = 0;
        int[] a;
        if (name == "")
        {
            n = 20;
            a = new int[20];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(-10000, 10000);
            }
        }
        else
        {
            a = file(name, ref n);
        }
        doone(a, n, pair);
    }

    static void doone(int[] a, int n, int pair)
    {
        for (int j = 0; j < n-1; j++)
        {
            if (a[j] % 3 == 0 && a[j + 1] % 3 != 0 || a[j] % 3 != 0 && a[j + 1] % 3 == 0)
            {
                pair++;
            }
        }
        for (int k = 0; k < n; k++)
        {
            Console.WriteLine($"{(k + 1),3}: {a[k],6} {(a[k] % 3 == 0),5}");
        }
        Console.WriteLine("\n" + pair);
    }

    static int[] file(string name, ref int n)
    {
        StreamReader file = new StreamReader(name);
        n = int.Parse(file.ReadLine());
        int[] b = new int[n];
        for (int l = 0; l < n; l++)
        {
            b[l] = int.Parse(file.ReadLine());
        }
        file.Close();
        return b;
    }

    static void da(ref string name)
    {
        bool da;
        do
        {
            Console.WriteLine("Введите путь к файлу");
            name = Console.ReadLine();
            Console.WriteLine("");
            bool z = File.Exists(name);
            da = z == true || name == "";
            if (!da)
            {
                Console.WriteLine("Файл не найден");
                Console.WriteLine("");
            }
        } while (da != true);
    }
}