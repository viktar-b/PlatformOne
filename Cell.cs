namespace PlatformOne
{
	public class Cell
	{
		public bool top = true;
		public bool bot = true;
		public bool left = true;
		public bool right = true;

		public override string ToString()
		{
			return string.Format("{0} {1} {2} + bot: {3}",
				left 	? 1 : 0, 
				top 	? 1 : 0, 
				right 	? 1 : 0,
				bot 	? 1 : 0
			);
		}
	}
}