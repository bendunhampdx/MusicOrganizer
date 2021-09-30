using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests 
  // : IDisposable
  {
    //   public void Dispose()
    // {
    //   Album.ClearAll();
    // }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {

      //Arrange
      string description = "Nevermind";

      //Act
      Album newAlbum = new Album(description);
      string result = newAlbum.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
  }
}
