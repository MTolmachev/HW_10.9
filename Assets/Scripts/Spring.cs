using UnityEngine;

public class Spring : MonoBehaviour {
    private Rigidbody SpringRigidbody;
    [SerializeField] float _force = 25;

    void Start() {
        SpringRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SpringRigidbody.AddForce(0, _force * 1000, 0);
    }
}
