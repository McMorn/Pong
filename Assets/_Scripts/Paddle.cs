using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1;
    Vector3 playerPos;

	// Update is called once per frame
	void Update ()
    {
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
        playerPos = new Vector3(-20, Mathf.Clamp(yPos, -12.5f, 12.5f));
        gameObject.transform.position = playerPos;
	}
}
