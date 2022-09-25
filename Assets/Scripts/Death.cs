using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Move player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out player))
        {
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
            Destroy(player.gameObject);
        }
        else
        {
            return;
        }
    }
}
