using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] applePrefabs;

    float timer;
    const float cooldown = 1;

    private void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        timer -= Time.deltaTime;

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

            timer = cooldown;
        }
    }
}

