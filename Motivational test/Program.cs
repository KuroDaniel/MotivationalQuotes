using System.Net.Http.Headers;
using Motivational_test;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

while (true)
{
    // Change this line to change the service used
    QuoteServiceType serviceType = QuoteServiceType.OLATO_QUOTES;

    IQuoteService? quoteService = null;
    if (serviceType == QuoteServiceType.OLATO_QUOTES)
    {
        quoteService = new OlatoQuoteService();
    } else if (serviceType == QuoteServiceType.TYPEFIT_QUOTES)
    {
        quoteService = new TypefitQuoteService();
    }

    if (quoteService == null)
    {
        return;
    }
    string theQuote = await quoteService.GetQuote();
    Console.WriteLine(theQuote);

    Console.WriteLine("That sure was a quote! Would you like another quote? [y]");
    string question = Console.ReadLine()?.ToLower() ?? "";
    if (question.Equals("y"))
    {
        continue;
    }
    else
    {
        break;
    }


    //}
}