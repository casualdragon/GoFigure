//------------------------------------------------------------------------------
// This class inheirts from the class GameObject.
// This is used to determine the players location
// at the start of the game and the finish line
// for the player.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

public class StartEnd : GameObject
{
    //Constructor
    StartEnd(Boolean startOrEnd, PointF point): base(point, null, false, true)
    {
        this.startOrEnd = startOrEnd;
    }

    //If startOrEnd is true then the player is at the end
    //If startOrEnd is false then the player is at the starting location
	public bool startOrEnd
	{
		get;
		private set;
	}

}

