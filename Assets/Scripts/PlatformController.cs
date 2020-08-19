using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public int moveVel = 5;

    Transform startPosition;

    public Transform[] objectSpawnPositions;

    public GameObject coinPrefab;
    public GameObject hazardPrefab;

    GameObject spawnedCoin;
    GameObject spawnedHazard;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != GameManager.instance.endPosition.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(GameManager.instance.endPosition.position.x, transform.position.y, transform.position.z), Time.deltaTime * moveVel);
        }
        else
        {
            if(spawnedCoin != null)
            {
                Destroy(spawnedCoin);
            }

            Destroy(spawnedHazard);
            startPosition = GameManager.instance.spawnPositions[Random.Range(0, GameManager.instance.spawnPositions.Length)];
            transform.position = startPosition.position;

            int coin = Random.Range(0, 3);
            
            switch(coin)
            {
                case 0:
                case 1:
                    spawnedCoin = Instantiate(coinPrefab, objectSpawnPositions[coin].position, Quaternion.identity,transform);
                    break;
                case 2:
                default:
                    break;
            }

            int staticHazard = Random.Range(0, 3);
            int chances = Random.Range(0, 2);

            if(chances > 0)
            {
                spawnedHazard = Instantiate(hazardPrefab, new Vector3(objectSpawnPositions[staticHazard].position.x, objectSpawnPositions[staticHazard].position.y - 1.06f, objectSpawnPositions[staticHazard].position.z), Quaternion.identity, transform);
            }

        }
    }
}
