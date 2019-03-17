using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertCurrency.API.ViewModel
{
    public class CurrencyConversionViewModel
    {
        #region [Constructor Methods]
        public CurrencyConversionViewModel()
        {

        }
        #endregion

        #region [Properties]
        public QueryViewModel Query { get; set; }
        public string Result { get; set; }
        #endregion

    }
}
