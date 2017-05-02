using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace GoFigure.LevelEditor
{
    public class ClassLevel

    {
        //Declares array for level/map layer
        public int[,] layer;
        //Declares map and tile size
        int mapWidth, mapHeight, tileWidth, tileHeight;

        public ClassLevel(int mapWidth, int mapHeight, int tileWidth, int tileHeight)
        {
            //Initializing instance variables
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.tileHeight = tileHeight;
            this.tileWidth = tileWidth;
            layer = new int[mapWidth, mapHeight];
        }

        public void SetTiles(int selectedTile)
        {
            Vector2 mouse;
            double mouseMapX, mouseMapY;

            MouseState currentMouseState = Mouse.GetState();

            try
            {
                //Check for tile laying
                if (currentMouseState.LeftButton == ButtonState.Pressed)
                {
                    mouse = new Vector2(currentMouseState.X, currentMouseState.Y);
                    mouseMapX = ((int)mouse.X / tileWidth) + LevelEditor.drawOffset.X;
                    mouseMapY = ((int)mouse.Y / tileHeight) + LevelEditor.drawOffset.Y;
                    if (mouseMapX < mapWidth && mouseMapY < mapHeight && mouseMapX >= 0 && mouseMapY >= 0)
                    {
                        layer[(int)mouseMapX, (int)mouseMapY] = selectedTile;
                    }
                }

                if (currentMouseState.RightButton == ButtonState.Pressed)
                {
                    mouse = new Vector2(currentMouseState.X, currentMouseState.Y);
                    mouseMapX = ((int)mouse.X / tileWidth) + LevelEditor.drawOffset.X;
                    mouseMapY = ((int)mouse.Y / tileHeight) + LevelEditor.drawOffset.Y;
                    if (mouseMapX < mapWidth && mouseMapY < mapHeight && mouseMapX >= 0 && mouseMapY >= 0)
                    {
                        layer[(int)mouseMapX, (int)mouseMapY] = 0;
                    }
                }
            }
            catch
            {
                ;//Currently empty
            }
        }

        public void SaveLayer(System.IO.StreamWriter objectWriter)
        {
            try
            {
                //Writes the array to the text file
                for (int i = 0; i < mapWidth; ++i)
                {
                    for (int j = 0; j < mapHeight; ++j)
                    {
                        objectWriter.WriteLine(layer[i, j]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("There was an error saving the level. " + ex);
            }
        }

        public void LoadLayer(System.IO.StreamReader objectReader)
        {
            try
            {
                //Populates the array
                for (int i = 0; i < mapWidth; ++i)
                {
                    for (int j = 0; j < mapHeight; ++j)
                    {
                        layer[i, j] = Convert.ToInt32(objectReader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("There was an error saving the level. " + ex);
            }
        }
    }
}
