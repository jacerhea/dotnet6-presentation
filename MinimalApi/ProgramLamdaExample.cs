// // lambda example
// using Microsoft.AspNetCore.Mvc;

// var app = WebApplication.Create(args);
// app.MapGet("/", () => "Hello, World!");

// app.MapGet("/{id}", ([FromRoute] int id,
//                      [FromQuery(Name = "p")] int page,
//                      [FromServices] MyService service,
//                      [FromHeader(Name = "Content-Type")] string contentType) 
//                      => service.GetUser(id));

// app.Run();