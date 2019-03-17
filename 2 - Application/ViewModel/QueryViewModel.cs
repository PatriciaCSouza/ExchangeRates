using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertCurrency.API.ViewModel
{
    public class QueryViewModel
    {
        #region [Constructor]
        public QueryViewModel()
        {

        }

        public QueryViewModel(string from, string to, string amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
        #endregion

        #region [Properties]
        public string From { get; set; }
        public string To { get; set; }
        public string Amount { get; set; }
        #endregion
    }
}
