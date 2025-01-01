using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stable : MonoBehaviour
{
	private Renderer rend;
	public Color stableColor = Color.green;
	private bool colorChanged = false;

	private void Start()
	{
		// Get the Renderer component of the object
		rend = GetComponent<Renderer>();
	}

	void OnTriggerEnter(Collider other)
	{
		// Check to see if Stable tile is yet to be collided with player
		if (other.CompareTag("Player") && !colorChanged)
		{
			// Change Stable color to green
			rend.material.color = stableColor;

			// Invoke AddPoints to increment score
			GameManager.instance.AddPoints();

			// Set tile flag
			colorChanged = true;
		}
	}
}
