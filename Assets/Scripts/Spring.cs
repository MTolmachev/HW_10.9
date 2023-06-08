using UnityEngine;

public class Spring : MonoBehaviour {
    private Rigidbody SpringRigidbody;
    [SerializeField] float force;

    void Start() {
        SpringRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SpringRigidbody.AddForce(0, force * 1000, 0);
    }
}
