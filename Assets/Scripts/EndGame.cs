using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 5f;
    [SerializeField]
    private float timeElapsed;
    public Animator animator;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            animator.SetTrigger("Transition");
        }
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(2);
    }
}
