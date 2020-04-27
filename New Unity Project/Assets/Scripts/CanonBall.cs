using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = transform.right * -1 * speed;
    }
    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("MyPlayer"))
        {
            Destroy(collision.gameObject);
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
        }
    }
}
