public class Player : MonoBehaviour
{
    public Rigidbody rigidbody3D;

    private float movementSpeed = 5;

    void Awake()
    {
        rigidbody3D = GetComponent<Rigidbody>();
    }
   
    void Start()
    {
        
    }

    
    void fixedUpdate()
    {
        rigidbody3D.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, rigidbody3D.linearVelocity.y, rigidbody3D.linearVelocity.z);

    }

    
}
