using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    
    [FormerlySerializedAs("Speed")] 
    public float speed = 1000;
    [FormerlySerializedAs("Movement Speed")]
    public float movementSpeed = 20;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(speed, 0, 0);
    }

    // Update is called once per frame
    private void Update()
    { 
        _rb.AddForce(new Vector3(speed * Time.deltaTime, 0, 0));
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rb.AddForce(new Vector3(0, 0, -movementSpeed * Time.deltaTime), ForceMode.VelocityChange);
        } 
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.AddForce(new Vector3(0, 0, movementSpeed * Time.deltaTime), ForceMode.VelocityChange);
        }
    }
}
