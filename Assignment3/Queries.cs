using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;


namespace BDSA2020.Assignment03
{
    public class Queries
    {
         
        public static IEnumerable<string> WizardsByCreator1(string creatorName, IEnumerable<Wizard> input){
            var characters = (from inp in input
                             where inp.Creator.Contains(creatorName)
                             select inp.Name).Distinct();
            foreach (var charector in characters)
            {
                yield return charector;
            }
        }
        
        public static IEnumerable<string> WizardsByCreator2(string creatorName, IEnumerable<Wizard> input){
            return input.Where(inp => inp.Creator.Contains(creatorName)).Select(inp => inp.Name).Distinct();
        }

        public static int FirstYearAppearanceOf1(string charactersName,IEnumerable<Wizard> input){
            var year = from inp in input
                       where inp.Name.Contains(charactersName)
                       orderby inp.Year ascending 
                       select inp.Year;

            return (int)year.First();
        }
       
        public static int? FirstYearAppearanceOf2(string charactersName, IEnumerable<Wizard> input){
            return input.Where(inp => inp.Name.Contains(charactersName)).OrderBy(inp => inp.Year).First().Year;
        }

        public static IEnumerable<(string,int?)> NameAndYearFromMedium1(string seriesName, IEnumerable<Wizard> input){
            var seriescharacters = (from inp in input
                                   where inp.Medium.Equals(seriesName)
                                   select new{inp.Name, inp.Year}).Distinct();
            foreach (var characters in seriescharacters)
            {
               yield return new (characters.Name, characters.Year);
            }
        }

        public static IEnumerable<(string,int?)> NameAndYearFromMedium2(string seriesName, IEnumerable<Wizard> input){
            var seriescharacters = input.Where(inp=>inp.Medium.Equals(seriesName)).Select(inp => new{inp.Name, inp.Year}).Distinct();
            foreach (var characters in seriescharacters)
            {
               yield return new (characters.Name, characters.Year);
            }
        }

        public static IEnumerable<(string,string)> AllWizardsWithcharactersInReversOrder1(IEnumerable<Wizard> input){
            var characterCreatorPair = (from inp in input
                                       orderby inp.Creator descending
                                       select new{inp.Creator,inp.Name}).Distinct();
            foreach (var pair in characterCreatorPair)
            {
                yield return new (pair.Creator, pair.Name);
            }
        }

        public static IEnumerable<(string,string)> AllWizardsWithcharactersInReversOrder2(IEnumerable<Wizard> input){
            var characterCreatorPair = input.OrderByDescending(inp => inp.Creator).Select(inp => new{inp.Creator,inp.Name}).Distinct();
            foreach (var pair in characterCreatorPair)
            {
                yield return new (pair.Creator, pair.Name);
            }        
        }
        
    }
}
