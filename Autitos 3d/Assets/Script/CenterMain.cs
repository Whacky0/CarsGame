using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterMain : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {

            gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane + 20));
        
    }
}
