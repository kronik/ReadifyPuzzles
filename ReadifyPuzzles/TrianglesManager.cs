/************************************************************************************

 Triangles:
 
 Write a function that receives three integer inputs for the lengths of the sides of a 
 triangle and returns one of four values to determine the triangle type:
 
 1. Scalene
 2. Isosceles
 3. Equilateral
 4. Invalid
 
*************************************************************************************/

using System;

namespace ReadifyPuzzles {
	public static class TrianglesManager {
		public static TriangleTypes GetTriangleType (double aSideSize, 
		                                             double bSideSize, 
		                                             double cSideSize) {
			TriangleTypes determinedTriangleType = TriangleTypes.Invalid;

			// Is valid sides for any type of triangle
			if (((aSideSize + bSideSize) <= cSideSize) || 
				((cSideSize + bSideSize) <= aSideSize) ||
				((aSideSize + cSideSize) <= bSideSize)) {
				determinedTriangleType = TriangleTypes.Invalid;
			} else if ((aSideSize == bSideSize) && 
			           (bSideSize == cSideSize)) { // Test for equilateral triangle type: all sides are equal
				determinedTriangleType = TriangleTypes.Equilateral;
			} else if ((aSideSize == bSideSize) || (bSideSize == cSideSize) || 
			           (aSideSize == cSideSize)) { // Any 2 sides should be equal
				determinedTriangleType = TriangleTypes.Isosceles;
			} else { // All 3 sides are different
				determinedTriangleType = TriangleTypes.Scalene;
			}

			return determinedTriangleType;
		}
	}
}

