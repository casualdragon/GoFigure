using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GoFigure.LevelEditor
{
    public class NewLevelButton : Button
    {
        public bool clicked = false;

        public NewLevelButton(Texture2D texture, Vector2 position) : base(texture, position)
        {

        }

        public override void Update()
        {
            clicked = base.clicked;
            base.Update();
        }

        public override void Effect()
        {
            base.Effect();
        }
    }
}
