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
                "Draco Malfoy"
            };

            string[] actual = Queries.WizardsByCreator1("Rowling",repo()).ToArray();

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
                "Draco Malfoy"
            };

            string[] actual = Queries.WizardsByCreator2("Rowling",repo()).ToArray();

            Assert.Equal(expected, actual);     
        }

        [Fact]
        public void SithLordFistAppearance_LINQ()
        {
        //Arrange
            var expected = 1977;
        //Act
            var actual = Queries.FirstYearAppearanceOf1("Darth", repo());
        //Assert
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SithLordFistAppearance_ExtensionMethod()
        {
        //Arrange
            var expected = 1977;
        //Act
            var actual = Queries.FirstYearAppearanceOf2("Darth", repo());
        //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllWizardsFromHarryPotter_LINQ()
        {
            var expected = new (string,int?)[]
            {
                ("Albus Dumbledore", 1997),
                ("Hagrid", 1997),
                ("Harry Potter", 1997),
                ("Ron Weasley", 1997),
                ("Hermione Granger", 1997),
                ("Draco Malfoy", 1997),
            };

            IEnumerable<(string,int?)> actual = Queries.NameAndYearFromMedium1("Harry Potter",repo());

            Assert.Equal(expected, actual);     
        }

        [Fact]
        public void AllWizardsFromHarryPotter_ExtensionMethod()
        {
            var expected = new (string,int?)[]
            {
                ("Albus Dumbledore", 1997),
                ("Hagrid", 1997),
                ("Harry Potter", 1997),
                ("Ron Weasley", 1997),
                ("Hermione Granger", 1997),
                ("Draco Malfoy", 1997),
            };

            IEnumerable<(string,int?)> actual = Queries.NameAndYearFromMedium2("Harry Potter",repo());

            Assert.Equal(expected, actual);     
        }

        [Fact]
        public void AllWizardsWithCreatorName_LINQ()
        {
            var expected = new (string,string)[]
            {
                ("Victor Flemming","Oz"),
                ("Scott Derrickson","Stephen Strange"),
                ("Johnny Capps", "Merlin"),
                ("J.R.R. Tolkien","Sauron"),
                ("J.R.R. Tolkien","Gendalf"),
                ("J.K. Rowling","Albus Dumbledore"),
                ("J.K. Rowling","Hagrid"),
                ("J.K. Rowling","Harry Potter"),
                ("J.K. Rowling","Ron Weasley"),
                ("J.K. Rowling","Hermione Granger"),
                ("J.K. Rowling","Draco Malfoy"),
                ("George Lucas","Darth Vader"),
                ("George Lucas","Darth Sidious"),
                ("George Lucas", "Obi-wan Kenobi")
            };

            var actual = Queries.AllWizardsWithcharactersInReversOrder1(repo());

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void AllWizardsWithCreatorName_ExtensionMethod()
        {
               var expected = new (string,string)[]
            {
                ("Victor Flemming","Oz"),
                ("Scott Derrickson","Stephen Strange"),
                ("Johnny Capps", "Merlin"),
                ("J.R.R. Tolkien","Sauron"),
                ("J.R.R. Tolkien","Gendalf"),
                ("J.K. Rowling","Albus Dumbledore"),
                ("J.K. Rowling","Hagrid"),
                ("J.K. Rowling","Harry Potter"),
                ("J.K. Rowling","Ron Weasley"),
                ("J.K. Rowling","Hermione Granger"),
                ("J.K. Rowling","Draco Malfoy"),
                ("George Lucas","Darth Vader"),
                ("George Lucas","Darth Sidious"),
                ("George Lucas", "Obi-wan Kenobi")
            };

            var actual = Queries.AllWizardsWithcharactersInReversOrder2(repo());

            Assert.Equal(expected,actual);
            
        }








        
    }
}
