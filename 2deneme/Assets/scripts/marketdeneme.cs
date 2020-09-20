using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class marketdeneme : MonoBehaviour
{
    public Player player;

    public GameObject[] ships;

    public GameObject currentShip;

    public GameObject Market;

    public int currentShipNum;

    void Start()
    {
        player.loadData();
        currentShip = Instantiate(ships[player.currentShip], player.transform);
        currentShip.transform.parent = player.transform;
    }

    public void OpenMarket()
    {
        Market.SetActive(true);
    }

    public void setShip0()
    {
        if (player.currentShip != 0)
        {
            Destroy(currentShip);
            player.currentShip = 0;
            player.saveData();
            currentShip = Instantiate(ships[0], player.transform);
            currentShip.transform.parent = player.transform;
        }
    }

    public void setShip1()
    {
        if (currentShip != ships[1])
        {
            Destroy(currentShip);
            player.currentShip = 1;
            player.saveData();
            currentShip = Instantiate(ships[1], player.transform);
            currentShip.transform.parent = player.transform;
        }
    }
}
