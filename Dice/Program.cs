void Main()
{
    Random randomnumberGenerator;
    int randomNumber;
    randomnumberGenerator = new Random();

    randomNumber= randomnumberGenerator.Next(1, 7);
    Console.WriteLine("D6:" + randomNumber);

    randomNumber = randomnumberGenerator.Next(1,7) + randomnumberGenerator.Next(1, 7);
    Console.WriteLine("2D6: " + randomNumber);
}
