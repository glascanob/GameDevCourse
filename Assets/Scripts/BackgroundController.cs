using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;

    public int moveVel = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != endPos.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos.position, Time.deltaTime * moveVel);
        }
        else
        {
            transform.position = startPos.position;
        }
    }
}
