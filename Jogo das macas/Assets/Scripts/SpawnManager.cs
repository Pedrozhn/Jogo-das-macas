using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] applePrefabs;  // Array para armazenar os prefabs das maçãs
    float timer;
    const float cooldown = 1f;  // Tempo entre os spawns

    private void Start()
    {
        // Inicia o timer no início
        timer = cooldown;
    }

    private void Update()
    {
        // Decrementa o timer a cada quadro
        timer -= Time.deltaTime;

        // Se o timer atingir zero, spawnar uma maçã e resetar o timer
        if (timer <= 0)
        {
            SpawnApple();
            timer = cooldown;
        }
    }

    void SpawnApple()
    {
        // Sorteia um índice entre 0 e o número de prefabs disponíveis (3 maçãs)
        int appleIndex = Random.Range(0, applePrefabs.Length);

        // Seleciona o prefab baseado no índice sorteado
        GameObject appleSelected = applePrefabs[appleIndex];

        // Instancia a maçã em uma posição aleatória no topo da tela
        Vector3 spawnPosition = new Vector3(
            Random.Range(-GameManager.instance.ScreenBounds.x, GameManager.instance.ScreenBounds.x),
            GameManager.instance.ScreenBounds.y,
            0f
        );

        // Instancia a maçã selecionada
        Instantiate(appleSelected, spawnPosition, Quaternion.identity);
    }
}
