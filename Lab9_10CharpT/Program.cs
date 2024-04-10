using Lab9_10CharpT;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Console.WriteLine("Task 1");
//Console.WriteLine("Enter string 1");
//string s1 = Console.ReadLine();
//Console.WriteLine("Enter string 2");
//string s2 = Console.ReadLine();
//Stack<char> stack = new Stack<char>(s1.ToCharArray());
//try
//{
//    foreach (char c in s2)
//    {
//        if (c != stack.Pop())
//        {
//            throw new NotReversedStringException();
//        }
//    }
//    Console.WriteLine("String is reversed");
//}
//catch (NotReversedStringException e)
//{
//    Console.WriteLine(e.Message);
//}
//static void RecursiveMethod()
//{
//    RecursiveMethod();
//}
//try
//{
//    // DivideByZeroException
//    int a = 0;
//    int result = 10 / a; // Генерує DivideByZeroException

//    // IndexOutOfRangeException
//    int[] numbers = new int[5];
//    int value = numbers[10]; // Генерує IndexOutOfRangeException

//    // InvalidCastException
//    object obj = "string";
//    int num = (int)obj; // Генерує InvalidCastException

//    // OutOfMemoryException
//    int[] bigArray = new int[int.MaxValue]; // Генерує OutOfMemoryException

//    // OverflowException
//    checked
//    {
//        int maxInt = int.MaxValue;
//        int incremented = maxInt + 1; // Генерує OverflowException
//    }

//    // StackOverflowException
//    RecursiveMethod(); // Генерує StackOverflowException
//}
//catch (ArrayTypeMismatchException e)
//{
//    Console.WriteLine($"ArrayTypeMismatchException: {e.Message}");
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine($"DivideByZeroException: {e.Message}");
//}
//catch (IndexOutOfRangeException e)
//{
//    Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
//}
//catch (InvalidCastException e)
//{
//    Console.WriteLine($"InvalidCastException: {e.Message}");
//}
//catch (OutOfMemoryException e)
//{
//    Console.WriteLine($"OutOfMemoryException: {e.Message}");
//}
//catch (OverflowException e)
//{
//    Console.WriteLine($"OverflowException: {e.Message}");
//}
//catch (StackOverflowException e)
//{
//    Console.WriteLine($"StackOverflowException: {e.Message}");
//}



Console.WriteLine("Task 2");
Horse horse = new Horse("Швидкий");

// Підписка на подію Born
horse.Born += (sender, eventArgs) =>
{
    Console.WriteLine("Отримано повідомлення про народження коня.");
};

// Підписка на подію AgeAnnounced
horse.AgeAnnounced += (sender, eventArgs) =>
{
    Console.WriteLine("Отримано повідомлення про вік коня.");
};

// Симулюємо народження коня
horse.Birth();

// Симулюємо відомість про вік коня
horse.AnnounceAge(5);