using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanScript : MonoBehaviour
{
    private float FanForce = 20;
    private void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        // Transform tr = other.gameObject.GetComponent<Transform>();
        float dist = rb.position.y - transform.position.y;
        float currentY = rb.position.y;
        if (dist < 0) dist *= -1;
        if (dist < 1) dist = 1;
        rb.velocity = new Vector2(rb.velocity.x, FanForce);
    }
}
