using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float jump;

    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        player.transform.position = player.transform.position + new Vector3 (speed * Time.deltaTime, 0, 0);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce (0, jump, 0, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        speed *= -1;
    }
}
