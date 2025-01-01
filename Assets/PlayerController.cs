using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController: MonoBehaviour {

  private Rigidbody playerRigidbody;

  public float speed = 20f;
  public float jumpForce = 5f;

  // Start is called before the first frame update
  void Start()
  {  
      playerRigidbody = GetComponent<Rigidbody>();
  }

  // Detect collision with other objects
  private void OnTriggerEnter(Collider other)
  {
      // When player collides with vEnemy
      if(other.CompareTag("vEnemy"))
      {
          Die();
      }

      // When player collides with Hazard
      else if(other.CompareTag("Hazard"))
      {
          // Apply a vertical force for jumping
          playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
      }
  }

  void Update()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    
    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    playerRigidbody.AddForce(movement*speed*Time.deltaTime);

    // Check if PC has fallen out of the arena
    if (transform.position.y < GameManager.instance.GetArenaLowerBound())
    {
        Die();
    }
  }

  // Restart game
  private void Die()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}