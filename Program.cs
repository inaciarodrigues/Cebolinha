string FraseDigitada;
string LetrasTrocadas;

Console.Write("Digite uma frase: ");
FraseDigitada = Console.ReadLine()!;

LetrasTrocadas = FraseDigitada.Replace ("r", "l").Replace ("R", "L");

Console.WriteLine(LetrasTrocadas);