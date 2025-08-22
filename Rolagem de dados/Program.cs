// See https://aka.ms/new-console-template for more information

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine("Teste sua sorte, veja se consegue tirar um numero maior que 14!");

Console.WriteLine(" ");

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Bonus duplo! +6 de bonus total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("parabens grande sorte! dois numeros iguais, +2 de bonus total");
        total += 2;
    }
}


if (total >= 15)
{
    Console.WriteLine($"parabens seu ganho foi de {total}");
}

else
{
    Console.WriteLine("que pena, sem sorte, talvez na proxima.. {+-+}");
}