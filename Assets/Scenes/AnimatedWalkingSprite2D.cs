using Godot;

public partial class Dorf2D : CharacterBody2D
{
	private AnimatedSprite2D _animatedSprite;

	public override void _Ready()
	{
		_animatedSprite = GetNode<AnimatedSprite>("AnimatedSprite");
	}

	public override _Process(float _delta)
	{
		if (Input.IsActionPressed("Left"))
		{
			_animatedSprite.Play("DorfWalkingLeft");
		}
		else
		{
			_animatedSprite.Stop();
		}
	}
}
