using System;

namespace SpaceLegendLibrary.Resources
{
    public class Cryptocurrency
    {
        private decimal _minAmount = default(decimal);
        private decimal _amountForVictory = 5000m;
        
        public decimal Amount { get; set; }

        public Cryptocurrency(decimal amount)
        {
            if (amount < _minAmount)
            {
                Amount = _minAmount;
            }
            else
            {
                Amount = amount;
            }
        }

        public void UpdateAmount(decimal amountToUpdate)
        {
            Amount += amountToUpdate;

            if (Amount >= _amountForVictory)
            {
                OnAmountReached(EventArgs.Empty);
            }
            if (Amount < _minAmount)
            {
                Amount = _minAmount;
            }
        }

        protected virtual void OnAmountReached(EventArgs e)
        {
            if (AmountReached != null)
            {
                AmountReached(this, e);
            }
        }

        public event EventHandler AmountReached;
    }
}
