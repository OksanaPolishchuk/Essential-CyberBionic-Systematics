
namespace Rectangle.Impl
{
	/// <summary>
	/// Initiate the points
	/// </summary>
	public sealed class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		
		/// <summary>
		/// constructor
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}
