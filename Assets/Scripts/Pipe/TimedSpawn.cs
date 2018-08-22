using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour {

    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float pipeSpawnDelay = 2f;

    private float lastExecutionTime = Time.time;

    private void OnEnable()
    {
        StartCoroutine(SampleCoroutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator SampleCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(pipeSpawnDelay);
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }
}
