using SquareEqualtion_1;
namespace SquareEqualtion_1Tests
{
    public class SquareEqualtionTest
    {
        
        [Test]
        public void When_equaltion_Two_root()
        {
            //arange
            double a = 1;
            double b = -5;
            double c = 4;
            double[] expected = { 4,1 };

            //act
            SquareEqualtion squareEqualtion = new SquareEqualtion();
            double[] actual = squareEqualtion.GetRoots(a, b, c);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void When_equaltion_One_root()
        {
            //arange
            double a = 3;
            double b = 6;
            double c = 3;
            double[] expected = { -1 };

            //act
            SquareEqualtion squareEqualtion = new SquareEqualtion();
            double[] actual = squareEqualtion.GetRoots(a, b, c);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void When_equaltion_Not_root()
        {
            //arange
            double a = 8;
            double b = 4;
            double c = 11;
            double[] expected = {};

            //act
            SquareEqualtion squareEqualtion = new SquareEqualtion();
            double[] actual = squareEqualtion.GetRoots(a, b, c);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
       
    }
}