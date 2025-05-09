﻿using BookEFApp.Dal;
using Microsoft.EntityFrameworkCore;

using var context = new MyDbContext();
context.Database.EnsureCreated();

var auteurs = context.Auteurs.Include(x => x.Livres).ToList();
var livres = context.Livres.Include(x => x.Auteur).ToList();

Console.WriteLine();
Console.WriteLine($"Auteurs : {auteurs.Count}");
foreach (var auteur in auteurs)
{
    Console.WriteLine(auteur);
}

Console.WriteLine();
Console.WriteLine($"Livres : {livres.Count}");
foreach (var livre in livres)
{
    Console.WriteLine(livre);
}

var livresAvecAuteurNeApres1990 = context.Livres
    .Include(x => x.Auteur)
    .Where(x => x.Auteur.DateNaissance > new DateOnly(1990, 12, 31))
    .ToList();

Console.WriteLine();
Console.WriteLine($"Auteurs nés après 1990 : {livresAvecAuteurNeApres1990.Count}");
foreach (var auteur in livresAvecAuteurNeApres1990)
{
    Console.WriteLine(auteur);
}

var livresAvecAuteurNeApres1990_2 = (
    from p in context.Livres
    join a in context.Auteurs on p.AuteurId equals a.Id
    where a.DateNaissance > new DateOnly(1990, 12, 31)
    select p
).ToList();

Console.WriteLine();
Console.WriteLine($"Auteurs nés après 1990 : {livresAvecAuteurNeApres1990_2.Count}");
foreach (var auteur in livresAvecAuteurNeApres1990_2)
{
    Console.WriteLine(auteur);
}
