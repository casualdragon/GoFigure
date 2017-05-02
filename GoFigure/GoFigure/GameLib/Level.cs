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
        try
        {
            using (StreamReader sr = new StreamReader(this.filename))
            {
                var x = new System.Xml.Serialization.XmlSerializer(GetType(this));
                //Maybe GameObject instead?
                //this = (Level)(x.Deserialize(sr));
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
            return null;
        }
        return null;
    }

	public virtual bool saveLevel()
	{
        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(GetType(this));
        return true;
	}

    private Type GetType(Level level)
    {
        throw new NotImplementedException();
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

