using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = new string[] { "Article Political PLamena_Koycheva", "War_In_Middle_East Content2 Ivan_Ivanov", "Healthier_Life Lifestyle Author3" };


        // Act
        Article result = _article.AddArticles(articles);
        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        string[] article =
         {
            "New_Hair_Style LifeStyle Nona",
            "Amazing_Race LifeStyle Ivan",
            "Forbidden Political Georgi"
        };

        _article = _article.AddArticles(article);
        
        string expected = $"Amazing_Race - LifeStyle: Ivan{Environment.NewLine}" +
            $"Forbidden - Political: Georgi{Environment.NewLine}" +
        $"New_Hair_Style - LifeStyle: Nona";
            




        // Act
        string result = _article.GetArticleList(_article, "title");
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        string[] article =
       {
            "New_Hair_Style LifeStyle Nona",
            "Amazing_Race LifeStyle Ivan",
            "Forbidden Political Georgi"
        };

        _article = _article.AddArticles(article);

        string expected = string.Empty;





        // Act
        string result = _article.GetArticleList(_article, "popcorn");
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
