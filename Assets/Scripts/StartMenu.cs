using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject panel;

    private void Start()
    {
        anim = panel.GetComponent<Animator>();
    }

    public void StartGame()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        anim.SetTrigger("button");
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
