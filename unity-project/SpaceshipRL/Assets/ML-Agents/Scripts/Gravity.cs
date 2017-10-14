using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject attractedTo;
    public float strengthOfAttraction = 5.0f;
    public Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = attractedTo.transform.position - transform.position;
        rigidBody.AddForce(strengthOfAttraction * direction);
    }





}
