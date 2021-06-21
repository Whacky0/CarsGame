using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Load : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static int LastHighScore;
    // Start is called before the first frame update
    private void OnEnable()
    {
        PlayerData data = SavePoints.LoadPlayer();
        LastHighScore = Mathf.RoundToInt(data.points);
        text.text = Mathf.RoundToInt(data.points).ToString();
    }

}
