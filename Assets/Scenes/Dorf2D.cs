using Godot;
using System;

public partial class Dorf2D : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 400;

	public void GetInput()
	{

		Vector2 inputDirection = Input.GetVector("Left", "Right", "Up", "Down");
		Velocity = inputDirection * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();
	}
}

public partial class Dorf2D : CharacterBody2D
{
	private AnimatedSprite2D _animatedSprite;

	public override void _Ready()
	{
		_animatedSprite = GetNode<AnimatedSprite>("AnimatedSprite");
	}

	public override _Process(float _delta)
	{
		if (Input.IsActionPressed("Walk Right"))
		{
			_animatedSprite.Play("DorfWalkingLeft");
		}
		else
		{
			_animatedSprite.Stop();
		}
	}
}
