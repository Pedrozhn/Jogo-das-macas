using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;

public class Apple : MonoBehaviour, ICollectable
{
    const int speed = 5;
    [SerializeField] int score;
    Rigidbody2D rigidbody2D;

    public int Score { get => score; }

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigidbody2D.velocity = Vector2.up * -speed;

        if (transform.position.y < -GameManager.instance.ScreenBounds.y)
        {
            Destroy(gameObject);
        }
    }

    // Implementação do método Collect da interface ICollectable
    public void Collect()
    {
        // Quando a maçã é coletada, o método é chamado e a pontuação é atualizada
        GameManager.instance.AddScore(score);
        Destroy(gameObject);  // Destruir a maçã após ser coletada
    }
}

//