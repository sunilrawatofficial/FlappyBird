using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BirdController : MonoBehaviour
{
    #region[var ]
    public float birdVelocity = 1;
    private Rigidbody2D birdRigidBody;
    #endregion

    #region[Monobehaviour Methods]
    private void Awake()
    {
        birdRigidBody =gameObject.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
  // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //jump
            birdRigidBody.velocity = Vector2.up * birdVelocity;   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.GameManagerInstance.Gameover();
    }
    #endregion
}
