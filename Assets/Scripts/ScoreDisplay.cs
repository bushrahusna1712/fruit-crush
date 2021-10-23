using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = PlayerPrefs.GetInt("userScore").ToString();
    }
}
