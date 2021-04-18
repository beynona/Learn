using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Ulearn
{
	//Перечисление енум
	public enum Color
	{
		Red,
		Green,
		Blue
	}
	class Course
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
		//Все операции сравнения
        void Sravnenie()
        {
            //Сравнение, как сложение или деление, тоже имеет возвращаемое значение
            Console.WriteLine(5 < 4);

            // И его можно сохранить в переменную логического типа
            // Это тип, абсолютно равноправный с int, double и другими 
            bool comparisonResult = 6 > 7;
            Console.WriteLine(comparisonResult);

            //Константы истины и лжи
            bool trueValue = true;
            bool falseValue = false;

            //Все операции сравнения
            Console.WriteLine(5 == 6);
            Console.WriteLine(5 != 6);
            Console.WriteLine(5 < 5);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(5 >= 5);

            // Операция "И", или конъюнкция
            Console.WriteLine((5 < 4) && (3 < 4));

            // Операция "ИЛИ", или дизъюнкция
            Console.WriteLine((5 < 4) || (3 < 4));

            // Операция "НЕ", или отрицание
            Console.WriteLine(!(5 < 4));
        }
		static string GetColorNameGoodWay(Color color)
		{
			if (color == Color.Red) return "Красный";
			if (color == Color.Blue) return "Синий";
			if (color == Color.Green) return "Зеленый";
			throw new Exception("Unknown color " + color);
			/* 
			В большинстве случаев писать нужно именно так.
			Если появится новый цвет, то "магическая" строка throw new Exception
			сгенерирует исключительную ситуацию, которая прервет работу программы.

			Обычно падение программы в таком случае лучше, чем некорректная работа.
				(Лучше вообще не стрелять, чем стрелять не туда)
			*/
		}
		//Если совершенно точно известно, что новые цвета появляться не будут, можно писать так:
		static string GetColorName(Color color)
		{
			if (color == Color.Red) return "Красный";
			else if (color == Color.Blue) return "Синий";
			else return "Зеленый";
		}
		//Допустим, вы решили написать метод, возвращающий отрицание переменной
		static bool Negate(bool argument)
		{
			return !argument;
			// так правильно

			/*
			 * if (argument) return false;
			 * else return true;
			 * - а так - нет.
			 */
		}
		//Или метод, сравнивающий два значения
		static bool LessThan(int arg1, int arg2)
		{
			return arg1 < arg2;
			//так правильно

			/*
			 * if (arg1<arg2) return true;
			 * else return false;
			 * - а так - нет
			 */
		}
		//Массивы
		static void Mass()
        {
            //Объявляем переменную array, точно так же, как раньше объявляли переменные других типов.
            //Тип массива чисел - это int[]. Аналогично, есть типы string[], double[], и т.д.
            int[] array;
            int number;

            //Инициализируем переменную array значением "new int[3]" - новый массив длины 3. 
            array = new int[3];
            number = 10;

            //Обращение к элементам массива
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            //Массив, как и остальные типы, имеет собственные свойства и методы
            Console.WriteLine(array.Length); //Выведет 3

            //Обратите внимание, что array.ToString() работает не так, как хотелось бы.
            Console.WriteLine(array.ToString()); //Выведет System.Int32[]

            //Этот код вызовет exception - выход за границы массива
            Console.WriteLine(array[100]);

            var array2 = new[] { 1, 2, 3 };

            //Элементы массива можно пробежать так
            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine(array2[i]);

            // Но лучше использовать специально предназначенный для этого оператор foreach 
            // Работает он аналогично циклу for выше.
            // Однако исключает любые ошибки в индексах и выглядит понятнее.
            foreach (var e in array2)
                Console.WriteLine(e);

            // Иногда, когда нужны именно индексы, foreach не подходит.
            // Например, в случае присвоения элементов массива 
            for (int i = 0; i < array2.Length; i++)
                array2[i] = 2 * i;
        }
        //Короткая запись массивов
        static void ShotMas()
        {
			//Как и с другими типами, можно использовать var и совместить объявление и инициализацию
			var array1 = new int[3];
			array1[0] = 1;
			array1[1] = 2;
			array1[2] = 3;

			//Можно записать так. Это тоже самое, что предыдущие 4 строки. 
			var array2 = new int[] { 1, 2, 3 };

			//Или даже так. Компилятор автоматически восстановит тип данных из типов констант 1, 2, 3.
			var array3 = new[] { 1, 2, 3 };

			//Это касается, конечно, всех типов, не только числовых.
			var array4 = new[] { "a", "b", "c" };

			//Здесь компилятор выдаст ошибку, поскольку он не может определить тип массива.
			//var array5 = new[] { 1, "2", 3 };

			//Но это можно исправить, если указать тип явно. object - это прародитель всех типов. 
			//Все есть object.
			var array6 = new object[] { 1, "2", 3 };
		}
		//Многомерные массивы
		static void MnogMas()
        {
            //Двумерные массивы имеют тип int[,] (соответственно, double[,], string[,] и т.д.)
            int[,] twoDimensionalArray = new int[2, 3];

            //Адресация двумерных массивов также идет через запятую
            twoDimensionalArray[1, 2] = 1;

            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                    twoDimensionalArray[i, j] = 10 * i + j;
            //В памяти значения хранятся в следующем порядке: 0,1,2,10,11,12
            Console.WriteLine(twoDimensionalArray.Length);
            //Метод выше напечатает 6. Длины размерностей нужно получать через метод GetLength
            //Могут быть массивы и бо́льшей размерности
            int[,,] threeDimensionalArray = new int[2, 3, 4];
        }
        //Списки
        static void Spic()
        {
			//Длину массива нельзя изменить
			//Иногда хочется, чтобы массив динамически рос, потому что мы не знаем заранее,
			//сколько в нем элементов
			//В этом случае, нужно использовать List
			//Обратите внимание на пространство имен System.Collections.Generic
			//Угловые скобки пока - волшебные слова. 
			//На самом деле это дженерик-тип, но мы поговорим об этом позже.
			List<int> list = new List<int>();

			list.Add(0);
			list.Add(2);
			list.Add(3);
			list.Insert(1, 1);
			list.RemoveAt(0);

			foreach (var e in list)
				Console.WriteLine(e);
		}
		//Словари
		static void Dict()
        {
			// Массивы и листы позволяют нам установить соответствие между числом 
			// (индексом массива) и чем-то: например, массив string[] по числу дает доступ
			// к строке.
			// Иногда хочется установить, например, соответствие между строкой и числом.

			// Задача: дан массив строк, подсчитать для каждой строки количество вхождений

			var array = new[] { "A", "AB", "B", "A", "B", "B" };

			//Удобно делать это с помощью словаря - сущности, которая ассоциирует между собой
			//значения любых типов
			var dictionary = new Dictionary<string, int>();
			//Заполнение словаря
			foreach (var e in array)
			{
				if (!dictionary.ContainsKey(e)) dictionary[e] = 0; //если ключ найден, то значение ++
				dictionary[e]++;
			}
			//Вывод
			foreach (var e in dictionary)
			{
				Console.WriteLine(e.Key + "\t" + e.Value);
			}

			//Добавление
			var dictionarys = new Dictionary<string, int>();
			dictionarys["Apple"] = 3;
			dictionarys.Add("Pumple", 5);
            //Перебор по значению
            foreach (var item in dictionarys.Values)
            {
                Console.WriteLine($"Значение -{item}");
            }
			//Перебор по ключу
			foreach (var item in dictionarys.Keys)
			{
				Console.WriteLine($"Значение -{item}");
			}

		}
		//StringBuolder
		void Builder()
		{
			//StringBuilder - это класс, представляющий собой изменяемую строку
			var builder = new StringBuilder();

			//Он содержит различные методы вставки, добавления, удаления и т.д.
			builder.Append("Some ");
			builder.Append("string ");
			builder.Append("#15");
			builder.Remove(0, 5);
			builder.Insert(0, "test ");

			//Также можно манипулировать отдельными символами
			builder[0] = 'T';

			//StringBuilder можно превратить в строку
			var str = builder.ToString();
			Console.WriteLine(str);

			//Не нужно полностью заменять строки на StringBuilder,
			//Только в тех случаях, когда действительно выполняется много преобразований
		}
		//Специальные символы
		void Spec()
		{
			//Символ перевода строки
			Console.WriteLine("First line\nSecond line");

			//Символ возврата каретки
			Console.WriteLine("10%\r20%\r30%");

			//Символ табуляции - плохой способ делать таблички
			Console.WriteLine("10\t100\n10000\t1");

			//Вывод кавычки
			Console.WriteLine("This is \" quotes");

			//Так писать нельзя, поскольку компилятор пытается воспринять \U как спецсимвол
			//Console.WriteLine("C:\Users\admin"); // ошибка компиляции

			//Поэтому бэкслеш надо экранировать
			Console.WriteLine("C:\\Users\\admin");

			//Или использовать особую строку, в которой спецсимволы не допускаются
			Console.WriteLine(@"C:\Users\admin");

			//Такую строку удобно использовать для того, чтобы набивать в шарпе длинные строки,
			//фрагменты документов или кода
			Console.WriteLine(
@"
\section{Section 1}
Some {\i LaTeX} text here.");

			//Единственный символ, который нужно экранировать внутри особой строки - кавычки. 
			//Они экранируются удвоением.
			Console.WriteLine(@"This is "" quotes");
		}
		//Форматированный вывод
		void Format()
		{
			var a = 13;
			var b = 14.3456789;

			//Всегда можно писать так:
			Console.WriteLine(a + " " + b);

			//Но для больших документов это не удобно. Кроме того, не получится настроить, 
			//например, количество цифр после запятой
			//Используйте форматированный вывод
			Console.WriteLine("{0} {1}", a, b); // 13 14,3456789

			//Для того, чтобы отформатировать строку без вывода, используйте string.Format
			//На самом деле, Console.WriteLine просто вызывает string.Format.
			var formattedString = string.Format("{0} {1}", a, b);

			//Форматированный вывод позволяет настроить точность округления
			Console.WriteLine("{0:0.000} {1:0.0000}", 1.23456, 1.23456); // 1,235 1,2346

			//Вывод завершающих нулей
			Console.WriteLine("{0:0.000} {1:0.###}", 1.2, 1.2); // 1,200 1,2

			//Добивание нулями слева
			Console.WriteLine("{0:D4}", 42); //0042

			//Разбиение на колонки и выравнивание по правому
			Console.WriteLine("{0,10}|\n{1,10}|", 12345, 123);
			//		12345|
			//		  123|

			//или левому краю
			Console.WriteLine("{0,-10}|\n{1,-10}|", 12345, 123);
			// 12345	|
			// 123		|

			//А также комбинации выравнивания и округления
			Console.WriteLine("{0,10:0.00}|\n{1,10:0.000}|", 1.45, 21.345);
			//		1,45|
			//	  21,345|

			//Форматирование времени и даты
			Console.WriteLine("{0:hh:mm:ss}", DateTime.Now); // 06:01:54

			// MM и mm — это Месяцы и минуты. Различаются только регистром.
			Console.WriteLine("{0:yy-MM-dd}", DateTime.Now); // 17-07-19

			// Можно менять количество букв и порядок:
			Console.WriteLine("{0:d-MM-yyyy}", DateTime.Now); // 1-12-2014

			//Фигурные скобки НЕ ЯВЛЯЮТСЯ спецсимволами шарпа:
			Console.WriteLine("{}"); //Это будет работать! 

			//Но они являются спецсимволами метода string.Format, и их нельзя использовать просто так,
			//если вызывается этот метод
			//Console.WriteLine("{0}{}", a); //Это скомпилируется, но выбросит исключение

			//Надо их экранировать удвоением
			Console.WriteLine("{0}{{}}", a); // 13{}
		}
		//Работа с файлами
		void Files()
        {
			// Запись текста в файл:
			File.WriteAllText("1.txt", "Hello, world!");

			// Путь относительно "текущей директории", которую можно узнать так:
			Console.WriteLine(Environment.CurrentDirectory);
			// Обычно это директория, в которой была запущена ваша программа

			// А размещение запущенного exe-файла можно узнать так:
			Console.WriteLine(Assembly.GetExecutingAssembly().Location);

			// Сформировать абсолютный путь по относительному можно так:
			Console.WriteLine(Path.Combine(Environment.CurrentDirectory, "1.txt"));

			// Записать строки в файл,
			// разделив их символом конца строки (\r\n для Windows и \n для Linux и MacOS)
			File.WriteAllLines("2.txt", new[] { "Hello", "world" });

			// Записать в файл массив байтов в бинарном виде:
			File.WriteAllBytes("3.dat", new byte[10240]);

			// Чтение данных из файла
			string text = File.ReadAllText("1.txt");
			string[] lines = File.ReadAllLines("2.txt");
			byte[] bytes = File.ReadAllBytes("3.dat");

			// Все файлы в текущей директории (точка в пути означает текущую директорию)
			foreach (var file in Directory.GetFiles("."))
				Console.WriteLine(file);
		}
	}
}
