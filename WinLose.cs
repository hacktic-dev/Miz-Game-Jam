using Godot;
using System;

public class WinLose : Label
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		if(Global.win)
		{
			Text = "You Win!";
		}
		else { Text = "You Lose!"; }
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
