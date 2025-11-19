using System;
using System.Collections.Generic;

class HttpRequestData
{
    private string data;
    public HttpRequestData() => data = "";
    public string AboutRequest() => data;
    public void AppendData(string str) => data += str + "\n";
}

interface IRequestConstructor
{
    void CreateMethod();
    void CreateUrl();
    void CreateHeaders();
    void CreateBody();
    void CreateTimeout();
    void CreateQueryParams();
    HttpRequestData GetRequest();
}

class GetConstructor : IRequestConstructor
{
    private HttpRequestData request;
    public GetConstructor() => request = new HttpRequestData();

    public void CreateMethod() => request.AppendData("(create) Method: GET");
    public void CreateUrl()
    {
        Console.Write("Введите URL для GET: ");
        request.AppendData("(create) URL: " + Console.ReadLine());
    }
    public void CreateHeaders()
    {
        Console.Write("Добавить заголовок? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название заголовка: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение заголовка: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Header: {name}: {value}");
        }
    }
    public void CreateBody() => request.AppendData("(create) Body: (у GET нет тела)");
    public void CreateTimeout()
    {
        Console.Write("Введите таймаут в секундах: ");
        request.AppendData("(create) Timeout: " + Console.ReadLine() + " seconds");
    }
    public void CreateQueryParams()
    {
        Console.Write("Добавить query параметры? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название параметра: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение параметра: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Query Param: {name}={value}");
        }
    }
    public HttpRequestData GetRequest() => request;
}

class PostConstructor : IRequestConstructor
{
    private HttpRequestData request;
    public PostConstructor() => request = new HttpRequestData();

    public void CreateMethod() => request.AppendData("(create) Method: POST");
    public void CreateUrl()
    {
        Console.Write("Введите URL для POST: ");
        request.AppendData("(create) URL: " + Console.ReadLine());
    }
    public void CreateHeaders()
    {
        Console.Write("Добавить заголовок? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название заголовка: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение заголовка: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Header: {name}: {value}");
        }
    }
    public void CreateBody()
    {
        Console.Write("Введите тело запроса: ");
        request.AppendData("(create) Body: " + Console.ReadLine());
    }
    public void CreateTimeout()
    {
        Console.Write("Введите таймаут в секундах: ");
        request.AppendData("(create) Timeout: " + Console.ReadLine() + "");
    }
    public void CreateQueryParams()
    {
        Console.Write("Добавить query параметры? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название параметра: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение параметра: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Query Param: {name}={value}");
        }
    }
    public HttpRequestData GetRequest() => request;
}

class PutConstructor : IRequestConstructor
{
    private HttpRequestData request;
    public PutConstructor() => request = new HttpRequestData();

    public void CreateMethod() => request.AppendData("(create) Method: PUT");
    public void CreateUrl()
    {
        Console.Write("Введите URL для PUT: ");
        request.AppendData("(create) URL: " + Console.ReadLine());
    }
    public void CreateHeaders()
    {
        Console.Write("Добавить заголовок? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название заголовка: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение заголовка: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Header: {name}: {value}");
        }
    }
    public void CreateBody()
    {
        Console.Write("Введите тело запроса: ");
        request.AppendData("(create) Body: " + Console.ReadLine());
    }
    public void CreateTimeout()
    {
        Console.Write("Введите таймаут в секундах: ");
        request.AppendData("(create) Timeout: " + Console.ReadLine() + " seconds");
    }
    public void CreateQueryParams()
    {
        Console.Write("Добавить query параметры? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название параметра: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение параметра: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Query Param: {name}={value}");
        }
    }
    public HttpRequestData GetRequest() => request;
}

class DeleteConstructor : IRequestConstructor
{
    private HttpRequestData request;
    public DeleteConstructor() => request = new HttpRequestData();

    public void CreateMethod() => request.AppendData("(create) Method: DELETE");
    public void CreateUrl()
    {
        Console.Write("Введите URL для DELETE: ");
        request.AppendData("(create) URL: " + Console.ReadLine());
    }
    public void CreateHeaders()
    {
        Console.Write("Добавить заголовок? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название заголовка: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение заголовка: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Header: {name}: {value}");
        }
    }
    public void CreateBody() => request.AppendData("(create) Body: (не нужен)");
    public void CreateTimeout()
    {
        Console.Write("Введите таймаут в секундах: ");
        request.AppendData("(create) Timeout: " + Console.ReadLine() + " seconds");
    }
    public void CreateQueryParams()
    {
        Console.Write("Добавить query параметры? (y/n): ");
        if (Console.ReadLine()?.ToLower() == "y")
        {
            Console.Write("Введите название параметра: ");
            string name = Console.ReadLine();
            Console.Write("Введите значение параметра: ");
            string value = Console.ReadLine();
            request.AppendData($"(create) Query Param: {name}={value}");
        }
    }
    public HttpRequestData GetRequest() => request;
}

class RequestDirector
{
    private IRequestConstructor constructor;
    public RequestDirector(IRequestConstructor _constructor) => constructor = _constructor;
    public void SetConstructor(IRequestConstructor _constructor) => constructor = _constructor;

    public HttpRequestData BuildBasicRequest()
    {
        constructor.CreateMethod();
        constructor.CreateUrl();
        return constructor.GetRequest();
    }

    public HttpRequestData BuildFullRequest()
    {
        constructor.CreateMethod();
        constructor.CreateUrl();
        constructor.CreateHeaders();
        constructor.CreateBody();
        constructor.CreateTimeout();
        constructor.CreateQueryParams();
        return constructor.GetRequest();
    }

    public HttpRequestData BuildRequestWithHeaders()
    {
        constructor.CreateMethod();
        constructor.CreateUrl();
        constructor.CreateHeaders();
        constructor.CreateTimeout();
        return constructor.GetRequest();
    }
}

// Добавляем класс с Main методом
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Конструктор HTTP запросов ===");

        IRequestConstructor getConstructor = new GetConstructor();
        RequestDirector director = new RequestDirector(getConstructor);
        HttpRequestData getRequest = director.BuildFullRequest();
        Console.WriteLine("\nВаш GET запрос:");
        Console.WriteLine(getRequest.AboutRequest());

        IRequestConstructor postConstructor = new PostConstructor();
        director.SetConstructor(postConstructor);
        HttpRequestData postRequest = director.BuildFullRequest();
        Console.WriteLine("\nВаш POST запрос:");
        Console.WriteLine(postRequest.AboutRequest());

        IRequestConstructor putConstructor = new PutConstructor();
        director.SetConstructor(putConstructor);
        HttpRequestData putRequest = director.BuildRequestWithHeaders();
        Console.WriteLine("\nВаш PUT запрос (с заголовками):");
        Console.WriteLine(putRequest.AboutRequest());

        IRequestConstructor deleteConstructor = new DeleteConstructor();
        director.SetConstructor(deleteConstructor);
        HttpRequestData deleteRequest = director.BuildBasicRequest();
        Console.WriteLine("\nВаш DELETE запрос (базовый):");
        Console.WriteLine(deleteRequest.AboutRequest());
    }
}