using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenApple : Apple
{
    const float moveForceX = 2f;  // Força no eixo X (direita)
    const float moveForceY = -5f; // Força no eixo Y (para baixo)

    private void FixedUpdate()
    {
        // Aplica uma força constante no Rigidbody2D para mover a maçã na direção desejada.
        rigidbody2D.AddForce(new Vector2(moveForceX, moveForceY));
    }
}
