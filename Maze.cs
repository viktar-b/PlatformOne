namespace PlatformOne
{
	public class Maze
	{
		public int Width { get; }
		public int Height { get; }
		public Cell[] Cells { get; }
        
		public Maze(int width, int height)
		{
			this.Width = width; 
			this.Height = height; 
			
			Cells = new Cell[width*height];
			
			for (int i = 0; i < Cells.Length; i++) {
				Cells[i] = new Cell();
			}
		}
		
		public Cell GetCell(int row, int column)
		{
			return Cells[row * Width + column];
		}
	}
}