using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    
    [FormerlySerializedAs("Speed")] 
    public float speed = 100;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(speed, 0, 0, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    private void Update()
    { 
        _rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
