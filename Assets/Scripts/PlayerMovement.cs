using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{ 
    bool alive = true;
    public float speed = 5f;
    public GameObject Gameovr;
    public Animator playerAnimator;
    
    public Rigidbody rb;

    private float horizontalInput;

    public float horizontalMultiplier = 2;
    private bool _tapToStart;
    private void FixedUpdate()
    {
        if (!alive || !_tapToStart) return;
        
        
        UnityEngine.Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        UnityEngine.Vector3 horizontalMove = transform.right *horizontalInput *  speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        Vector3 playerPos = transform.position;
        
        transform.position = playerPos;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !_tapToStart )
        {
            _tapToStart = true;
            playerAnimator.SetTrigger("Run");
        }
        horizontalInput = Input.GetAxis("Horizontal");
        
        if (transform.position.y < -5)
        {
            Die();
        }
       
    }

    private bool animControl;
    public void Die ()
    {
        
        if (!animControl)
        {
            animControl = true;
            playerAnimator.SetTrigger("Die");
            Gameovr.gameObject.SetActive(true);
            alive = false;
        }
       
            
        
        
        
    }

     public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }
}
