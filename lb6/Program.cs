using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
//Виводить будь-яку строку в зворотному порядку(АБВ->ВБА)
//Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456->321.654)
//Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного знаку” теж в зворотному(АБВ, ГДЕ->ВБА, ЕДГ)
//Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних типів
//Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів перевантажити
//Реалізувати метод, що буде масив повертати задом навпаки(Використання Array.Reverse() заборонено!)
//Написати метод зміни довжини масиву на вказану довжину.Додані елементи масиву заповнювати нулями (Підказка: з використанням ключових слів ref i out)


namespace lb6
{
    class Program
    {
        static int IndexOf(string phrase, int index, char[] razdel, out char currentRazdel)
        {
            currentRazdel = ' ';
            for (var i = index; i < phrase.Length; i++)
            {
                for (var j = 0; j < razdel.Length; j++)
                {
                    if (phrase[i] == razdel[j])
                    {
                        currentRazdel = razdel[j];
                        return i;
                    }
                }
            }
            return -1;
        }

        static string WordsReverse(string phrase)
        {
            var phraseLength = phrase.Length;
            var retValue = new char[phraseLength];
            var wordindex = 0;

            while (wordindex < phraseLength)
            {
                var razdelIndex = IndexOf(phrase, wordindex, new[] { ' ', ',', '.' }, out char currentRazdel);
                if (razdelIndex == -1)
                {
                    razdelIndex = phrase.Length;
                }
                else
                {
                    retValue[razdelIndex] = currentRazdel;
                }

                var currentIndex = wordindex;
                for (var i = razdelIndex - 1; i >= wordindex; i--)
                {
                    retValue[currentIndex] = phrase[i];
                    currentIndex++;
                }

                wordindex = razdelIndex + 1;
            }

            return new string(retValue);
        }

        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Console.WriteLine(WordsReverse(text));
            Console.ReadKey();
        }
    }
}