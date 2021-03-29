
namespace Rectangle.Impl
{
	public sealed class Rectangle
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		/// <summary>
		/// constructor
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		public Rectangle(int x, int y, int height, int width )
		{
			X = x;
			Y = y;
			Height = height;
			Width = width;
		}

		/// <summary>
		/// This is code generation.
		/// Generate Equals and GetHashCode methods overrides when you have a type that should be compared by one or more fields, instead of by object location in memory.
		/// ReferenceEquals methode check argument for null
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return ReferenceEquals(this, obj) || obj is Rectangle other && Equals(other);
		}

		/// <summary>
		/// Override the GetHashCode method to allow a type to work correctly in a hash table. 
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = X;
				hashCode = (hashCode * 397) ^ Y;
				hashCode = (hashCode * 397) ^ Width;
				hashCode = (hashCode * 397) ^ Height;
				return hashCode;
			}
		}
		
		/// <summary>
		/// Сheck for equality of values
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		private bool Equals(Rectangle other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return X == other.X && Y == other.Y && Width == other.Width && Height == other.Height;
		}
	}
}
