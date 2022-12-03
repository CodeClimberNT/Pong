using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{

    [SerializeField]
    private InputAction upKey;
    //get down key from input system
    [SerializeField]
    private InputAction downKey;
    //get left key from input system

    [SerializeField]
    private float speed = 5;

    [SerializeField]
    private Rigidbody2D MyRigidBody;
    // Update is called once per frame

    private void OnEnable()
    {
        upKey.Enable();
        downKey.Enable();
    }


    void Update()
    {
        //if up key is pressed, move up
        if (upKey.triggered)
        {
            MyRigidBody.velocity = new Vector2(0, speed);
            Debug.Log(MyRigidBody.velocity);
        }
        //if down key is pressed, move down
        if (downKey.triggered)
        {

            MyRigidBody.velocity = -new Vector2(0, speed);
            Debug.Log(MyRigidBody.velocity.y);

        }
        //if no key is pressed, stop moving
        if (!upKey.triggered && !downKey.triggered)
        {
            MyRigidBody.velocity = new Vector2(0, 0);
        }

    }
}
