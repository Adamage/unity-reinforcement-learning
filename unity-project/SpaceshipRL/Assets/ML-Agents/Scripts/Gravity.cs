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
        var versor = direction.normalized;
        float length = direction.magnitude;
        var attractor = attractedTo.GetComponent<Rigidbody>();
        var M = attractor.mass;
        var m = rigidBody.mass;
        var constants = strengthOfAttraction * M * m / Mathf.Pow(length, 2);
        rigidBody.AddForce(versor * constants);
    }





}
