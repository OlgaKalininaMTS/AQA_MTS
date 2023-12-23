namespace Delegate;

public class CurrencyExchangeMonitor
{
    public delegate void PriceChange(int currentPrice);  // делегат с параметром цена

    public PriceChange PriceChangeHandler { get; set; }

    public void Start()
    {
        while (true)
        {
            int currentPrice = new Random().Next(100);  // заддается рандомная цена

            PriceChangeHandler(currentPrice);
            
            Thread.Sleep(2000);  // спим 2  секунды
        }
    }
}