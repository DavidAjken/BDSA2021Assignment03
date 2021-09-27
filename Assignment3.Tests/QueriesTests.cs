using System;
using Xunit;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Globalization;

namespace BDSA2020.Assignment03.Tests
{

    public class QueriesTests
    {
      
        public static IEnumerable<Wizard> repo(){
            return Wizard.Wizards.Value;
        }


        [Fact]
        public void RolingWisards_LINQ()
        {
            var expected = new string[]
            {
                "Albus Dumbledore",
                "Hagrid",
                "Harry Potter",
                "Ron Weasley",
                "Hermione Granger",
                "Draco Malfoy",
            };

            var actual = CreatorNameQuerie1<Wizard>(repo());

            Assert.Equal(expected, actual);     
        }

        [Fact]
        public void RolingWisards_ExtensionMethod()
        {
            var expected = new string[]
            {
                "Albus Dumbledore",
                "Hagrid",
                "Harry Potter",
                "Ron Weasley",
                "Hermione Granger",
                "Draco Malfoy",
            };

            var actual = CreatorNameQuerie2<Wizard>("Rowling",repo());

            Assert.Equal(expected, actual);     
        }

        [Fact]
        public void SithLordFistAppearance_LINQ()
        {
        //Arrange
            var expected = 1977;
        //Act
            var actual = FirstYearAppearanceOf1<Wizard>("Darth", repo());
        //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SithLordFistAppearance_ExtensionMethod()
        {
        //Arrange
            var expected = 1977;
        //Act
            var actual = FirstYearAppearanceOf2<Wizard>("Darth", repo());
        //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllWizardsFromHarryPotter_LINQ()
        {
            var expected = new (string,int)[]
            {
                ("Albus Dumbledore", 1997),
                ("Hagrid", 1997),
                ("Harry Potter", 1997),
                ("Ron Weasley", 1997),
                ("Hermione Granger", 1997),
                ("Draco Malfoy", 1997),
            };

            var actual = NameAndYearFromMedium1<Wizard>("Harry Potter",repo());

            Assert.Equal(expected, actual);     
        }

        [Fact]
        public void AllWizardsFromHarryPotter_ExtensionMethod()
        {
            var expected = new (string,int)[]
            {
                ("Albus Dumbledore", 1997),
                ("Hagrid", 1997),
                ("Harry Potter", 1997),
                ("Ron Weasley", 1997),
                ("Hermione Granger", 1997),
                ("Draco Malfoy", 1997),
            };

            var actual = NameAndYearFromMedium2<Wizard>("Harry Potter",repo());

            Assert.Equal(expected, actual);     
        }

        [Fact]
        public void AllWizardsWithCreatorName()
        {
        //Given
        
        //When
        
        //Then
        }










        
    }
}
