using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        // debug.log ("h=" + moveHorizontal "v=" + moveVertical);
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        Rigidbody2D rbody = this.gameObject.GetComponent<Rigidbody2D>();
        rbody.velocity = movement * speed;
    }
}
