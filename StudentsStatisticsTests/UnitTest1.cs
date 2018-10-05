using StudentsStatistics;
using Xunit;

namespace StudentsStatisticsTests
{
    public class StudentStatisticsTest
    {
        [Fact]
        public void ParsingisRight()
        {
            // Arrange 
            string expected = "test";
            // Act
            var StudentTest = new Student("5-3]['", "test", "56]54]['", "56]34[5", "]4]435']6");
            //Assert 
            Assert.Equal(expected, StudentTest.Name);

        }

        [Fact]
        public void FromLineTest(){
            //Arrange 
            Student expected = new Student("sfnrngjs","we2534","FWEGWE","WEG W GARG "," EGEWG"); 
            // Act
            string AnyString = "sfnrngjs;we2534;FWEGWE;WEG W GARG;EGEWG";
            Student Resulttest = FromLine(AnyString);

            //Assert 
            Assert.Equal(expected, Resulttest); 



        } 
    }

}
