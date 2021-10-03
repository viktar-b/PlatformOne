using System;
using System.Text;

namespace PlatformOne
{
    class MazeDrawer
    {
        Cell[] cells;
        int width;
        int height;
        int noOfHorizontalElements;

        public string[] CreateConsoleMaze(Maze maze) 
        {
            //Console.WriteLine(maze.cells[i].ToString());
            this.cells = maze.Cells;
            this.width = maze.Width;
            this.height = maze.Height;
            this.noOfHorizontalElements = width*2+1; 
            
            string[] consoleMaze = new string[height*2+1];
            
            consoleMaze[0] = new string('#', noOfHorizontalElements);
            
            for (int row = 0; row < height; row++) 
            {
                consoleMaze[2*row + 1] = CreateMidLine(row);
                consoleMaze[2*row + 2] = CreateBotLine(row);
            }
            
            return consoleMaze;
        }

        private string CreateMidLine(int row)
        {
            char[] sideEdge = new char[noOfHorizontalElements];

            for (int i = 0; i < width; i++) 
            {
                sideEdge[2*i+1] = ' ';

                if (cells[width*row + i].left) 
                    sideEdge[2*i] = '#';
                else 
                    sideEdge[2*i] = ' ';
                
                if (cells[width*row +i].right) 
                    sideEdge[2*i+2] = '#';
                else 
                    sideEdge[2*i+2] = ' ';
            }
            
            //create openings at top-left and bot-right
            if (row == 0) 
                sideEdge[0] = ' ';
            if (row == height - 1)
                sideEdge[noOfHorizontalElements-1] = ' ';            

            return new string(sideEdge);
        }

        private string CreateBotLine(int row) 
        {
            char[] botEdge = new char[noOfHorizontalElements]; 

            for (int i = 0; i < width; i++) 
            {
                if (cells[width*row + i].bot) 
                {
                    botEdge[2*i  ] = '#';
                    botEdge[2*i+1] = '#';
                    botEdge[2*i+2] = '#';
                }
                else
                {
                    if (botEdge[2*i  ] != '#') botEdge[2*i  ] = ' ';
                    if (i==0) botEdge[2*i] = '#';
                    
                    botEdge[2*i+1] = ' ';

                    if (botEdge[2*i+2] != '#') botEdge[2*i+2] = ' ';
                    if (i==width-1) botEdge[2*i+2] = '#';
                }
            }

            return new string(botEdge);
        }
    }
}
