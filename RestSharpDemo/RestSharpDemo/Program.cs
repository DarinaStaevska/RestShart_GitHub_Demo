using RestSharp;
using System;
using System.Collections.Generic;
using System.Text.Json;

var client = new RestClient("htpps://api.github.com");

string url = "/repos/DarinaStaevska/postman/issues";
var request = new RestRequest(url);
request.AddBody(new { title = "New Issue from RestSharp" });

var response = await client.ExecuteAsync(request, Method.Post);

Console.WriteLine("STATUS CODE " + response.StatusCode);
Console.WriteLine("STATUS CODE " + response.Content);


