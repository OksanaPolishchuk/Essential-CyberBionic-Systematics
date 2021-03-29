using System.Linq;
using NUnit.Framework;
using Rectangle.Impl;

namespace Rectangle.Tests
{
	public class ServiceTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void FindRectangle()
		{
			var rectangle = Service.FindRectangle(new[] {new Point(10, 8), new Point(14, 7), 
						new Point(33, 8), new Point(7, 8)}.ToList());
			Assert.IsNotNull(rectangle);
		}
	}
}
