using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 0.2f;
    float newPosY, movementBottom, movementTop;
    void Start()
    {
        float halfOfHeight = transform.localScale.y/2;
        float bottomOfTheCamera = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y;
        float topOfTheCamera = Camera.main.ViewportToWorldPoint(new Vector2(1 ,1)).y;
        movementBottom =  bottomOfTheCamera + halfOfHeight;
        movementTop = topOfTheCamera - halfOfHeight;  
    }
 
    // Update is called once per frame
    void Update()
    {
        newPosY = GameObject.Find("Circle").transform.position.y * speed;
        newPosY = Mathf.Clamp(newPosY, movementBottom, movementTop);
        transform.position = new Vector2(transform.position.x, newPosY);
    }
}
