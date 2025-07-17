using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject stone;
    public float maxX;
    public Transform spawnPoint;
    int score = 0;

    public Text scoreText;

    void Start()
    {
        //7.42
        InvokeRepeating("spawnStone", 0.5f, 1f);
        InvokeRepeating("updateScore", 3f, 1f);
    }

    void Update()
    {
        
    }

    void spawnStone()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(stone, spawnPos, Quaternion.identity);

    }

    void updateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
