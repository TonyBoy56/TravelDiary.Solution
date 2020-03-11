using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TravelDiary.Models;

namespace TravelDiary.Tests
{
  [TestClass] 
  public class PlaceTests : IDisposable 
  {

    public void Dispose()
    {
      Place.ClearAll();
    }


    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void PlaceList_ReturnsEmptyList_PlaceList()
    {
      //Arrange
      List<Place> newPlace = new List<Place> {};

      //Act
      List<Place> result = Place.Instances;

      //Assert
      CollectionAssert.AreEqual(newPlace, result);
    }
    

    [TestMethod]
    public void PlaceList_ReturnsPlaces_PlaceList()
    {
      //Arrange
      string cityName1 = "Paris";
      string cityName2 = "Sydney";
      Place newPlace1 = new Place(cityName1);
      Place newPlace2 = new Place(cityName2);
      List<Place> newPlace = new List<Place> { newPlace1, newPlace2 };

      //Act
      List<Place> result = Place.Instances;

      //Assert
      CollectionAssert.AreEqual(newPlace, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string cityName = "Las Vegas";
      Place newPlace = new Place(cityName);

      //Act
      int result = newPlace.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      //Arrange
      string cityName1 = "Paris";
      string cityName2 = "Sydney";
      Place newPlace1 = new Place(cityName1);
      Place newPlace2 = new Place(cityName2);

      //Act
      Place result = Place.Find(2);

      //Assert
      Assert.AreEqual(newPlace2, result);
    }
  }
}