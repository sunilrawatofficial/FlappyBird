using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCreator : MonoBehaviour
{
    public float maxTime = 1f;
    public float timer = 0;
    public GameObject PipePrefab;
    public float height;
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(PipePrefab);
            newpipe.transform.position += new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe,7);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
