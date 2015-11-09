using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    int randX;
    int randY;

    public GameObject ball;

	void Start ()
    {
        Spawn();
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Spawn();
        }
	}

    void CreateRandomPosition()
    {
        randX = Random.Range(-8, 8);
        randY = Random.Range(-4, 4);
    }

    void Spawn()
    {
        CreateRandomPosition();

        Instantiate(ball, new Vector3(randX, randY), Quaternion.identity);
    }
}
