namespace InspectorLib
{
    public class FunctionInsp
    {
  string[] FCS = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };  //Весь список сотрудников
  string[] leaderFCS = { "Васильев Василий Иванович" };                               //ФИО главного инспектора

  public void GetInspector(string name)           //Первый метод возращающий ФИО главного автоинспектора
  {
   Console.WriteLine($"Главный инспектор – {name}");      //Вывод в консоль имени главного автоинспектора
  }

  public void GetСarInspection(string name1)      //Второй метод возращающий названия автоинспекции
  {
   Console.WriteLine($"Название – {name1}");              //Вывод в консоль названия автоинспекции
  }

  public string SetInspector(string fcs)     //Третий метод позволяет изменить ФИО главного автоинспектора
  {
   Console.WriteLine("Выберите имя главного инспектора (Введите число от 1 до 4)");
   int a = Convert.ToInt32(Console.ReadLine());
   if (a == 1)
   {
    fcs = FCS[0];
    FCS = leaderFCS; 
    Console.WriteLine($"Главный инспектор - {fcs}");      // Вывод в консоль главного автоиспектора: Иванов И.И.
    return fcs;
   }
   else if (a == 2)
   {
    fcs = FCS[1];
    FCS = leaderFCS;
    Console.WriteLine($"Главный инспектор - {fcs}");      // Вывод в консоль главного автоиспектора: Зиронов Т.А.
    return fcs;
   }
   else if (a == 3)
   {
    fcs = FCS[2];
    FCS = leaderFCS;
    Console.WriteLine($"Главный инспектор - {fcs}");      // Вывод в консоль главного автоиспектора: Миронов А.В.
    return fcs; 
   }
   else if (a == 4)
   {
    fcs = FCS[3];
    FCS = leaderFCS;
    Console.WriteLine($"Главный инспектор - {fcs}");      // Вывод в консоль главного автоиспектора: Васильев В.И.
    return fcs;
   }
   else
   {
    Console.WriteLine("Ошибка! Вы некорректно ввели число");   //Вывод в консоль ошибки
    return fcs;
   }
  }

  public string GenerateNumber(int num, char symvol, int cod = 75)    //Четвертый метод возвращает сгенерированный госномер
  {
   string res = symvol + "";
   res = res.ToUpper() + "-" + num + "-" + cod;
   Console.WriteLine("Госномер:" + res);                         //Вывод полученного госномера в консоль
   return res;                                                   //Возращение переменной result
  }

  public void GetWorker()                                                 //Пятый метод возращает список сотрудников
  {
   string[] FCS = new string[] { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };//Объявляем массив
   Span<string> FCSSpan = FCS;                            //Преобразуем массив в Span

   foreach (var staff in FCSSpan)
   {
    Console.WriteLine("Список сотрудников автоинспекции: " + staff);
   }
  }

  public void AddWorker()                                                 //Шестой метод добавляет нового сотрудника
  {
   Console.WriteLine("Введите ФИО нового сотрудника");
   string employee = Console.ReadLine();                              //Вводим ФИО сотрудника
   Array.Resize(ref FCS, FCS.Length + 1);
   FCS[FCS.Length - 1] = employee;                          //Изменяем размер массива
   Console.WriteLine($"Сотрудник {employee} успешно добавлен");
  }
 }
}
