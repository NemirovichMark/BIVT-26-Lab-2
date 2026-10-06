namespace Lab2test
{
    [TestClass]
    public sealed class BlueTest
    {
        Lab2.Blue _main = new Lab2.Blue();
        const double E = 0.0001;

        [TestMethod]
        public void Test1()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 10, 10, 10, 10, 11, 12, 15 };
            var input2 = new double[] { 0.1, 0.2, 0.3, -0.1, -0.2, 0.78, -0.95, 1.5, 2.87, -1.42 };
            var answer = new double[] {
                0.099833,
                2.145761,
                10.881294,
                769719668.812040,
                1460720.346314,
                8.637580,
                -0.712128,
                0.741182,
                0.149642,
                -0.578338
            };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task1(input[i], input2[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test2()
        {
            // Arrange
            var input = new int[] {       0,  1,   2,           3,         5,        10,        11,        12,         15,       20 };
            var answer = new double[] { 0, -5, 7.5, -13.333333, -13.333333, -0.135961, -1.359208, -0.849522, -0.998881, -0.993254 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task2(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test3()
        {
            // Arrange
            var input = new int[] {   0, 1, 2,  3,  10,  11,  12,   25 };
            var answer = new long[] { 0, 0, 1, 2, 88, 143, 232, 121392 };
            var test = new long[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task3(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test4()
        {
            // Arrange
            var input = new int[,] { 
                { 0, 10, 1, 2, 3, 1, 10, 10, 10, 11, 12 },
                { 1,  2, 1, 2, 30, 10, 10, 5, 7, 13, 21 },
                { 10, 10, 10, 10, 100, 100, 100, 100, 1000, 1000, 1000 }
            };
            var answer = new int[] { 5, 1, 4, 2, 3, 4, 4, 5, 16, 12, 9 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task4(input[0,i], input[1,i], input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new double[] { 1.01, 1.1, 2.2, 3.3, -1.1, -2.2, 2.78, -2.95 };
            var answer = new double[] { 1020099.989103, 1209.998819, 2.800807, 0.894972, 0, 0, 1.370236, 0 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test6()
        {
            // Arrange
            var input = new int[,] {
                { 1, 1, 1, 2, 3, 5, 10, 10, 10, 11, 12 },
                { 1, 1, 1, 2, 30, 10, 10, 5, 7, 13, 21 },
                { 10, 20, 100, 200, 300, 1000, 1000, 1000, 10000, 11000, 12000 }
            };
            var answer = new double[] { 4, 5, 7, 14, 12, 35, 70, 80, 110 , 110, 120 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task6(input[0, i], input[1, i], input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test7()
        {
            // Arrange
            var input = new double[,] {
                {   1, 1,   1, 2,  3,   10,   10,  10, 10, 110,  12 },
                { 0.1, 1, 1.5, 1, 33, 27.8, 2.95, 0.1, 10, 12.3, 12 }
            };
            var answer = new (double a, int b, int c)[] {
                (7.021035, 96, 3740),
                (7.213535, 70, 376),
                (7.322994, 62, 252),
                (14.427070, 41, 306),
                (57.831074, 9, 10),
                (164.324272, 6, 6),
                (76.508733, 9, 50),
                (70.210350, 10, 1436),
                (94.871710, 8, 16),
                (1120.091775, 1, 0),
                (121.068141, 7, 12) };
            var test = new (double a, int b, int c)[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task7(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].a, test[i].a, E);
                Assert.AreEqual(answer[i].b, test[i].b);
                Assert.AreEqual(answer[i].c, test[i].c);
            }
        }
        [TestMethod]
        public void Test8()
        {
            // Arrange
            var input = new double[,] {
                { 0,    0.1,  0.1,  0.01,  0,  0,    0.1,  0.1,  0.1 },
                { 0.1,  0.2,  0.2,  0.1,   1,  0.5,  0.99, 0.5,  0.99 },
                { 0.01, 0.01, 0.02, 0.01, 0.1, 0.05, 0.09, 0.05, 0.01 }
            };
            var answer = new (double, double)[] {
                (11.116135, 11.116136),
                (11.793435, 11.793437),
                (6.436139, 6.436141),
                (10.116135, 10.116136),
                (31.986152, 31.986178),
                (14.321979, 14.321990),
                (25.717406, 25.717430),
                (12.314463, 12.314474),
                (258.187350, 258.187527)
            };
            var test = new (double, double)[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task8(input[0, i], input[1, i], input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Item1, test[i].Item1, E * 10);
                Assert.AreEqual(answer[i].Item2, test[i].Item2, E * 10);
            }
        }
    }
}
