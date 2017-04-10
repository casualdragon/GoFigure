//------------------------------------------------------------------------------
// This is the class where the main game logic is placed.
//------------------------------------------------------------------------------
using System.Timers;

public class Game
{
    private Level level
	{
		get;
		set;
	}

	private Timer thread
	{
		get;
		set;
	}

    public Clock timer
    {
        get;
        private set;
    }

    //This is here for determining if the level is from 
    //the level editor, which is currently being tested
    public bool testing
	{
		get;
		private set;
	}

    //Determines if the character is currently jumping
    //If not, value is false.
    public bool jumping
    {
        get;
        set;
    }

    //If true, the game is over.
    //If false, the game is still going.
    public bool endOfLevel
    {
        get;
        private set;
    }

    public virtual void play()
    {
        update();
        if (thread.Enabled == true)
        {
            thread.Interval = 500;
        }
    }

    //Constructor
	public Game(Level level, bool testing)
	{
        this.level = level;
        this.testing = testing;
        thread = new Timer();
        
	}

    //Determines if the player can move to the next position
	private bool validateNextPosition(GameObject gameObject)
	{
        bool flag = true;
        if (gameObject.collision)
        {
            flag = false;
        }
        if(gameObject is Spike)
        {
            level.character.dead = true;
            endOfLevel = true;
        }
        if(gameObject is PressurePlate)
        {
            //activates the pressure plate
            ((PressurePlate)gameObject).activate();
        }
        if (gameObject is StartEnd)
        {
            if(((StartEnd)gameObject).startOrEnd == true)
            {
                endOfLevel = true;
            }
        }
        return flag;
    }

	private void update()
	{
       
	}

}

