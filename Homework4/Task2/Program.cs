﻿//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//в)*Добавьте обработку ситуации отсутствия файла на диске.

//Миронов С.В.

using System;

int[] arr = StaticClass.readArr("mass.txt", 20);
Console.WriteLine(arr.Length);
Console.WriteLine(StaticClass.pairNum(arr));
