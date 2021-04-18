using System;

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
	}
}
