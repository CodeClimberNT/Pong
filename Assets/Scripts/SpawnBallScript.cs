using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallScript : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ballPrefab);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameObject.Find("Ball(Clone)") == null)
        {
            Instantiate(ballPrefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefab);
        }
    }
}
