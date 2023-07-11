using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    int punteggio = 0;
    float tempoTrascorso = 0f;

    // Update is called once per frame
    public void Update()
    {
        tempoTrascorso += Time.deltaTime;

        if (tempoTrascorso >= 1f)
        {
            punteggio++;
            tempoTrascorso = 0f;
        }

        scoreText.text = punteggio.ToString();
    }
}
