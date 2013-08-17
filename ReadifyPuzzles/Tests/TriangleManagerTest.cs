using System;
using NUnit.Framework;

namespace ReadifyPuzzles {
	[TestFixture()]
	public class TriangleManagerTest {

		[Test()]
		public void ValidTestCase () {

			TriangleTypes triangleType = TrianglesManager.GetTriangleType (1.5, 2.0, 1.4);

			Assert.AreEqual (TriangleTypes.Scalene, triangleType);

			triangleType = TrianglesManager.GetTriangleType (5, 5, 4);
			
			Assert.AreEqual (TriangleTypes.Isosceles, triangleType);

			triangleType = TrianglesManager.GetTriangleType (3, 3, 4);
			
			Assert.AreEqual (TriangleTypes.Isosceles, triangleType);

			triangleType = TrianglesManager.GetTriangleType (5, 5, 5);
			
			Assert.AreEqual (TriangleTypes.Equilateral, triangleType);
		}

		[Test()]
		public void InvalidTestCase () {
			
			TriangleTypes triangleType = TrianglesManager.GetTriangleType (0, 1, 1);
			
			Assert.AreEqual (TriangleTypes.Invalid, triangleType);
			
			triangleType = TrianglesManager.GetTriangleType (1, 0, 1);
			
			Assert.AreEqual (TriangleTypes.Invalid, triangleType);
			
			triangleType = TrianglesManager.GetTriangleType (1, 1, 0);
			
			Assert.AreEqual (TriangleTypes.Invalid, triangleType);

			triangleType = TrianglesManager.GetTriangleType (100, 1, 1);
			
			Assert.AreEqual (TriangleTypes.Invalid, triangleType);

			triangleType = TrianglesManager.GetTriangleType (-1, 1, 1);
			
			Assert.AreEqual (TriangleTypes.Invalid, triangleType);
		}
	}
}

