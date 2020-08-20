using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController1 : MonoBehaviour
{
    public int moveVel = 5;

    Transform startPosition;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != GameManager.instance.endPosMovHazard.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(GameManager.instance.endPosMovHazard.position.x, transform.position.y, transform.position.z), Time.deltaTime * moveVel);
        }
        else
        {
            startPosition = GameManager.instance.spawnPosMovHazard[Random.Range(0, GameManager.instance.spawnPosMovHazard.Length)];
            transform.position = startPosition.position;
        }
    }
}
