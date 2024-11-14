using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] int score;
    protected new Rigidbody2D rigidbody2D;

    public int Score { get => score; }

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 1f;  // Configura a gravidade padrão para todas as maçãs.
    }

    // Não há lógica de movimento ou atualização aqui. A física do Rigidbody2D vai cuidar disso.
}
