using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed;
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
        //1 input
        float horizontal = Input.GetAxis( "Horizontal" );
        float vertical = Input.GetAxis( "Vertical" );
        Vector3 input = new Vector3(horizontal, 0, vertical);
        //6
        chController.Move(input * Time.deltaTime);
    }
}
