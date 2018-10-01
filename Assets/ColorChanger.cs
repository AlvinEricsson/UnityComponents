using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color color;
    public float movespeed = 6f;
    public float rotationspeed = 360f;
    public TrailRenderer trailRend;
	
    // Use this for initialization
	void Start ()
    {
        rend.color = color;
        rend.color = new Color(1, 0.25f, 0.33f);

        //transform.position = new Vector3(-5f, transform.position.y);


	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
       
        {
            transform.Rotate(0, 0, -rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-5f * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.green;
            trailRend.startColor = Color.green;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(-8f * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.blue;
            trailRend.startColor = Color.blue;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(2f * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.red;
            trailRend.startColor = new Color(1, 0, 0);
        }

    

		
	}
}
