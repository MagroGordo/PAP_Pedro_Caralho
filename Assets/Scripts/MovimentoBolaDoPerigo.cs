using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBolaDoPerigo : MonoBehaviour
{
    public float speed = 3f;
    public float leftLimit = -5f;  // Limite à esquerda
    public float rightLimit = 5f;  // Limite à direita

    private int direction = 1;  // 1 para direita, -1 para esquerda

    void Update()
    {
        // Mova o inimigo na direção atual
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

        // Verifique se atingiu os limites e inverta a direção se necessário
        if (transform.position.x < leftLimit || transform.position.x > rightLimit)
        {
            ChangeDirection();
        }
    }

    void ChangeDirection()
    {
        // Inverta a direção multiplicando por -1
        direction *= -1;
    }
}
