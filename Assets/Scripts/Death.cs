using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Move player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out player))
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            return;
        }
    }
}
