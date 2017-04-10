//------------------------------------------------------------------------------
// This class inherits from GameObject.
// This can be use to alter the behavior of other GameObjects.
// Can be used to create interesting levels.
//------------------------------------------------------------------------------

using System.Windows.Controls;

public class PressurePlate : GameObject
{
	public GameObject affectedShape
	{
		get;
		set;
	}

    public int verticalChange
    {
        get;
        set;
    }

    public int horizontalChange
    {
        get;
        set;
    }

	public virtual void activate()
	{
        //affectedShape.point.X = point.X + horizontalChange;
        //affectedShape.point.Y = point.Y + verticalChange;
	}

	public PressurePlate(GameObject affected, System.Drawing.PointF point, Image image):base(point,image,false,true)
	{
        affectedShape = affected;
	}

}

