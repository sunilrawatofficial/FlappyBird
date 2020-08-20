using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePIpe : MonoBehaviour
{
    public float pipeMovingSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeMovingSpeed * Time.deltaTime;
    }
}
