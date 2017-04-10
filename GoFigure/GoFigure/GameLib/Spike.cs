//------------------------------------------------------------------------------
// This class inherits from GamObject.
// A spike is a one hit kill for the player.
//------------------------------------------------------------------------------

using System.Windows.Controls;

public class Spike : GameObject
{

	public Spike(System.Drawing.PointF point, Image image):base(point,image,true,true)
	{}

}

