using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] YellowPrefabs;
    [SerializeField] GameObject[] RedPrefabs;
    [SerializeField] GameObject[] GreenPrefabs;

    float timer;
    const float cooldown = 1f;

    private void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            float appleIndex = Random.Range(0f, 1f);
            Debug.Log("Apple Index: " + appleIndex);  // Log para verificar o valor de appleIndex

            GameObject appleSelected = null;

            if (appleIndex <= 0.33f)
            {
                if (RedPrefabs.Length > 0)
                {
                    appleSelected = RedPrefabs[Random.Range(0, RedPrefabs.Length)];
                }
            }
            else if (appleIndex <= 0.66f)
            {
                if (GreenPrefabs.Length > 0)
                {
                    appleSelected = GreenPrefabs[Random.Range(0, GreenPrefabs.Length)];
                }
            }
            else
            {
                if (YellowPrefabs.Length > 0)
                {
                    appleSelected = YellowPrefabs[Random.Range(0, YellowPrefabs.Length)];
                }
            }

            if (appleSelected != null)
            {
                Vector3 spawnPosition = new Vector3(
                    Random.Range(-GameManager.instance.ScreenBounds.x, GameManager.instance.ScreenBounds.x),
                    GameManager.instance.ScreenBounds.y - 1f,  // Ajustado para spawn logo abaixo da borda superior
                    0f
                );

                Debug.Log("Spawning Apple at: " + spawnPosition);  // Log para verificar a posição de spawn

                Instantiate(appleSelected, spawnPosition, Quaternion.identity);
            }

            timer = cooldown;
        }
    }
}
