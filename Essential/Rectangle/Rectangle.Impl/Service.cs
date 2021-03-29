using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle.Impl
{
	public static class Service
	{
		/// <summary>
		/// See TODO.txt file for task details.
		/// Do not change contracts: input and output arguments, method name and access modifiers
		/// </summary>
		/// <param name="points"></param>
		/// <returns>rectangles options</returns>
		public static Rectangle FindRectangle(List<Point> points)
		{
			var copyPoints = points.ToList();

			FindThePoint(copyPoints, out var rightPoint, out _, out _, out _);

			points.Remove(rightPoint); //Delete the point that is outside the rectangle

			FindThePoint(points, out rightPoint, out var highPoint, out var leftPoint, out var lowPoint);

			int x = leftPoint.X;
			int y = lowPoint.Y;
			int height = (int) LengthSide(leftPoint.X, lowPoint.Y, leftPoint.X, highPoint.Y);
			int width = (int) LengthSide(leftPoint.X, lowPoint.Y, rightPoint.X, lowPoint.Y);

			bool chekParam = СheckRectangleParameters(x, y, height, width);

			if (chekParam == false)
			{
				throw new ArgumentException("the input list is invalid");
			}
			return new Rectangle(x, y, height, width);
		}

		/// <summary>
		/// Find the points of the rectangle
		/// </summary>
		/// <param name="points"></param>
		/// <param name="rightPoint"></param>
		/// <param name="highPoint"></param>
		/// <param name="leftPoint"></param>
		/// <param name="lowPoint"></param>
		private static void FindThePoint(List<Point> points, out Point rightPoint, out Point highPoint,
			out Point leftPoint, out Point lowPoint)
		{
			rightPoint = null;
			highPoint = null;
			leftPoint = null;
			lowPoint = null;

			foreach (var thePoint in points)
			{
				if (points.Count() >= 2)
				{
					if (leftPoint == null) leftPoint = thePoint;
					if (rightPoint == null) rightPoint = thePoint;
					if (highPoint == null) highPoint = thePoint;
					if (lowPoint == null) lowPoint = thePoint;

					if (leftPoint.X > thePoint.X) leftPoint = thePoint; // leftmost point
					if (rightPoint.X < thePoint.X) rightPoint = thePoint; // leftmost point
					if (highPoint.Y < thePoint.Y) highPoint = thePoint; // highest point
					if (lowPoint.Y > thePoint.Y) lowPoint = thePoint; // lowest point
				}
			}
		}

		/// <summary>
		/// The formula for calculation the length of the side
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns> length of side</returns>
		private static double LengthSide(int a, int b, int c, int d)
		{
			var length = Math.Sqrt(Math.Pow(a - c, 2) + Math.Pow(b - d, 2));
			return length;
		}

		/// <summary>
		/// Checks the triangles parameters: null and points with the same coordinates
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		/// <returns></returns>
		private static bool СheckRectangleParameters(int x, int y, int height, int width)
		{
			if (x != null && y != null && height != null && width != null || x != y && height != width)
			{
				return true;
			}

			return false;
		}
	}
}
