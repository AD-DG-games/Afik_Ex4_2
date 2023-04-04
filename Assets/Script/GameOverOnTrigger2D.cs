using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] KeyCode KeyCode;
    [SerializeField] ScoreNumber score;
    [SerializeField] int scorePerBlock = 1;

    private void OnTriggerStay2D(Collider2D other) { 
        if (other.tag == triggeringTag && enabled && Input.GetKey(KeyCode)){
            Debug.Log("hittttt!");
            score.AddNumber(scorePerBlock);
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
