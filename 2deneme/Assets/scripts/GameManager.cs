using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public float score;

    public Text ScoreText;

    public float scoreCoef;
    private Transform ship;
    private Vector2 bounds;

    public Player player;

    public GameObject DeathScreen;

    public GameObject MainMenu;

    public GameObject Market;

    void Start()
    {
        
        bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        score = 0;
        scoreCoef = 10;
        ScoreText.text = score.ToString();
        Time.timeScale = 0;
    }

    void Update()
    {
        ship = player.transform.GetChild(0);
        score += scoreCoef * Time.deltaTime;
        ScoreText.text = ((int)score).ToString();
        isOffScreen();
        isDead();
    }

    public void Play()
    {
        Time.timeScale = 1;
        MainMenu.SetActive(false);
        Market.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void isOffScreen()
    {
        if (Mathf.Abs(ship.transform.position.x) > bounds.x + 0.2f | Mathf.Abs(ship.transform.position.y) > bounds.y + 0.2f)
        {
            player.isDead = true;
        }
    }
        
    public void isDead()
    {
        if (player.isDead)
        {
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }
}
