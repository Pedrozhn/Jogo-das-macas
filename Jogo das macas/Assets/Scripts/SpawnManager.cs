using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] applePrefabs;  // Array para armazenar os prefabs das ma��s
    float timer;
    const float cooldown = 1f;  // Tempo entre os spawns

    private void Start()
    {
        // Inicia o timer no in�cio
        timer = cooldown;
    }

    private void Update()
    {
        // Decrementa o timer a cada quadro
        timer -= Time.deltaTime;

        // Se o timer atingir zero, spawnar uma ma�� e resetar o timer
        if (timer <= 0)
        {
            SpawnApple();
            timer = cooldown;
        }
    }

    void SpawnApple()
    {
        // Sorteia um �ndice entre 0 e o n�mero de prefabs dispon�veis (3 ma��s)
        int appleIndex = Random.Range(0, applePrefabs.Length);

        // Seleciona o prefab baseado no �ndice sorteado
        GameObject appleSelected = applePrefabs[appleIndex];

        // Instancia a ma�� em uma posi��o aleat�ria no topo da tela
        Vector3 spawnPosition = new Vector3(
            Random.Range(-GameManager.instance.ScreenBounds.x, GameManager.instance.ScreenBounds.x),
            GameManager.instance.ScreenBounds.y,
            0f
        );

        // Instancia a ma�� selecionada
        Instantiate(appleSelected, spawnPosition, Quaternion.identity);
    }
}
