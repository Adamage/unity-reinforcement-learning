using UnityEngine;

public class Thruster : MonoBehaviour
{
    public Transform point_of_force;
    public Transform point_of_engine;
    Vector3 direction_of_force;
    float force_range = 100;
    public float current_force;
    public bool isAnimating;
    public ParticleSystem ps;
    public Rigidbody hostBody;

    private void Start()
    {
        direction_of_force = point_of_engine.position - point_of_force.position;
        direction_of_force = direction_of_force.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAnimating)
        {
            ps.Play();
        }
        else
        {
            ps.Pause();
        }

        hostBody.AddForceAtPosition(current_force * direction_of_force, point_of_engine.position);

    }
}
