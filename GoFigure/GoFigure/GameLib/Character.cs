//------------------------------------------------------------------------------
// This class inherits from GameObject.
// This class is used to represent the player in the game.
// The character speed will determine which direction the character will
// move. 
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Animation;

public class Character : GameObject
{
    // If speed is positive, then move right. 
    // If speed is negative move left.
    public int maxSpeed
	{
		get;
		private set;
	}

	public bool dead
	{
		get;
		set;
	}

	public int jumpHeight
	{
		get;
		private set;
	}

    public int currentSpeed
    {
        get;
        private set;
    }

    public void move(PointF position)
    {
        point = position;

    }
    public virtual void jump()
    {
        PointF p = new PointF(point.X, point.Y + jumpHeight);
        point = p;
    }

    public Character(System.Windows.Controls.Image image, System.Drawing.PointF point) : base(point, image, true, true)
	{
        maxSpeed = 100;
        dead = false;
        jumpHeight = 300;
        currentSpeed = 0;
	}

}

