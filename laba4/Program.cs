//int[] nums = new int[4];
//int[] num2 = new int[4] { 1, 2, 3, 5 };
//int[] num3 = new int[] { 1, 2, 3, 5 };
//int[] num4 = new[]{ 1, 2, 3, 5 }; 
//int[] num5 = { 1, 2, 3, 5 };
//int[] num6 = [ 1, 2, 3, 5];
//int[] numbers = [1, 2, 3, 5];
//Console.WriteLine(numbers[3]);
//var n = numbers[1];
//Console.WriteLine(n);
//numbers[1] = 505;
//Console.WriteLine(numbers[1]);
//int[] numbers = [1,2,3,5];
//Console.WriteLine(numbers[6]);
//int[] numbers = [1, 2, 3, 5];
//Console.WriteLine(numbers.Length);
//
//Console.WriteLine(numbers[numbers.Length - 1]);
//Console.WriteLine(numbers[numbers.Length - 2]);
//Console.WriteLine(numbers[numbers.Length - 3]);
//
//int[] number = [1, 2, 3, 5];
//foreach (int i in number)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i < number.Length; i++)
//{
//    numbers[i] = numbers[i] * 2;
//    Console.WriteLine(number[i]);
//}
//
//int i = 0; 
//while (i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}
//int[] nums1 = [0, 1, 2, 3, 4, 5];
//int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
//object[] student = ["Иван", "Игорь", 4, 4.6, "c"];
//student[4] = 4;
//dynamic[] student2 = ["Иван", "Игорь", 4, 4.6, "c"];
//student2[4] = 4;
//Console.WriteLine(student[4].GetType());
//Console.WriteLine(student2[4].GetType());
//int result = 0;
//foreach(int number in numbers)
//{
//    if (number > 0)
//        result++;
//}
//Console.WriteLine($"Число элементов больше нуля:{result}");
//
//int[] numder = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
//
//int n = numbers.Length;
//int k = n / 2;
//
//int temp;
//for (int i = 0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//
//foreach (int i in numbers)
//{
//    Console.Write($"{i}\t");
//
//}
//int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
//int temp;
//
//for (int i =0; i<nums.Length -1; i++)
//{
//    for (int j = i ; j < nums.Length; j++)
//    {
//        if (nums[j] < nums[i])
//        {
//            temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//    }
//}
//Console.WriteLine("Вывод отрисоывнного массива");
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}
//
//List<string> people = new List<string>();
//List<string> student = new List<string>()
//{
//    "Иван","Игорь", "Александр"
//};
//var yourStudent = new List<string>(student);
//
//List<string> strings = new List<string>(10);
//List<string> student = new(10);
//List<string> student = ["Билли", "Игорь", "Степан"];
//string firstStudent = student[0];
//Console.WriteLine(firstStudent);
//student[0] = "Богдан";
//Console.WriteLine(student[0]);
//List<string> student = ["Билли", "Игорь", "Степан"];
//Console.WriteLine(student.Count);
//List<string> student = ["Билли", "Игорь", "Степан"];
//foreach (var person in student)
//{
//    Console.WriteLine(person);
//}
//var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
//people.RemoveAt(1);
//people.Remove("Tom");
//people.RemoveRange(1, 2);
//people.Clear();
//
////Задание 1
//string[] items = { "sword", "shield", "potion", "sword", "potion", "potion" };
////Задание 2
//int[] scores = { 10, 20, 15, 30, 25 };
//int total = 0;
//foreach (int score in scores)
//{
//    total += score;
//}
//Console.WriteLine($"Общее количество очков: {total}");
////Задание 3
//int[] numbers = { 1, 3, 7, 2, 5 };
//int max = numbers[0];
//foreach (int num in numbers)
//{
//    if (num > max) max = num;
//}
//Console.WriteLine($"Максимальный элемент: {max}");
////Задание 4
//int[] numbers = { 1, 2, 3, 4, 5 };
//int evenCount = 0;
//int oddCount = 0;
//foreach (int num in numbers)
//{
//    if (num % 2 == 0) evenCount++;
//    else oddCount++;
//}
//Console.WriteLine($"{evenCount} четных и {oddCount} нечетных");
////Задание 5
//int[] times = { 120, 95, 110, 105, 100 };
//int fastest = times[0];
//foreach (int time in times)
//{
//    if (time < fastest) fastest = time;
//}
//Console.WriteLine($"Самое быстрое время: {fastest} секунд");
////Задание 6
//string[] results = { "win", "loss", "win", "win", "loss" };
//int wins = 0;
//int losses = 0;
//foreach (string result in results)
//{
//    if (result == "win") wins++;
//    else if (result == "loss") losses++;
//}
//Console.WriteLine($"{wins} побед и {losses} поражений");
////Задание 7
//int[] points = { 15, 20, 25, 30, 10 };
//int sum = 0;
//foreach (int point in points)
//{
//    sum += point;
//}
//double average = (double)sum / points.Length;
//Console.WriteLine($"Среднее количество очков: {average}");
////Задание 8
//string[] inventory = { "Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка" };
//for (int i = 0; i < inventory.Length; i++)
//{
//    if (inventory[i] == "Ласточка")
//    {
//        inventory[i] = "Кошка";
//    }
//}
////Задание 9
//string[] companions = { "Garrus", "Tali", "Mordin", "Grunt", "Jack" };
//string[] roles = { "Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка" };
//
//for (int i = 0; i < companions.Length; i++)
//{
//    Console.WriteLine($"{roles[i]}: {companions[i]}");
//}

