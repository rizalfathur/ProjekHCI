using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jawab : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            int skor = PlayerPrefs.GetInt("skor")+10;
            PlayerPrefs.SetInt("skor", skor);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
