
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
