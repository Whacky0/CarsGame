using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    float contador;
    public Animator anim;
    public GameObject menu;
    bool startCont;
    private void OnEnable()
    {
        contador = 3;
        startCont = false;
        Debug.Log("existe");

    }

    // Update is called once per frame
    void Update()
    {


        if ( contador > 0)
        {
            contador -= Time.deltaTime;
            TextMeshProUGUI text = gameObject.GetComponent<TextMeshProUGUI>();
            text.text = Mathf.RoundToInt(contador).ToString();
        }
        else
        {
            Pause.Pausa = false;
            gameObject.SetActive(false);
        }
        
    }
    private void FixedUpdate()
    {
        if (!isPlaying())
        {
            menu.SetActive(false);
        }
    }

    bool isPlaying()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("DisapearMenu") &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }
}
