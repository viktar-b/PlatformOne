namespace PlatformOne
{
    class Launch
    {
        static void Main(string[] args)
        {
            int screenWidth = System.Console.WindowWidth;

            EllersAlgorithm ellersAlgorithm = new EllersAlgorithm(screenWidth/4, screenWidth/8);
            Maze maze = ellersAlgorithm.maze;

            MazeDrawer drawer = new MazeDrawer();
            string[] consoleMaze = drawer.CreateConsoleMaze(maze);

            for (int i = 0; i < maze.Height*2+1; i++) {
                System.Console.WriteLine(consoleMaze[i]);
            }
        }
    }
}
