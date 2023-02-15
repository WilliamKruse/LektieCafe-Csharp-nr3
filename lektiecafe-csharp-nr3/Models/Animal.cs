using System;
namespace opgave2;

public class Animal
{

	private int Age { get; set; }
	private bool Sick { get; set; } = true;
	public bool Dead { get; set; } = false;
	private int OwnerIQ { get; set; }

	Random rnd = new Random();

	public Animal()
	{
		this.Age = rnd.Next(1,21);
		this.Sick = true;
		this.Dead = false;
		this.OwnerIQ = rnd.Next(20, 120);
	}

	public void CureAnimal()
	{
		//TODO
	}

}

