using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float ballVelocity = 3000;

    Rigidbody rb;
    bool isPlay;
    int randInt;

	void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        randInt = Random.Range(1, 3);
	}
	
	void Update ()
    {
        if (Input.GetMouseButton(0) && !isPlay)
        {
            transform.parent = null;
            isPlay = true;
            rb.isKinematic = false;
            if (randInt == 1)
            {
                rb.AddForce(new Vector3(ballVelocity, ballVelocity));
            }
            else if (randInt == 2)
            {
                rb.AddForce(new Vector3(-ballVelocity, -ballVelocity));
            }
        }
	}
}
