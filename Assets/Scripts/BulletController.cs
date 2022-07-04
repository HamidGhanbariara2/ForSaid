using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Target"))
        {
            var scoreControllerText = GameObject.FindObjectOfType<ScoreController>().GetComponent<Text>();
            scoreControllerText.text = "Score: 150";
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
