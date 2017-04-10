//------------------------------------------------------------------------------
// Used to create a place where the user can generate their own levels.
//------------------------------------------------------------------------------

public class LevelEditor
{
	public virtual Level level
	{
		get;
		set;
	}

	public virtual Game game
	{
		get;
		set;
	}

	public virtual bool validateLevel()
	{
		throw new System.NotImplementedException();
	}

	public virtual void saveLevel()
	{
		throw new System.NotImplementedException();
	}

	private bool checkForCharacter()
	{
        //PointF point = level.characterLocation();
        //if(point.X < 0)
        //{
        //    return false;
        //}
        return true;
	}

	public LevelEditor(Level level)
	{
        this.level = level;
        game = new Game(level, true);
	}


}

