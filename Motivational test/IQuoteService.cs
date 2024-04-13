using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motivational_test
{
    internal interface IQuoteService
    {
        Task<string> GetQuote();
    }
}
