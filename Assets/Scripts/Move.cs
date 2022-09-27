using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float jump;

    private void Awake()
    {
        float r = PlayerPrefs.GetFloat("PlayerColorR");
        float g = PlayerPrefs.GetFloat("PlayerColorG");
        float b = PlayerPrefs.GetFloat("PlayerColorB");
        float a = PlayerPrefs.GetFloat("PlayerColorA");

        Renderer playerColor = GetComponent<Renderer>();

        playerColor.material.color = new Color(r, g, b, a);
    }
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
        player.transform.Rotate(0, 180, 0);
    }
}
