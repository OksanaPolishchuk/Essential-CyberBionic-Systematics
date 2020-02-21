using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp
{
    public class Converter
    {
        /// <summary>
        /// Access method for UAH 
        /// </summary>
        public decimal UAH
        {
            get;
            set;
        }

        /// <summary>
        /// Access method for USD
        /// </summary>
        public decimal USD
        {
            get;
            set;
        }

        /// <summary>
        ///  Access method for EUR
        /// </summary>
        public decimal EUR
        {
            get;
            set;
        }

        /// <summary>
        ///  Access method for RUB
        /// </summary>
        public decimal RUB
        {
            get;
            set;
        }

        /// <summary>
        /// Converts a sum from UAH into new currencies
        /// </summary>
        /// <param name="sum">The sum that wil be converted</param>
        /// <param name="exchangeRate">The converted currency exchange rate</param>
        /// <returns>Amount in the new currency</returns>
        public decimal ConvertFromUah(ref decimal sum, decimal exchangeRate)
        {
            if (sum > 0)
            {
                return sum = sum / exchangeRate;
            }
            else
            {
                throw new ArgumentException("Incorrect amount");
            }
        }

        /// <summary>
        /// Converts a sum into UAH 
        /// </summary>
        /// <param name="sum">The sum that wil be converted</param>
        /// <param name="exchangeRate">The converted currency exchange rate</param>
        /// <returns>Amount in the UAH</returns>
        public decimal ConvertIntoUah(ref decimal sum, decimal exchangeRate)
        {
            if (sum > 0)
            {
                return sum = sum * exchangeRate;
            }
            else
            {
                throw new ArgumentException("Incorrect amount");
            }
        }

        /// <summary>
        /// Creates instance of <see cref="Converter"/>
        /// </summary>
        /// <param name="usd">The USD/UAH exchange rate</param> 
        /// <param name="eur">The EUR/UAH exchange rate</param>
        /// <param name="rub">The RUB/UAH exchange rate</param>
        /// <param name="uah">The UAH/UAH exchange rate</param>
        public Converter(decimal usd, decimal eur, decimal rub, decimal uah)
        {
            UAH = uah;
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
    }
}
