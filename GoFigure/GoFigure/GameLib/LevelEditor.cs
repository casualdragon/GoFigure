//------------------------------------------------------------------------------
// Used to create a place where the user can generate their own levels.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace GoFigure.LevelEditor
{

    public class LevelEditor : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        //Allows png pictures to be drawn using the same settings
        public static SpriteBatch batch
        {
            get;
            set;
        }
        public static Vector2 clientBounds;
        public static Vector2 drawOffset = Vector2.Zero;

        //Declare the GUI
        GoFigure.LevelEditor.HUD hud;

        public LevelEditor()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //Makes the mouse visibile
            this.IsMouseVisible = true;

            //Sets the window size
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 800;
            graphics.ApplyChanges();

            //Sets the bound of client
            clientBounds = new Vector2(Window.ClientBounds.Width, Window.ClientBounds.Height);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            //Creates a new Spritebatch used to draw textures;
            batch = new SpriteBatch(GraphicsDevice);

            //Initializes the HUD
            hud = new GoFigure.LevelEditor.HUD(Content);
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            //Exits the LevelEditor
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            {
                this.Exit();
            }
            hud.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkRed);

            //Starts SpriteBatch call
            batch.Begin();

            //Draw the Hud
            hud.Draw();

            base.Draw(gameTime);

            batch.End();
        }

        /*
        public LevelEditor(Level level)
        {
            this.level = level;
            game = new Game(level, true);
        }

        public virtual Level level
        {
            get;
            set;
        }

        public virtual Game game
        {
            get;
            set;
        }

        public virtual bool validateLevel()
        {
            throw new System.NotImplementedException();
        }

        public virtual void saveLevel()
        {
            throw new System.NotImplementedException();
        }

        private bool checkForCharacter()
        {
            //PointF point = level.characterLocation();
            //if(point.X < 0)
            //{
            //    return false;
            //}
            return true;
        }
        */






    }

}