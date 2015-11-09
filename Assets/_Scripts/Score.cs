using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public TextMesh currSco;
    public GameObject ballPref;
    public Transform paddleObj;

    GameObject ball;
    int score;

	void Update ()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currSco.text = score.ToString();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score++;
            Destroy(ball);
            (Instantiate(ballPref, new Vector3(paddleObj.transform.position.x + 2, paddleObj.transform.position.y), Quaternion.identity) as GameObject).transform.parent = paddleObj;
        }
    }
}
