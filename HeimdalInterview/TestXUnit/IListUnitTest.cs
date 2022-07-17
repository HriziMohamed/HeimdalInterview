using Utilities;
using System;
using Xunit;
using System.Linq;

namespace TestXUnit
{
    public class IListUnitTest
    {
        private MyList<string> _myList = null;

        public IListUnitTest()
        {
            if (_myList == null)
            {
                _myList = new MyList<string> { "one" };
            }
        }

        [Fact]
        public void Add()
        {
            //arrange
            string a = "two";
            int expected = 2;
            //act
            _myList.Add(a);
            //Assert
            Assert.Equal(expected, _myList.Count);
            Assert.Equal(a, _myList[1]);
        }
        [Fact]
        public void AddExceedListLength()
        {
            //arrange
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            int expected = 8;
            //act
            _myList.Add(two);
            _myList.Add(three);
            _myList.Add(four);
            _myList.Add(five);
            _myList.Add(six);
            _myList.Add(seven);
            _myList.Add(eight);
            _myList.Add(nine);
            //Assert
            Assert.Equal(expected, _myList.Count);
            Assert.Null(_myList.Where(x=>x==nine).FirstOrDefault());
        }
        [Fact]
        public void Clear()
        {
            //arrange
            int expected = 0;
            //act
            _myList.Clear();
            //Assert
            Assert.Equal(expected, _myList.Count);
        }       
         [Fact]
        public void IsReadOnly()
        {
            //arrange
            bool expected = false;
            //act
            //Assert
            Assert.Equal(expected, _myList.IsReadOnly);
        }
        [Fact]
        public void Contains()
        {
            //arrange
            bool expected = true;
            //act

            //Assert
            Assert.Equal(expected, _myList.Contains("one"));
        }
        [Fact]
        public void CopyTo()
        {
            //arrange
            string expected = "one";
            var array = new string[9];
            //act
            _myList.CopyTo(array, 1);
            //Assert
            Assert.Equal(expected, array[1]);
        }
        [Fact]
        public void CopyToNotLongEnough()
        {
            //arrange
            var array = new string[9];
            //act
            _myList.CopyTo(array, 2);
            //Assert
            Assert.Null(array[1]);
        }
        
         [Fact]
        public void IndexOfFoundItem()
        {
            //arrange
            string a = "one";
            int expected = 0;
            //act
           int index= _myList.IndexOf(a);
            //Assert
            Assert.Equal(expected, index);
        }
        [Fact]
        public void IndexOfNotFoundItem()
        {
            //arrange
            string a = "two";
            int expected = -1;
            //act
            int index = _myList.IndexOf(a);
            //Assert
            Assert.Equal(expected, index);
        }
        [Fact]
        public void Insert()
        {
            //arrange
            string a = "item";
            //act
            _myList.Insert(1,a);
            //Assert
            Assert.Equal(a, _myList[1]);
        }
        [Fact]
        public void InsertFilledList()
        {
            //arrange
            string a = "item";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";

            //act
            _myList.Add(two);
            _myList.Add(three);
            _myList.Add(four);
            _myList.Add(five);
            _myList.Add(six);
            _myList.Add(seven);
            _myList.Add(eight);
            _myList.Add(nine);

            _myList.Insert(1, a);
            //Assert
            Assert.Equal(-1, _myList.IndexOf(a));
            Assert.Equal(two, _myList[1]);
        }
        [Fact]
        public void RemoveAt()
        {
            //arrange
            int a = 0;
            int count = 0;
            //act
            _myList.RemoveAt(a);
            //Assert
            Assert.Equal(count, _myList.Count);
            Assert.Null(_myList[0]);
        }
        [Fact]
        public void Remove()
        {
            //arrange
            string a = "one";
            //act
            _myList.Remove(a);
            //Assert
            Assert.Equal(-1, _myList.IndexOf(a));
            Assert.Null(_myList[0]);
        }
    }
}
