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
    public class Button
    {
        public bool clicked = false;
        public bool prevClick = false;
        bool hover = false;
        public Vector2 position;
        Texture2D texture;
        Rectangle colBox;

        public Button(Texture2D tex, Vector2 position)
        {
            //Constructor updating instance variables
            this.texture = tex;
            this.position = position;

        }

        public virtual void Update()
        {
            colBox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            //Finds the current mouse position
            MouseState mouse = Mouse.GetState();
            Rectangle mousePosition = new Rectangle(mouse.X, mouse.Y, 1, 1);

            //Finds out if the user's mouse is hovering over button
            if (mousePosition.Intersects(colBox))
            {
                hover = true;
            } else
            {
                hover = false;
            }

            //Finds out if button has been left clicked and it wasn't previous click
            if (mousePosition.Intersects(colBox) && mouse.LeftButton == ButtonState.Pressed && !prevClick)
            {
                clicked = true;
            } else
            {
                clicked = false;
            }

            //clicked saved as prevClick
            prevClick = prevClick || clicked;
        }

        public virtual void Effect()
        {
            //Is overriden by other buttons
        }

        public void Draw()
        {
            //Drawing of button
            if (hover)
            {
                LevelEditor.batch.Draw(texture, position, Color.White);
                LevelEditor.batch.Draw(texture, position, new Color(255, 0, 0, 180));
            } else
            {
                LevelEditor.batch.Draw(texture, position, Color.White);
            }
        }
    }
}
