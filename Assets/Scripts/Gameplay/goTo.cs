using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goTo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject from;
    public GameObject to;

    public void toGo()
    {
        if (!from.activeSelf)
        {
            to.SetActive(false);
            from.SetActive(true);
        }
        else
        {
            to.SetActive(true);
            from.SetActive(false);
        }
    }
}
