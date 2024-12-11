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
        rigidbody2D.gravityScale = 1f;  // Configura a gravidade padr�o para todas as ma��s.
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

    // Implementa��o do m�todo Collect da interface ICollectable
    public void Collect()
    {
        // Quando a ma�� � coletada, o m�todo � chamado e a pontua��o � atualizada
        GameManager.instance.AddScore(score);
        Destroy(gameObject);  // Destruir a ma�� ap�s ser coletada
    }
=======
    // N�o h� l�gica de movimento ou atualiza��o aqui. A f�sica do Rigidbody2D vai cuidar disso.
>>>>>>> 32a00762449dc47f5abc8168f08a1649c4410382
}

//