using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    
    public Player player;

    void Start()
    {
        player = gameObject.GetComponentInParent(typeof(Player)) as Player;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathlyObject")
        {
            player.isDead = true;
        }
    }
}