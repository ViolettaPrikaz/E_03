Console.Write("Введите пятизначное число ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine( "число палиндром" );
  }
  else Console.WriteLine( "число не палиндром" );
}
 if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine("не пятизначное число");

Console.ReadKey();

