public async Task DoRequest()
    {
        IgnoreSSL Client = new IgnoreSSL();
        
        var client = Client.IgnoreSSLA();
        
        //NOTE(picoloto): Use as an HttpClient
        var response = await client.GetAsync(URL)
    }
