namespace CSharpBasics.Basics
{
	public class Passing
	{
		private class Book
		{
			public Book(string name)
			{
				Name = name;
			}
			private string Name { get; set; }
		}
		private Book GetBook(string name)
		{
			return new Book(name);
		}

		//Passing Value
		public void PassingValue()
		{
			var book1 = GetBook("Book 1");
			SetBookName(book1, "New Name");
		}

		private void SetBookName(Book book, string name)
		{
			book = new Book(name);
		}


		//Passing Reference
		public void PassingReference()
		{
			var book1 = GetBook("Book 1");
			SetBookName(ref book1, "New Name");
		}

			// you can also use "out" instead of "ref" out assumes that you havent initiated the object yet
		private void SetBookName(ref Book book, string name)  
		{
			book = new Book(name);
		}
	}
}