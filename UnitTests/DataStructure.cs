using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class DataStructure
    {
        private readonly DataStructureProblem.DataStructure _dataStructure;
        public DataStructure()
        {
            this._dataStructure = new DataStructureProblem.DataStructure();
        }
        [Fact]
        public void Queue_Test()
        {
            string expected = "queue";
           
            string actual= this._dataStructure.guessDataStructure(6, new string[,] { { "1", "1" }, { "1", "2" }, { "1", "3" }, { "2", "1" }, { "2", "2" }, { "2", "3" } });

          
            //Assert
            Assert.Equal(expected, actual);


        }


        [Fact]
        public void Stack_Test()
        {
            string expected = "stack";
            
            string actual = this._dataStructure.guessDataStructure(6, new string[,] { { "1", "1" }, { "1", "2" }, { "1", "3" }, { "2", "3" }, { "2", "2" }, { "2", "1" } });
            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Impossible_Test()
        {
            string expected = "impossible";

            string actual = this._dataStructure.guessDataStructure(2, new string[,] { { "1", "1" }, { "2", "2" } });
            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void PeriorityQueue_Test()
        {
            string expected = "priority queue";

            string actual = this._dataStructure.guessDataStructure(7, new string[,] { { "1", "2" }, { "1", "5" }, { "1", "1" }, { "1", "3" }, { "2", "5" }, { "1", "4" }, { "2", "4" } });
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
