using System;

namespace PlatformOne
{
	public class EllersAlgorithm
	{
		public Maze maze;
		private Random random = new Random();
		private int width; 
		private int height; 
		private int[] left;
		private int[] right;

		public EllersAlgorithm(int width, int height)
		{
			this.width = width; 
			this.height = height;

			this.left = new int[width];
			this.right = new int[width];

			maze = new Maze(width, height);
			Generate();
		}
		private void Generate()
		{
			for (int col = 0; col < width; col++) {
				left[col] = col;
				right[col] = col;
			}
			CreateAllRows();
			CreateLastRow();
		}

		private void CreateAllRows () 
		{
			for (int row = 0; row < height - 1; row++) {
				for (int col = 0; col < width; col++) {
					if (col != width-1 && col+1 != right[col] && random.NextDouble() < 0.5) {
						right[left[col+1]] = right[col]; 
						left[right[col]] = left[col+1];
						right[col] = col+1; 
						left[col+1] = col;
						
						maze.GetCell(row, col).right = false;
						maze.GetCell(row, col+1).left = false;
					}

					if (col != right[col] && random.NextDouble() < 0.5) {
						right[left[col]] = right[col]; 
						left[right[col]] = left[col];
						right[col] = col;
						left[col] = col;
					} else {
						maze.GetCell(row, col).bot = false;
						maze.GetCell(row+1, col).top = false;
					}
				}
			}
		}

		private void CreateLastRow() 
		{
			for (int col = 0; col < width; col++) {
				if (col != width-1 && col+1 != right[col] && (col == right[col] || random.NextDouble() < 0.5)) {
					right[left[col+1]] = right[col];
					left[right[col]] = left[col+1];
					right[col] = col+1;
					left[col+1] = col;
					
					maze.GetCell(height-1, col).right = false;
					maze.GetCell(height-1, col+1).left = false;
				}
				
				right[left[col]] = right[col];
				left[right[col]] = left[col];
				right[col] = col;
				left[col] = col;
			}
		}
	}
}