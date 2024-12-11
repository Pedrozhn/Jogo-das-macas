using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;

public class Apple : MonoBehaviour, ICollectable
{
    [SerializeField] int score;
    protected new Rigidbody2D rigidbody2D;

    public int Score { get => score; }

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 1f;  // Configura a gravidade padrão para todas as maçãs.
    }

<<<<<<< HEAD
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
=======
    // Não há lógica de movimento ou atualização aqui. A física do Rigidbody2D vai cuidar disso.
>>>>>>> 32a00762449dc47f5abc8168f08a1649c4410382
}

//