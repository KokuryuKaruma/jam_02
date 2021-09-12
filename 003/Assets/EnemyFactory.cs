using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [Header("Set Enemy Prefab")]
    [SerializeField]
    private GameObject enemyPrefab;

    [Header("Set Enemy limit")]
    [SerializeField,Range(5f,10f)]
    private float minlimit = 0f;
    [SerializeField,Range(10f,30f)]
    private float maxlimit = 10f;
    [Header("Set Intervar Min and Max")]
    [Range(1f,3f)]
    [SerializeField]
    private float minTime = 2f;
    [Range(5f,10f)]
    [SerializeField]
    private float maxTime = 5f;

    [Header("Set X Position")]
    [SerializeField,Range(5f,100f)]
    private float xMinPOsition = 0f;
    [SerializeField, Range(5f, 100f)]
    private float xMaxPOsition = 50f;
    [Header("Set Y Position")]
    [SerializeField, Range(5f, 100f)]
    private float yMinPOsition = 0f;
    [SerializeField, Range(5f, 100f)]
    private float yMaxPOsition = 50f;
    [Header("Set Z Position")]
    [SerializeField, Range(5f, 100f)]
    private float zMinPOsition = 0f;
    [SerializeField, Range(5f, 100f)]
    private float zMaxPOsition = 50f;
    
    private float interval;
    
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = GetRandomPosition();

            time = 0;

            interval = GetRandomTime();
        }
    }

    float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    Vector3 GetRandomPosition()
    {
        float x = Random.Range(xMinPOsition, xMaxPOsition);
        float y = Random.Range(yMinPOsition, yMaxPOsition);
        float z = Random.Range(zMinPOsition, zMaxPOsition);
        return new Vector3(x, y, z);
    }
}
