using System;

class HttpRequestBuilder
{
    static void Main()
    {
        Console.WriteLine("Выберите метод (GET, POST, PUT, DELETE): ");
        string method = Console.ReadLine()?.ToUpper() ?? "GET";

        IHttpRequestBuilder builder = method switch
        {
            "GET" => new Get(),
            "POST" => new Post(),
            "PUT" => new Put(),
            "DELETE" => new Delete(),
            _ => new Get()
        };

        HttpDirector director = new HttpDirector(builder);
        var request = director.BuildFull();

        Console.WriteLine("\n ваша запрос");
        Console.WriteLine(request.AboutRequest());
    }
}



class HttpRequestProduct
{
    private string data;
    public HttpRequestProduct() => data = "";
    public string AboutRequest() => data;
    public void AppendData(string str) => data += str + "\n";
}

interface IHttpRequestBuilder
{
    void SetMethod();
    void SetUrl();
    void AddHeaders();
    void SetBody();
    HttpRequestProduct GetRequest();
}

class Get : IHttpRequestBuilder
{
    private HttpRequestProduct request;
    public Get() => request = new HttpRequestProduct();

    public void SetMethod() => request.AppendData("Method: GET");
    public void SetUrl()
    {
        Console.Write("Введите URL для GET: ");
        request.AppendData("URL: " + Console.ReadLine());
    }
    public void AddHeaders()
    {
        Console.Write("Введите заголовок : ");
        string header = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(header))
            request.AppendData("Header: " + header);
    }
    public void SetBody() => request.AppendData("Body: (у GET нет тела  )");

    public HttpRequestProduct GetRequest() => request;
}

class Post : IHttpRequestBuilder
{
    private HttpRequestProduct request;
    public Post() => request = new HttpRequestProduct();

    public void SetMethod() => request.AppendData("Method: POST");
    public void SetUrl()
    {
        Console.Write("Введите URL для POST: ");
        request.AppendData("URL: " + Console.ReadLine());
    }
    public void AddHeaders()
    {
        Console.Write("Введите заголовок : ");
        string header = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(header))
            request.AppendData("Header: " + header);
    }
    public void SetBody()
    {
        Console.Write("Введите тело запроса: ");
        request.AppendData("Body: " + Console.ReadLine());
    }

    public HttpRequestProduct GetRequest() => request;
}

class Put : IHttpRequestBuilder
{
    private HttpRequestProduct request;
    public Put() => request = new HttpRequestProduct();

    public void SetMethod() => request.AppendData("Method: PUT");
    public void SetUrl()
    {
        Console.Write("Введите URL для PUT: ");
        request.AppendData("URL: " + Console.ReadLine());
    }
    public void AddHeaders()
    {
        Console.Write("Введите заголовок : ");
        string header = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(header))
            request.AppendData("Header: " + header);
    }
    public void SetBody()
    {
        Console.Write("Введите тело запроса: ");
        request.AppendData("Body: " + Console.ReadLine());
    }

    public HttpRequestProduct GetRequest() => request;
}

class Delete : IHttpRequestBuilder
{
    private HttpRequestProduct request;
    public Delete() => request = new HttpRequestProduct();

    public void SetMethod() => request.AppendData("Method: DELETE");
    public void SetUrl()
    {
        Console.Write("Введите URL для DELETE: ");
        request.AppendData("URL: " + Console.ReadLine());
    }
    public void AddHeaders()
    {
        Console.Write("Введите заголовок : ");
        string header = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(header))
            request.AppendData("Header: " + header);
    }
    public void SetBody() => request.AppendData("Body: ( не нужен)");

    public HttpRequestProduct GetRequest() => request;
}


class HttpDirector
{
    private IHttpRequestBuilder builder;
    public HttpDirector(IHttpRequestBuilder _builder) => builder = _builder;

    public void SetBuilder(IHttpRequestBuilder _builder) => builder = _builder;

    public HttpRequestProduct BuildFull()
    {
        builder.SetMethod();
        builder.SetUrl();
        builder.AddHeaders();
        builder.SetBody();
        return builder.GetRequest();
    }
}


