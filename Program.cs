using WebApplication1.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var games = new List<GameDto>
{
    new GameDto
    {
        Id = 1,
        Name = "Game 1",
        Description = "Description 1",
        ReleaseDate = DateTime.UtcNow,  // Ensure this is correctly set
        Rating = 5
    },
    new GameDto
    {
        Id = 2,
        Name = "Game 2",
        Description = "Description 2",
        ReleaseDate = DateTime.UtcNow,  // Ensure this is correctly set
        Rating = 4
    }
};

app.MapGet("/games", () => Results.Ok(games));

app.MapGet("/games/{id}", (int id) =>
{
    var game = games.FirstOrDefault(g => g.Id == id);
    return game is not null ? Results.Ok(game) : Results.NotFound();
});

app.Run();
