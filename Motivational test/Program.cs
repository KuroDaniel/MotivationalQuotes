// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//HttpClient client = new HttpClient();
//string url = "https://olato-quotes.p.rapidapi.com/motivation";

//HttpResponseMessage msg =  await client.GetAsync(url);
//Console.WriteLine(msg.Content);
using System.Net.Http.Headers;
using Motivational_test;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Net.Http;




while (true)
{

    //tried to implement code as if else statement

    HttpClient client = new HttpClient();

    Console.WriteLine("Would you like to choose where to get quotes from? [1] is Olato or [2] is typefit");
    string option = Console.ReadLine();
    
    if (option.Equals("y"))
        {
        HttpRequestMessage request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://type.fit/api/quotes"),

        };
    }
    else if (option.Equals("n"))
    {
        //why is request not available? did i accidentally kill code?
        using (HttpResponseMessage response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            TypeFit? result = JsonConvert.DeserializeObject<TypeFit>(body);
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://olato-quotes.p.rapidapi.com/motivation?quotes=random%20quotes"),
                Headers =
    {
        { "X-RapidAPI-Key", "b0c049f4b3msh54c2a6eeef6f21bp11432ajsn9d5aabe69714" },
        { "X-RapidAPI-Host", "olato-quotes.p.rapidapi.com" },
    },
        };
}
   

        //our GET call is broken as a result of this. I don't know how request is not available to use.
        using (HttpResponseMessage response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            MotivationalQuote? result = JsonConvert.DeserializeObject<MotivationalQuote>(body);
            Object? result = JsonConvert.DeserializeObject(body);

            Console.WriteLine("Would you like to choose where to get quotes from? [1] is Olato or [2] is typefit");
    string option = Console.ReadLine();
    if (option.Equals("1") || option.Equals("2"))
    {
        quoteprocess quoteprocess = new quoteprocess();
        {
            await quoteprocess.Loadquote(option);

        }
            
    }

    //Console.WriteLine(result.Quote);


    //more test code
    /*MotivationalQuote q = new MotivationalQuote();
    q.Quote = "forescore 7 years ago";
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.WriteLine(q);*/

    Console.WriteLine("That sure was a quote! Would you like another quote? [y]");
        string question = Console.ReadLine().ToLower();
        if (question.Equals("y"))
        {
            continue;
        }
        else if (question.Equals("n"))
        {
            continue;
        }
        else
    {
        break;
    }
}
