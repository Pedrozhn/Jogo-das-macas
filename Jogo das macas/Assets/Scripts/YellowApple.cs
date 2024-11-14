using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowApple : Apple
{
    const float moveForceX = -2f;  // For�a no eixo X (esquerda)
    const float moveForceY = -5f;  // For�a no eixo Y (para baixo)

    private void FixedUpdate()
    {
        // Aplica uma for�a constante no Rigidbody2D para mover a ma�� na dire��o desejada.
        rigidbody2D.AddForce(new Vector2(moveForceX, moveForceY));
    }
}
