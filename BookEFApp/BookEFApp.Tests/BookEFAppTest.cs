using System;
using System.Collections.Generic;
using Bogus;
using BookEFApp.Dal;
using BookEFApp.Models;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BookEFApp.Tests;

[TestClass]
[TestSubject(typeof(BookStoreService))]
public class BookStoreServiceTest
{
    [TestMethod]
    public void Returns10WhenGetAuteursBeforeDateIsCalledWith10AuteursBornBeforeToday()
    {
        //Arrange
        var dalMock = new Mock<IDalBookStore>();
        var bookStoreService = new BookStoreService(dalMock.Object);
        var fakeAuteur = new Faker<Auteur>()
            .RuleFor(a => a.Nom, f => f.Name.FullName())
            .RuleFor(a => a.DateNaissance, f => DateOnly.FromDateTime(f.Date.Past(100, DateTime.Today)))
            .Generate(10);
        dalMock.Setup(d => d.GetAuteurs()).Returns(fakeAuteur);

        //Act
        var result = bookStoreService.GetAuteursBeforeDate(DateOnly.FromDateTime(DateTime.Today));

        //Assert
        Assert.AreEqual(10, result.Count);
    }

    [TestMethod]
    [ExpectedException(typeof(HorsSujetException))]
    public void ThrowHorsSujetExceptionWhenUserInputsDateBefore1900()
    {
        //Arrange
        var dalMock = new Mock<IDalBookStore>();
        var bookStoreService = new BookStoreService(dalMock.Object);
        dalMock.Setup(d => d.GetAuteurs()).Returns(new List<Auteur>());

        //Act
        bookStoreService.GetAuteursBeforeDate(new DateOnly(1899, 1, 1));

        //Assert
        Assert.Fail();
    }
}