using UnityEngine;

public class scr : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float g = Input.GetAxis("Horizontal");
        float e = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(g, 0f, e);
        rb.linearVelocity = movement * speed;
    }
}