using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   [SerializeField] KeyCode keyOne;
   [SerializeField] KeyCode keyTwo;
   [SerializeField] Vector3 moveDirection;
   private Rigidbody _rigidbody;


   private void Start()
   {
      _rigidbody = GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {
      if (Input.GetKey(keyOne))
      {
        _rigidbody.velocity += moveDirection;
      }

      if (Input.GetKey(keyTwo))
      {
         _rigidbody.velocity -= moveDirection;
      }

      if (Input.GetKey(KeyCode.R))
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }

      if (Input.GetKey(KeyCode.Q))
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
   }

   private void OnTriggerEnter(Collider other)
   {
      if (CompareTag("Player") && other.CompareTag("Finish"))
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }

      if (CompareTag("Cube") && other.CompareTag("Cube"))
      {
         foreach (Activator button in FindObjectsOfType<Activator>())
         {
            button.CanPush = false;
         }
      }
   }

   private void OnTriggerExit(Collider other)
   {
      if (this.CompareTag("Cube") && other.CompareTag("Cube"))
      {
         foreach (Activator button in FindObjectsOfType<Activator>())
         {
            button.CanPush = true;
         }
      }
   }
}

   