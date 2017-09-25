using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticSearchAssignment;
using System.Linq;

namespace ElasticSearchTestCases
{
    [TestClass]
    public class ElasticSearchTestClass
    {
            //[TestMethod]
            //public void AddNewIndexTest()
            //{
            //    ElasticSearch objSearch = new ElasticSearch();

            //    objSearch.AddNewIndex(new Hotel(1, "taj", "India"));
            //    objSearch.AddNewIndex(new Hotel(2, "hyatt", "India"));
            //    objSearch.AddNewIndex(new Hotel(3, "pancham", "India"));
            //    objSearch.AddNewIndex(new Hotel(4, "paradise", "India"));
            //    objSearch.AddNewIndex(new Hotel(4, "ibsis", "India"));
            //    objSearch.AddNewIndex(new Hotel(4, "xyzs", "India"));
            //}


            [TestMethod]
            public void GetResultTest()
            {
                ElasticSearch objSearch = new ElasticSearch();
                var result = objSearch.GetResult("ABC");
                //Assert.IsFalse(result.FirstOrDefault<Hotel>(x => x.Country == "India") != null);
                //Assert.IsFalse(result.FirstOrDefault<Hotel>(x => x.Country == "India") != null);
                //Assert.IsFalse(result.FirstOrDefault<Hotel>(x => x.Country == "India") != null);
            }
        }
}
    
