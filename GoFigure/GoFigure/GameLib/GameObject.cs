//------------------------------------------------------------------------------
// This is the class that any object in the game inherits from.
// GameObject may also be used for terrain
//------------------------------------------------------------------------------
using System.Windows.Controls;

public class GameObject : System.Windows.DependencyObject
{
	public Image image
	{
		get;
		set;
	}

	public System.Drawing.PointF point
	{
		get;
		set;
	}

	private bool visible
	{
		get;
		set;
	}

	public bool collision
	{
		get;
		set;
	}

	public GameObject(System.Drawing.PointF point, Image image, bool collision, bool visible)
	{
        this.point = point;
        this.image = image;
        this.collision = collision;
        this.visible = visible;
	}

}

