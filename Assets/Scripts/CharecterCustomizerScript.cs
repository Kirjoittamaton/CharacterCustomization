using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterCustomizerScript : MonoBehaviour
{

    public GameObject[] hairs;
    public GameObject shirt;
    public GameObject pants;
    public GameObject shoes;

    public Animator uiAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hair(int hairNumber)
    {
        for(int i=0; i<hairs.Length;i++)
        {
            hairs[i].SetActive(false);
        }
        
        hairs[hairNumber].SetActive(true);

    }

    public void Shirt(int hat)
    {
        
    }
    public void OpenWindow()
    {
        uiAnimator.SetTrigger("open");
    }

    public void CloseWindow()
    {
        uiAnimator.SetTrigger("close");
    }
}
