using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform[] spawnPositions;
    public Transform endPosition;

    public int currentScore = 0;

    public Text score;

    public CameraController cam;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        cam = Camera.main.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = currentScore + "";
    }

    public void AddScore()
    {
        currentScore ++;
    }

    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
