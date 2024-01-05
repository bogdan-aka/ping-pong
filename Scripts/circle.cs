using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speedX = 3, speedY = 5;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speedX, speedY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
