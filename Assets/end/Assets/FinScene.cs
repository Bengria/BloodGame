using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{
    public GameObject Player;

    public GameObject DialogueCat;
    public GameObject DialogueGod;

    public ParticleSystem explosion;
    public GameObject paper;

    public GameObject TextGodOne;
    public GameObject TextGodTwo;
    public GameObject TextGodThree;
    public GameObject TextGodFour;

    public bool IsDialogue = false;

    public GameObject TextCatOne;

    public int DialougeCount = 0;

    public GameObject BlackScreen;

    public string SceneName;

    // Update is called once per frame
    void Update()
    {
        AnimateScene();
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<Animator>().Play("PlayerStop");
            Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            DialogueGod.SetActive(true);
            TextGodOne.SetActive(true);
            IsDialogue = true;
        }
        

    }
    public void AnimateScene()
    {
        if ((Input.GetKeyDown(KeyCode.E)) & IsDialogue)
        {
            if(DialougeCount == 0)
            {

                 DialogueGod.SetActive(false);
                 TextGodOne.SetActive(false);

                 DialogueGod.SetActive(true);
                 TextGodTwo.SetActive(true);

                 DialougeCount += 1;
            }
            else if(DialougeCount == 1)
            {
                 StartCoroutine("ShowPicture");
            }
            else if(DialougeCount == 2)
            {

                DialogueCat.SetActive(true);
                TextCatOne.SetActive(true);
                DialougeCount += 1;
            }
            else if (DialougeCount == 3)
            {
                DialogueCat.SetActive(false);
                TextCatOne.SetActive(false);

                DialogueGod.SetActive(true);
                TextGodThree.SetActive(true);
                DialougeCount += 1;
            }
            else if (DialougeCount == 4)
            {
                DialogueGod.SetActive(false);
                TextGodThree.SetActive(false);

                DialogueGod.SetActive(true);
                TextGodFour.SetActive(true);
                DialougeCount += 1;
            }
            else if (DialougeCount == 5)
            {
                StartCoroutine("BackToMenu");
            }
        }
    }

    IEnumerator ShowPicture()
    {
        IsDialogue = false;
        DialogueGod.SetActive(false);
        TextGodTwo.SetActive(false);
        explosion.Play();
        paper.SetActive(true);
        yield return new WaitForSeconds(2f);
        DialougeCount += 1;
        IsDialogue = true;
    }

    IEnumerator BackToMenu()
    {
        DialogueGod.SetActive(false);
        TextGodFour.SetActive(false);
        yield return new WaitForSeconds(1f);
        BlackScreen.SetActive(true);
        SceneManager.LoadScene("scena 2");
    }
}
