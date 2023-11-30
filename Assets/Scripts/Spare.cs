using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spare : MonoBehaviour
{
    public Player player;
    public ScoreManager scoreManager;
    public AudioSource backgroundSound;
    public AudioSource deathSound;

    private Vector3 playerStartPoint;
    private Vector3 groundGenerationStartPoint;

    public GroundGenerator groundGenerator;

    public GameObject largeGround;
    public GameObject mediumGround;

    public GameObject gameOverScreen;

    void Start()
    {
        playerStartPoint = player.transform.position;
        groundGenerationStartPoint = groundGenerator.transform.position;
        gameOverScreen.SetActive(false);
        
    }

    void GameOver()
    {
        gameOverScreen.SetActive(true);
        scoreManager.isScoreIncreasing = false;
    }

    void Quit()
    {
        
    }
}
