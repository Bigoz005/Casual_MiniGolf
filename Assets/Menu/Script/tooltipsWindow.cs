using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class tooltipsWindow : MonoBehaviour
{
    private void Start()
    {
        transform.Find("1_strike").GetComponent<Button_UI>().MouseOverOnceFunc = () => tooltips.ShowTooltip_Static("Make the first strike");
        transform.Find("1_strike").GetComponent<Button_UI>().MouseOutOnceFunc = () => tooltips.HideTooltip_Static();

        transform.Find("100_strike").GetComponent<Button_UI>().MouseOverOnceFunc = () => tooltips.ShowTooltip_Static("Make 100 strike");
        transform.Find("100_strike").GetComponent<Button_UI>().MouseOutOnceFunc = () => tooltips.HideTooltip_Static();

        transform.Find("1000_strike").GetComponent<Button_UI>().MouseOverOnceFunc = () => tooltips.ShowTooltip_Static("Make 1000 strike");
        transform.Find("1000_strike").GetComponent<Button_UI>().MouseOutOnceFunc = () => tooltips.HideTooltip_Static();
    }
}
