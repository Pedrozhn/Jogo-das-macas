using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;

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

<<<<<<< HEAD
        if (timer <= 0)
        {
            float appleIndex = Random.Range(0, 1f);

            GameObject appleSelected = null;

            switch (appleIndex)
            {
                case <= 0.5f:
                    appleSelected = applePrefabs[0];
                    break;
                case <= 0.8f:
                    appleSelected = applePrefabs[1];
                    break;
                case > 0.8f:
                    appleSelected = applePrefabs[2];
                    break;
            }

            // Instancia o item coletável na tela
            GameObject newItem = Instantiate(appleSelected, new Vector3(Random.Range(-GameManager.instance.ScreenBounds.x, GameManager.instance.ScreenBounds.x), GameManager.instance.ScreenBounds.y), Quaternion.identity);

            // Certifica-se de que o item gerado tem a interface ICollectable
            ICollectable collectableItem = newItem.GetComponent<ICollectable>();
            if (collectableItem != null)
            {
                // Lógica adicional, se necessário
            }

=======
        // Se o timer atingir zero, spawnar uma maçã e resetar o timer
        if (timer <= 0)
        {
            SpawnApple();
>>>>>>> 32a00762449dc47f5abc8168f08a1649c4410382
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

