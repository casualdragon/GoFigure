﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Character : GameObject
{
	private Double maxSpeed
	{
		get;
		set;
	}

	private bool dead
	{
		get;
		set;
	}

	private Double jumpHeight
	{
		get;
		set;
	}

	private Double acceleration
	{
		get;
		set;
	}

	private Double deacceleration
	{
		get;
		set;
	}

	public virtual void increaseSpeed()
	{
		throw new System.NotImplementedException();
	}

	public virtual void decreaseSpeed()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Dead()
	{
		throw new System.NotImplementedException();
	}

	public Character(Image image, PointF point)
	{
	}

	public virtual bool Collison()
	{
		throw new System.NotImplementedException();
	}

}
