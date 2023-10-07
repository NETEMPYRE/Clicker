using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    [SerializeField]
    private ToggleGroup group;
    [SerializeField]
    private Text counter;

    public void OnStart() {

    	Toggle[] toggle = group.GetComponentsInChildren<Toggle>();
	toggle[UnityEngine.Random.Range(0, toggle.Length)].isOn = true;
	counter.text = (int.Parse(counter.text) + UnityEngine.Random.Range(0, toggle.Length)).ToString();
    }
    public void OnRate() {

	string URL = "market://details?id=com.NETEMPYRE.Clicker";
	Application.OpenURL(URL);
    }
}
