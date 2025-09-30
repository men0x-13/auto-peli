using UnityEngine;

public class PlayerCar : MonoBehaviour
{

    public float speed = 10f;

    public float turnSpeed = 50f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * move);

        transform.Rotate(Vector3.up * turn);
    }
}
