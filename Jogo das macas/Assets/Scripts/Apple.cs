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

    // Implementa��o do m�todo Collect da interface ICollectable
    public void Collect()
    {
        // Quando a ma�� � coletada, o m�todo � chamado e a pontua��o � atualizada
        GameManager.instance.AddScore(score);
        Destroy(gameObject);  // Destruir a ma�� ap�s ser coletada
    }
}

//