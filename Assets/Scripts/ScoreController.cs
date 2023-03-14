using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour{

    int score = 0;
    public GameController gameController;
    public Text scoreText;
    public static int highScore = 0;

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb"){
            if (score > highScore) {
                highScore = score;
            }
            SceneManager.LoadScene("GameOverScene");
        }

        if(target.tag =="Object")
        {
            Destroy(target.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }
}
