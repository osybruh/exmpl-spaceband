using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gm;

    public bool isDead;
    
    public int currentShip;

    public int coins;

    public int highScore;

    void Start()
    {
        
        loadData();
    }

    public void saveData()
    {
        SaveSystem.savePlayer(this);
    }

    public void loadData()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        currentShip = data.currentShip;

        coins = data.coins;

        highScore = data.highScore;
    }


}
