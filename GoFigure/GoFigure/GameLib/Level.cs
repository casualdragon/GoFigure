//------------------------------------------------------------------------------
// This class represents a file for a level
// for Go Figure.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class Level
{
    public Character character
    {
        get;
        set;
    }
    private string filename
	{
		get;
		set;
	}

	private IEnumerable<GameObject> layout
	{
		get;
		set;
	}

	public virtual IEnumerable<GameObject> loadLevel()
	{
        return null;
        try
        {
            using (StreamReader sr = new StreamReader(this.filename))
            {
                String line = sr.ReadToEnd();
                //DrawImage, probably going to need to do serialization 

                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
            return null;
        }
    }

	public virtual bool saveLevel()
	{
		throw new System.NotImplementedException();
	}

	public virtual IEnumerable<int> checkLocation(int x, int y)
	{
		throw new System.NotImplementedException();
	}

	public Level(string filename)
	{
        this.filename = filename;
        //layout = loadLevel();
        foreach (GameObject gameObject in layout)
        {
            if(gameObject is Character)
            {
                character = (Character)gameObject;
                break;
            }
        }
	}

	private bool checkReadOnly()
	{
		throw new System.NotImplementedException();
	}

	public virtual IEnumerable<GameObject> shapesAroundCharacter()
	{
		throw new System.NotImplementedException();
	}

	public virtual GameObject shapeAt(PointF point)
	{
        foreach (GameObject gameObject in layout)
        {
            if(gameObject.point == point)
            {
                return gameObject;
            }
        }
        return null;
	}

}

