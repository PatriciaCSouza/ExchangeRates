using System.Collections.Generic;

namespace Domain.Entities
{
    public class CurrencyType
    {
        #region [Constructor Methods]
        public CurrencyType()
        {
        }

        public CurrencyType(string type)
        {
        }
        #endregion

        #region [Properties]
        public string Type { get; private set; }
        #endregion

        #region [General Methods]
        public static List<CurrencyType> GetList()
        {
            return new List<CurrencyType>()
        {
            new CurrencyType("AFN"),
            new CurrencyType("ARS"),
            new CurrencyType("BBD"),
            new CurrencyType("USD"),
            new CurrencyType("EUR"),
            new CurrencyType("MXN"),
            new CurrencyType("AUD"),
            new CurrencyType("NZD"),
            new CurrencyType("NGN"),
            new CurrencyType("TTD"),
            new CurrencyType("BRL")

        };
        }
        #endregion
    }
}