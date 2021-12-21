using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private CharacterControl chara_control;
	private Vector3 move_Direct;

	public fload speed = 5f;
	private float gravity = 20f;

	public float jump_Force = 10f;
	private float vertical_velocity;
}
