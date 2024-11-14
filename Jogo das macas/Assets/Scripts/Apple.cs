using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    const int speed = 5;
    [SerializeField] int score;
    new Rigidbody2D rigidbody2D;

    public int Score { get => score; }

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       

        if(transform.position.y < -GameManager.instance.ScreenBounds.y)
        {
            Destroy(gameObject);
        }
    }
}
