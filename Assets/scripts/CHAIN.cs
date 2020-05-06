using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHAIN : MonoBehaviour
{

	public Transform player;
	public Transform chain_gx;

	public float speed = 2f;

	public static bool IsFired;

	// Use this for initialization
	void Start()
	{
		IsFired = false;
		transform.position = player.position;
	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetButtonDown("Fire1"))
		{
			IsFired = true;
		}

		if (IsFired)
		{
			chain_gx.localScale = chain_gx.localScale + Vector3.up * Time.deltaTime * speed;
		}
		else
		{
			transform.position = player.position;
			chain_gx.localScale = new Vector3(1f, 0f, 1f);
		}

	}
}
