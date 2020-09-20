using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int currentShip;

    public int highScore;

    public int coins;

    public PlayerData(Player player)
    {
        currentShip = player.currentShip;

        highScore = player.highScore;

        coins = player.coins;
    }

}
