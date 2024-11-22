using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    private void Update()
    {
        if (target is not null)
        {
            transform.position = 
                new Vector3(target.position.x + offset.x, offset.y, offset.z);
            
        }
    }
}
