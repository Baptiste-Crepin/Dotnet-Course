using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Books.Tests;

[TestClass]
[TestSubject(typeof(Book))]
public class BookTest
{
    [TestMethod]
    public void OneHundredPagesBookShouldTakeThirtySecondsToRead()
    {
        // Arrange
        var book = new Book("Title", "Author", 100, DateOnly.FromDateTime(DateTime.Now), true, Genre.Mystery);

        // Act
        var result = book.ComputeTimeToRead();

        // Assert
        Assert.AreEqual(3000, result);
    }

    [TestMethod]
    public void BookCopyShouldBeEqualToOriginal()
    {
        // Arrange
        var originalBook = new Book("Title", "Author", 100, DateOnly.FromDateTime(DateTime.Now), true, Genre.Mystery);

        // Act
        var copyBook = new Book(originalBook);

        // Assert
        Assert.AreEqual(originalBook.Title, copyBook.Title);
        Assert.AreEqual(originalBook.Author, copyBook.Author);
        Assert.AreEqual(originalBook.NumberOfPages, copyBook.NumberOfPages);
        Assert.AreEqual(originalBook.PublishedOn, copyBook.PublishedOn);
        Assert.AreEqual(originalBook.IsAvailableInStore, copyBook.IsAvailableInStore);
        Assert.AreEqual(originalBook.Genre, copyBook.Genre);
    }

    [TestMethod]
    public void BookShouldReturnReadableString()
    {
        // Arrange
        var publicationDate = new DateOnly(2022, 06, 25);
        var book = new Book("Title", "Author", 100, publicationDate, true, Genre.Mystery);

        // Act
        var result = book.ToString();

        // Assert
        Assert.AreEqual("Title by Author, Genre: Mystery, Pages: 100, Published on: 25/06/2022", result);
    }
}