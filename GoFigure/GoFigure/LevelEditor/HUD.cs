using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace GoFigure.LevelEditor
{
    public class HUD
    {
        //Declare textures for LevelEditor buttons
        Texture2D panel, newLevel, saveLevel, loadLevel, collisionLayer, loadTiles;
        Vector2 position;

        //Declares a list of buttons
        List<Button> buttons = new List<Button>();

        public HUD(ContentManager Content)
        {
            //Load textures for buttons
            loadTiles = Content.Load<Texture2D>(@"Sprites/grey_button07");
            panel = Content.Load<Texture2D>(@"Sprites/grey_button00");
            newLevel = Content.Load<Texture2D>(@"Sprites/blue_button00");
            saveLevel = Content.Load<Texture2D>(@"Sprites/green_button00");
            loadLevel = Content.Load<Texture2D>(@"Sprites/red_button00");
            collisionLayer = Content.Load<Texture2D>(@"Sprites/yellow_button00");

            //Initializes the position
            position = new Vector2(0, (int)LevelEditor.clientBounds.Y - panel.Height);

            buttons.Add(new NewLevelButton(newLevel, new Vector2(position.X + 25, position.Y + 25)));
            buttons.Add(new SaveLevelButton(saveLevel, new Vector2(position.X + 150, position.Y + 25)));
            buttons.Add(new LoadLevelButton(loadLevel, new Vector2(position.X + 275, position.Y + 25)));
            buttons.Add(new CollisionLayerButton(collisionLayer, new Vector2(position.X + 675, position.Y + 25)));
        }

        public void Update()
        {
            //Loops through the button list
            for (int i = 0; i < buttons.Count; i++)
            {
                //Update button
                buttons[i].Update();

                //Checks to see if clicked
                if (buttons[i].clicked)
                {
                    buttons[i].Effect();
                }
            }
        }

        public void Draw()
        {
            //Draws the panel and buttons
            LevelEditor.batch.Draw(panel, position, Color.White);
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Draw();
            }
        }
    }
}
