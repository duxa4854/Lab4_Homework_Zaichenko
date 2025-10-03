//int[] numbers = [1, 2, 3, 5];
//Console.WriteLine(numbers[3]);
//
//var n = numbers[1];
//Console.WriteLine(n);
//
//numbers[1] = 505;
//Console.WriteLine(numbers[1]);
//
//int[] numbers2 = [1, 2, 3, 5];
//Console.WriteLine(numbers2.Length);
//
//Console.WriteLine(numbers[numbers.Length - 1]);
//Console.WriteLine(numbers[numbers.Length - 2]);
//Console.WriteLine(numbers[numbers.Length - 3]);
//
//Console.WriteLine(numbers[^1]);
//Console.WriteLine(numbers[^2]);
//Console.WriteLine(numbers[^3]);
//
//int[] numbers3 = [1, 2, 3, 5];
//foreach (int i in numbers3)
//{
//    Console.WriteLine(i);
//}
//
//for (int i = 0; i < numbers3.Length; i++)
//{
//    Console.WriteLine(numbers3[i]);
//}
//
//for (int i = 0; i < numbers3.Length; i++)
//{
//    numbers3[i] = numbers3[i] * 2;
//    Console.WriteLine(numbers3[i]);
//}
//
//int i2 = 0;
//while (i2 < numbers3.Length)
//{
//    Console.WriteLine(numbers3[i2]);
//    i2++;
//}
//
//object[] mixedArray = new object[3];
//mixedArray[0] = 10;
//mixedArray[1] = "Hello";
//mixedArray[2] = 3.14;
//
//foreach (object item in mixedArray)
//{
//    Console.WriteLine(item);
//}
//
//int[] numbers4 = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
//int result = 0;
//
//foreach (int number in numbers4)
//{
//    if (number > 0)
//    result++;
//}
//
//Console.WriteLine($"Число элементов больше нуля: {result}");
//
//int[] numbers5 = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
//int n2 = numbers5.Length;
//int k = n2 / 2;
//int temp;
//
//for (int i = 0; i < k; i++)
//{
//    temp = numbers5[i];
//    numbers5[i] = numbers5[n2 - i - 1];
//    numbers5[n2 - i - 1] = temp;
//}
//
//foreach (int i in numbers5)
//{
//    Console.Write($"{i} \t");
//}
//
//int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
//int temp2;
//
//for (int i = 0; i < nums.Length - 1; i++)
//{
//    for (int j = i + 1; j < nums.Length; j++)
//    {
//        if (nums[i] > nums[j])
//        {
//            temp2 = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp2;
//        }
//    }
//}
//
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}
//
//List<string> people = new List<string>();
//List<string> people2 = [];
//List<string> student = new List<string>() { "Иван", "Игорь", "Александр" };
//List<string> student2 = ["Иван", "Игорь", "Александр"];
//List<string> student3 = ["Иван", "Игорь", "Александр"];
//var yourStudent = new List<string>(student3);
//List<string> student4 = new List<string>(10);
//List<string> student5 = new(10);
//
//List<string> student6 = ["Билли", "Игорь", "Степан"];
//string firstStudent = student6[0];
//Console.WriteLine(firstStudent);
//student6[0] = "Богдан";
//Console.WriteLine(student6[0]);
//
//List<string> student7 = ["Билли", "Игорь", "Степан"];
//Console.WriteLine(student7.Count);
//
//List<string> student8 = ["Билли", "Игорь", "Степан"];
//foreach (var person in student8)
//{
//    Console.WriteLine(person);
//}
//
//List<string> student9 = ["Билли", "Игорь", "Степан"];
//student9.Add("Van");
//student9.AddRange(new[] {"Антон", "Денис"});
//student9.Insert(1, "Кирилл");
//student9.InsertRange(1, new[] {"Mike", "Kate"});
//student9.Insert(7, "Михаил");
//
//foreach (var person in student9)
//{
//    Console.WriteLine(person);
//}
//
//var people3 = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
//people3.RemoveAt(1);
//people3.Remove("Tom");
//people3.RemoveRange(1, 2);
//people3.Clear();