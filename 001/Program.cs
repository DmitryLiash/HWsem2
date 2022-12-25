Console.WriteLine("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine(stringNumber[1] + " Вторая цифра введеного трехзначного числа");
