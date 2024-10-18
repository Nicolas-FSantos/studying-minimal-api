using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá Mundo");

app.MapPost("/login", (LoginDTO loginDTO) =>{
    if(loginDTO.Email == "teste@teste.com" && loginDTO.Senha == "123456"){
        return Results.Ok("Login bem sucedido");
    }else{
        return Results.Unauthorized();
    }

});


app.Run();
