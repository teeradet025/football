using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 Velocity, Spin;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Kick();
        }
        ApplyMagnusEffect();

    }

    void Kick()
    {
        rb.linearVelocity = Velocity;
        rb.angularVelocity = Spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity);

        rb.AddForce(magnusForce, ForceMode.Force);
    }
}
