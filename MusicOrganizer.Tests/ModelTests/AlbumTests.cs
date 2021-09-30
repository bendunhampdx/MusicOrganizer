using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests : IDisposable
  {
      public void Dispose()
    {
      Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("test");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Nevermind";

      //Act
      Album newAlbum = new Album(description);
      string result = newAlbum.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Nevermind";
      Album newAlbum = new Album(description);

      //Act
      string updatedDescription = "In Utero";
      newAlbum.Description = updatedDescription;
      string result = newAlbum.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Album> newList = new List<Album> { };

      // Act
      List<Album> result = Album.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Nevermind";
      string description02 = "In Utero";
      Album newAlbum1 = new Album(description01);
      Album newAlbum2 = new Album(description02);
      List<Album> newList = new List<Album> { newAlbum1, newAlbum2 };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    // [TestMethod]
    // public void GetId_AlbumsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string description = "Nevermind";
    //   Album newAlbum = new Album(description);

    //   //Act
    //   int result = newAlbum.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }
  }
}
