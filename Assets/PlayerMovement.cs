using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

  

    // Start is called before the first frame update
    void Start()
    {
     //   rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a") | Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d") | Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s") | Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        if (Input.GetKey("w") | Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }

    }
}
