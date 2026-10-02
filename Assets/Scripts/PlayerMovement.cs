using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private CharacterController chController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      chController= GetComponent<CharacterController>();
      
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
       
    }
    private void Move()
    {
       
        float horizontal = Input.GetAxis( "Horizontal" );
        float vertical = Input.GetAxis( "Vertical" );

        Vector3 input = new Vector3(horizontal, 0, vertical);

        Vector3 targetVelocity = input * moveSpeed;
       
        input = Vector3.ClampMagnitude(input, 1.0f );
        
        chController.Move( targetVelocity * Time.deltaTime);
    }
}
