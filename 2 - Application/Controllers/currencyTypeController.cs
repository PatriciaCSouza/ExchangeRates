using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ConvertCurrency.API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Domain;
using Domain.Entities;

namespace ConvertCurrency.API.Controllers
{
    public class currencyTypeController : Controller
    {

        private readonly IMapper _mapper;

        public currencyTypeController(IMapper mapper)
        {

        }

        [HttpGet]
        public ActionResult<IEnumerable<CurrencyType>> GetCurrencyTypes()
        {

            IEnumerable<CurrencyTypeViewModel> entity =
               _mapper.Map<IEnumerable<CurrencyType>, IEnumerable<CurrencyTypeViewModel>>(CurrencyType.GetList().AsEnumerable());

            return Ok(JsonConvert.SerializeObject(entity));
        }
    }
}