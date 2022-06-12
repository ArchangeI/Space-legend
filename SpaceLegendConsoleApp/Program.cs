using SpaceLegendLibrary.Resources;

decimal amount = 100m;
decimal amountToUpdate = -4900m;
Cryptocurrency cryptocurrency = new(amount);
cryptocurrency.AmountReached += Cryptocurrency_AmountReached;
cryptocurrency.UpdateAmount(amountToUpdate);


void Cryptocurrency_AmountReached(object? sender, EventArgs e)
{
    Console.WriteLine("You are win!");
}
