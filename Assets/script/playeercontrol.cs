using UnityEngine;

public class playeercontrol : MonoBehaviour
{
    public float speed;
    public float rangeX;
    public GameObject food;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if (transform.position.x > rangeX)
        {
            transform.position =
                new Vector3(rangeX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -rangeX)
        {
            transform.position =
                new Vector3(-rangeX, transform.position.y, transform.position.z);
                 
        }

        //Throw food
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position, Quaternion.identity);
        }


    }
}
