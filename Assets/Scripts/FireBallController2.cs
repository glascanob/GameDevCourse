using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController2 : MonoBehaviour
{
    public int moveVel = 5;

    Transform startPosition;

    GameObject currentFireball;

    public GameObject fireBallPrefab;

    // Update is called once per frame
    void Update()
    {
        if(currentFireball == null)
        {
            startPosition = GameManager.instance.spawnPosMovHazard[Random.Range(0, GameManager.instance.spawnPosMovHazard.Length)];
            currentFireball = Instantiate(fireBallPrefab, startPosition.position, Quaternion.identity);
        }
        if (currentFireball.transform.position.x != GameManager.instance.endPosMovHazard.position.x)
        {
            currentFireball.transform.position = Vector3.MoveTowards(currentFireball.transform.position, new Vector3(GameManager.instance.endPosMovHazard.position.x, currentFireball.transform.position.y, currentFireball.transform.position.z), Time.deltaTime * moveVel);
        }
        else
        {
            Destroy(currentFireball);
        }
    }
}
