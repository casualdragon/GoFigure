//------------------------------------------------------------------------------
// This class inherits from GameObject.
// This is used to determine if nothing is 
// located at this point in the game
//------------------------------------------------------------------------------
using System.Drawing;

public class Empty : GameObject
{
	public Empty(PointF point) : base(point, null,false, false)
	{
	}

}

