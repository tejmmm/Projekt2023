using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmizeniCanvasu : MonoBehaviour
{
    public Canvas canvas;

    [SerializeField]
    GameObject ovladani;

    void Start()
    {
        if (canvas == null)
        {
            Debug.LogError("Odkaz na Canvas není nastaven.");
            return;
        }

        
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(SkryjCanvas);
    }

    void SkryjCanvas()
    {

        canvas.enabled = false;
        //ovladani.SetActive(false);
    }
}
