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
        System.Drawing.PointF p = new System.Drawing.PointF(point.X + horizontalChange, point.Y + verticalChange);
        point = p;
    }

	public PressurePlate(GameObject affected, System.Drawing.PointF point, Image image):base(point,image,false,true)
	{
        affectedShape = affected;
	}

}

