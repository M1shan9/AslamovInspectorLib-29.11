using System;
using InspectorLib;


namespace AslamovInspectorLib
{
 class Program
 {
  static void Main(string[] args)
  {
   
   FunctionInsp function = new FunctionInsp();

   function.GetInspector("Васильев Василий Иванович");   //Вывод в консоль главного инспектора
   function.GetСarInspection("Автоинспекция г. Чита");   //Вывод в консоль названия автоинспекции
   function.SetInspector("");         //Изменение ФИО главного инспектора
   function.GenerateNumber(9, 'X');   //Вывод в консоль госномера
   function.GetWorker();      //Вывод в консоль списка сотрудников автоинспекции
   function.AddWorker();      //Добавление сотрудника автоинспекции
  }
 }
}
