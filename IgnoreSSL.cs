public class IgnoreSSL : HttpClient
{
    public HttpClientHandler httpClientHandler = new HttpClientHandler();
    
    public HttpClient client {get; set;}

    public void KickSSL(HttpClientHandler client)
    {
        client.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) 
                                                                    => { return true; };
        return;   
    }

    public HttpClient IgnoreSSLA()
    {
        KickSSL(httpClientHandler);
        client = new HttpClient(httpClientHandler);
        return client;
    }

}