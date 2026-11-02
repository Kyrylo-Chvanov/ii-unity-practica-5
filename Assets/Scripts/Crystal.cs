using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Crystal : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = GameObject.FindWithTag("CrystalText").GetComponent<Text>();
    }
    public void SelectEntered()
    {
        text.text = "STOP TOUCHING THE CRYSTAL!!!";
    }

    public void SelextExited()
    {
        text.text = "Do not touch the crystal!";
    }
}
