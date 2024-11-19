using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
        public float gravityModifer = 5.0f;
        public float jumpForce = 10f;
        public bool isOnGround = true;
        private Animator playerAnim;
        // Start is called before the first frame update
    
    void Start()
    {   
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifer;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isOnGround=false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision) {
        isOnGround = true;
    }
            
            
    
}
