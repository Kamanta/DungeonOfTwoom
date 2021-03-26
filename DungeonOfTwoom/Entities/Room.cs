using System;
using System.Collections.Generic;

public class Room
{
	public string description { get; set; }
	public List<object> doors { get; set; }
	public List<object> roomThings { get; set; }
	public List<object> monsters { get; set; }
	public List<object> NPCs { get; set; }

	public Room() { }
	public Room(string description)
	{
		this.description = description;
	}

	public void printDescription()
    {
		Console.WriteLine(description);
    }

}
