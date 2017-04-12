//------------------------------------------------------------------------------
// This class inherits from GameObject.
// This class is used to represent the player in the game.
// The character speed will determine which direction the character will
// move. 
//------------------------------------------------------------------------------
using System.Windows.Controls;
using System.Windows.Media.Animation;

public class Character : GameObject
{
    // If speed is positive, then move right. 
    // If speed is negative move left.
    private int maxSpeed
	{
		get;
		set;
	}

	public bool dead
	{
		get;
		set;
	}

	private int jumpHeight
	{
		get;
		set;
	}

    private int currentSpeed
    {
        get;
        set;
    }

    public virtual void move()
    {
        System.Drawing.PointF p = new System.Drawing.PointF(point.X + maxSpeed, point.Y);
        point = p; 

    }
    public virtual void jump()
    {
        System.Drawing.PointF p = new System.Drawing.PointF(point.X, point.Y + jumpHeight);
        point = p;
    }

    public Character(Image image, System.Drawing.PointF point) : base(point, image, true, true)
	{
        maxSpeed = 100;
        dead = false;
        jumpHeight = 300;
        currentSpeed = 0;
	}

}

