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

    public virtual void move(int speed, int maxwidth)
    {
        ThicknessAnimation ta;
        Storyboard sb = new Storyboard();
        /*
        if (speed > 0) {
             ta = new ThicknessAnimation(
                new Duration(TimeSpan.FromSeconds(1)),
                new Thickness(point.X, 0, point.Y, 0),
                new Thickness(0),
                 0.9f);
        } else if (speed < 0){
            ta = new ThicknessAnimation(
                new Duration(TimeSpan.FromSeconds(1)),
                new Thickness(point.X, 0, point.Y, 0),
                new Thickness(0),
                DecelerationRatio = 0.9f);
        }
        */
    }
    public virtual void jump(int speed, int height)
    {

    }

    public Character(Image image, System.Drawing.PointF point) : base(point, image, true, true)
	{
        maxSpeed = 100;
        dead = false;
        jumpHeight = 300;
        currentSpeed = 0;
	}

}

