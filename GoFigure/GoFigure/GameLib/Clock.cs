//------------------------------------------------------------------------------
// This class is a timer that counts up in seconds.
// Used to determine the time the user has been in a level.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public class Clock
{
	public int time
	{
		get;
		set;
	}
    private bool stopThread
    {
        get;
        set;
    }

	private Thread thread
	{
		get;
		set;
	}

    //Used to start the clock counting up
	public virtual void startClock()
	{
        thread.Start();
	}

    //Used when the clock should stop counting up
	public virtual void stopClock()
	{
        stopThread = true;
	}

    //Constructor
	public Clock()
	{
        time = 0;
        thread = new Thread(incrementTime);
        stopThread = false;
	}

    //helper function for incrementing time through a thread
    private void incrementTime()
    {
        while (true)
        {
            if (stopThread)
            {
                break;
            }
            Thread.Sleep(1000);
            time++;
        }
    }

}

