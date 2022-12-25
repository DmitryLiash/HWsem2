Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string strNumber = Convert.ToString(Number);
if (strNumber.Length > 2)
{
  Console.WriteLine(strNumber[2] + " третья цифра");
}
else 
{
  Console.WriteLine("третьей цифры нет");
}
