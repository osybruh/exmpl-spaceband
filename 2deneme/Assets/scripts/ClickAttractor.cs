using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAttractor : MonoBehaviour
{

    const float G = 6.674f;
    public Rigidbody2D rb;
    
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Attract(position);
        }

    }

    void Attract(Vector2 position)
    {
        Vector2 direction = rb.position - position;
        float distance = direction.sqrMagnitude;

        if (distance >= 0.05f)
        {
            float forceMagnitude = G * (rb.mass * 0.1f) / distance;
            Vector2 force = -direction.normalized * forceMagnitude;
            rb.AddForce(force);
        }
    }
}
