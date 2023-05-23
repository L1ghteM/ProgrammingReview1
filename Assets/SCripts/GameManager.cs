using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float playerLives = 3;
    public float playerScore;
    public TextMeshProUGUI playerLivesDisplay;
    public TextMeshProUGUI playerScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerLivesDisplay.text = "Lives: " + playerLives;
    }
}
