using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;


namespace BDSA2020.Assignment03
{
    public class Queries
    {
         
        public static IEnumerable<string> WizardsByCreator1<Wizard>(string CreatorName,IEnumerable<Wizard> input){
           var carectors =  from i in input
                            where i.Creator.get().Contains(CreatorName)
                            select i.Name;

            return carectors;
        }
        
        // public static IEnumerable<string> WizardsByCreator2<Wizard>(string CreatorName,IEnumerable<Wizard> input){
        //     var ca = input.where(i => i.Creator.Contains(CreatorName));
        //     foreach (var cName in ca)
        //     {
        //         yield return cName.Name;
        //     }
        // }
        // public static int FirstYearAppearanceOf1<Wizard>(string carectorName,IEnumerable<Wizard> input){
        //     var year = from i in input
        //                where i.Name.Equal(carectorName)
        //                select i.Year;

        //     return year;
        // }
       
        // public static int FirstYearAppearanceOf2<T>(string name,IEnumerable<T> input){
        //     throw new NotImplementedException();
        // }
        // public static IEnumerable<(string,int)> NameAndYearFromMedium1<T>(string SeriesName,IEnumerable<T> input){
        //     throw new NotImplementedException();
        // }
        // public static IEnumerable<(string,int)> NameAndYearFromMedium2<T>(string SeriesName,IEnumerable<T> input){
        //     throw new NotImplementedException();
        // }
        // public static IEnumerable<(string,string)> AllWizardsWithCreatorInReversOrder1<T>(IEnumerable<T> input){
        //     throw new NotImplementedException();
        // }
        // public static IEnumerable<(string,string)> AllWizardsWithCreatorInReversOrder2<T>(IEnumerable<T> input){
        //     throw new NotImplementedException();
        // }
        // */
    }
}
