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




while (true)
{

    //original calls we made and tested but we wanted to switch it to have each one being called differently.

    //HttpClient client = new HttpClient();
    //HttpRequestMessage request = new HttpRequestMessage
    //{
    //    Method = HttpMethod.Get,
    //    RequestUri = new Uri("https://type.fit/api/quotes"),

    //};

    //using (HttpResponseMessage response = await client.SendAsync(request))
    //{
    //    response.EnsureSuccessStatusCode();
    //    string body = await response.Content.ReadAsStringAsync();
    //    TypeFit? result = JsonConvert.DeserializeObject<TypeFit>(body);

    //    HttpClient client = new HttpClient();
    //    HttpRequestMessage request = new HttpRequestMessage
    //    {
    //        Method = HttpMethod.Get,
    //        RequestUri = new Uri("https://olato-quotes.p.rapidapi.com/motivation?quotes=random%20quotes"),
    //        Headers =
    //{
    //    { "X-RapidAPI-Key", "b0c049f4b3msh54c2a6eeef6f21bp11432ajsn9d5aabe69714" },
    //    { "X-RapidAPI-Host", "olato-quotes.p.rapidapi.com" },
    //},
    //    };
    //    using (HttpResponseMessage response = await client.SendAsync(request))
    //    {
    //        response.EnsureSuccessStatusCode();
    //        string body = await response.Content.ReadAsStringAsync();
    //        MotivationalQuote? result = JsonConvert.DeserializeObject<MotivationalQuote>(body);
    //        Object? result = JsonConvert.DeserializeObject(body);

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
        else
        { 
            break; 
        }


    }
