using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    private float inputX; 
    
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        TryMove();
    }

    void GetInput()
    {
        inputX = Input.GetAxisRaw("Horizontal");
    }
    void TryMove()
    {
        _rigidbody2D.linearVelocityX = inputX * speed;
    }
}
