public async Task DoRequest()
    {
        IgnoreSSL Client = new IgnoreSSL();
        
        var client = Client.IgnoreSSLA();
        
        //NOTE(picoloto): Use how a HttpClient
        var response = await client.GetAsync(URL)
    }