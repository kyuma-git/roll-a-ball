using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 1.0f;

	// Start is called before the first frame update
	// Script起動直後に呼ばれる
	void Start()
	{
			
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.Getkey(KeyCode.LeftArrow))
		{
			if (this.transform.position.x > -4)
					this.transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.Getkey(KeyCode.RightArrow))
		{
			if (this.transform.position.x < 4)
			this.transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
}
