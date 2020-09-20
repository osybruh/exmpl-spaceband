using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public float speed;

    private Vector2 bounds;

    void Start()
    {
        bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.y < -bounds.y * 2 | Mathf.Abs(transform.position.x) > bounds.x * 2)
        {
            Destroy(this.gameObject);
        }
    }
}