using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool followPlayer = true;
    
    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            transform.position = new Vector3(transform.position.x, GameManager.instance.player.transform.position.y, transform.position.z);
        }
    }
}
