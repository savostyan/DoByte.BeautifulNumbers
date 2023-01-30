﻿namespace DoByte.BeautifulNumbers
{
    /// <summary>
    /// Класс вычисляет количество "красивых" чисел в 13-ной системе счисления
    /// </summary>
    /// <remarks>
    /// Тестовое задание.
    ///    В данной задаче будут рассматриваться 13-ти значные числа в тринадцатиричной системе исчисления(цифры 0,1,2,3,4,5,6,7,8,9, A, B, C) с ведущими нулями.
    ///   Например, ABA98859978C0, 6789110551234, 0000007000000
    ///Назовем число красивым, если сумма его первых шести цифр равна сумме шести последних цифр.
    ///Пример:
    ///Число 0055237050A00 - красивое, так как 0+0+5+5+2+3 = 0+5+0+A+0+0
    ///Число 1234AB988BABA - некрасивое, так как 1+2+3+4+A+B != 8+8+B+A+B+A​
    ///Задача:
    ///написать программу на С# печатающую в стандартный вывод количество 13-ти значных красивых чисел с ведущими нулями в тринадцатиричной системе исчисления.
    ///В качестве решения должен быть предоставлено:
    ///1) ответ - количество таких чисел.Ответ должен быть представлен в десятичной системе исчисления.
    ///2) исходный код программы.
    ///Пож-та, кроме кода, напишите ответ числом в теле письма.
    /// </remarks>
    public class BeautifulNumbersHelper
    {
        private const int systemBase13 = 13;

        /// <summary>
        /// Число число "красивых" чисел
        /// </summary>
        public long BeautifulNumbersCount { get; private set; }

        /// <summary>
        /// Коллекция с распределениями сумм и количеством чисел с этой суммой цифр
        /// </summary>
        public Dictionary<int, long> SumsCounters { get; private set; }

        public BeautifulNumbersHelper()
        {
            SumsCounters = new Dictionary<int, long>();
        }

        /// <summary>
        /// Формирование распредления сумм по количеству чисел с такой суммой цифр
        /// </summary>
        public void MakeSumsDistribution()
        {
            for (var i = 0; i < systemBase13; i++)
            {
                for (var j = 0; j < systemBase13; j++)
                {
                    for (var k = 0; k < systemBase13; k++)
                    {
                        for (var l = 0; l < systemBase13; l++)
                        {
                            for (var m = 0; m < systemBase13; m++)
                            {
                                for (var n = 0; n < systemBase13; n++)
                                {
                                    var sum = i + j + k + l + m + n;
                                    if (SumsCounters.ContainsKey(sum))
                                    {
                                        SumsCounters[sum]++;
                                    }
                                    else
                                    {
                                        SumsCounters.Add(sum, 1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Подсчет числа "красивых" чисел в 13-ной системе счисления
        /// </summary>
        public void CalculateBeautifulNumbers()
        {
            BeautifulNumbersCount = SumsCounters.Sum(s => s.Value * s.Value) * systemBase13;
        }
    }
}
