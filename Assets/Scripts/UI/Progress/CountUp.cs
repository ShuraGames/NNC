using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountUp : MonoBehaviour
{
    public void UpCountText(int IntCount){
        GetComponent<TextMeshProUGUI>().text = "+" + IntCount.ToString();
    }

    public void DonwCountText(int IntCount){
        GetComponent<TextMeshProUGUI>().text = "-" + IntCount.ToString();
    }
}
