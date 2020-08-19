using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform startPos;

    public int moveVel = 5;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != GameManager.instance.endPosBG.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameManager.instance.endPosBG.position, Time.deltaTime * moveVel);
        }
        else
        {
            transform.position = startPos.position;
        }
    }
}
