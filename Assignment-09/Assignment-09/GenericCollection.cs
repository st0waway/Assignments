namespace Assignment_09
{
	public class GenericCollection<T>
	{
		private List<T>? items;

		public GenericCollection()
		{
			items = new List<T>();
		}

		public void Set(int index, T item)
		{
			items.Insert(index, item);
		}

		public  T Get(int index)
		{
			return items[index];
		}
	}
}
