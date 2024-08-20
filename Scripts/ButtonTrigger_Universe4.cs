using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger_Universe4 : MonoBehaviour
{
    public InputField answer;
    public string actualAns;
    public GameObject door;
    public GameObject door2;
    public GameObject key;
    public GameObject clueImg;
    public AudioSource Correct;
    public AudioSource Incorrect;
    public AudioSource Dooropen;
    [SerializeField] private Animator MyAnimationController;


    public void onSubmit()
    {
        if (answer.text.ToUpper() == actualAns.ToUpper())
        {
            door.SetActive(false);
            if(door2)
            door2.SetActive(false);
            clueImg.SetActive(false);
            
            Debug.Log("You did it!");
            //  MyAnimationController.SetBool("open", true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Correct.Play();
            Dooropen.Play();

            StartCoroutine(ExecuteAfterTime());


        }
        else
        {
            Incorrect.Play();

            Debug.Log(answer.text);
        }
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(3);
        key.SetActive(false);

    }





}