using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prepinacLevel : MonoBehaviour
{
    [SerializeField]
    GameObject image;
    [SerializeField]
    GameObject testObrazek2;
    // Update is called once per frame

    public void Zobrazeni()
    {

        image.SetActive(false);
        testObrazek2.SetActive(true);
    }
}
