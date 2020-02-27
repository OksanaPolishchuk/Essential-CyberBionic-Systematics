using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp
{
    /// <summary>
    /// Makes an exchange
    /// </summary>
    public class Converter : IConverter
    {
        /// <summary>
        /// Access method for Amount
        /// </summary>
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Access method for Currency
        /// </summary>
        public string Currency
        {
            get;
            set;
        }

        /// <summary>
        /// Access method for ExchangeRates
        /// </summary>
        public Dictionary<string, decimal> ExchangeRates
        {
            get;
            set;
        }

        /// <summary>
        /// Creates instance of <see cref="Converter"/>
        /// </summary>
        /// <param name="usd">The USD/UAH exchange rate</param> 
        /// <param name="eur">The EUR/UAH exchange rate</param>
        /// <param name="rub">The RUB/UAH exchange rate</param>
        /// <param name="uah">The UAH/UAH exchange rate</param>
        /// <param name="amount">The sum that wil be converted</param>
        /// <param name="currency">The currency that wil be changed</param>
        public Converter(decimal usd, decimal eur, decimal rub, decimal uah, decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;

            ExchangeRates = new Dictionary<string, decimal>()
            {
                {"UAH", uah},
                {"USD", usd},
                {"EUR", eur},
                {"RUB", rub}

            };
        }

        /// <summary>
        /// Makes an exchange
        /// </summary>
        /// <param name="outputCurrency">The converted currency exchange rate</param>
        /// <returns></returns>Returns new currency
        public decimal Convert(string outputCurrency)
        {
            if (Amount > 0)
            { 
                return Amount * ExchangeRates[this.Currency] / ExchangeRates[outputCurrency];
            }
            else
            { 
                throw new ArgumentException("Incorrect amount");
            }
        }
    }
}
