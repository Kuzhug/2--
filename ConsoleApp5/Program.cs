using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //2-ое задание

        string name = "Алантос";
        string lastName = "Кужугет";
        int age = 19;
        string residence = "Кара-Холь";
        string hobby = "Чтение";

        //Большая строка
        string resume = $"Имя: {name}\nФамилия: {lastName}\nВозраст: {age}\nМесто жительства: {residence}\nХобби: {hobby}";
        Console.WriteLine(resume);



        //10 строк
        string stroka_1 = "Строка 1";
        string stroka_2 = "Строка 2";
        string stroka_3 = "Строка 3";
        string stroka_4 = "Строка 4";
        string stroka_5 = "Строка 5";
        string stroka_6 = "Строка 6";
        string stroka_7 = "Строка 7";
        string stroka_8 = "Строка 8";
        string stroka_9 = "Строка 9";
        string stroka_10 = "Строка 10";


        string all_stroka = $"{stroka_1}\n\t{stroka_2}\n\t{stroka_3}\n\t{stroka_4}\n\t{stroka_5}\n\t{stroka_6}\n\t{stroka_7}\n\t{stroka_8}\n\t{stroka_9}\n\t{stroka_10}";
        Console.WriteLine(all_stroka);



        // Разбивка имени на символы
        string name2 = "Алантос";
        foreach (char letter in name2)
        {
            Console.WriteLine(letter);
        }



        // Преобразование переменных и сложение
        int number = 19;
        string stroka = "Возраст";
        string number_stroka = number.ToString();
        string new_stroka = $"{stroka}: {number_stroka}";
        Console.WriteLine(new_stroka);


    }
}