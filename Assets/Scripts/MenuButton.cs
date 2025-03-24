using System.Xml.Serialization;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject MenuPanel;
    bool isActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowMenu()
    {
        MenuPanel.SetActive(true);
        isActive = true;
    }
    public void HideMenu()
    {
        MenuPanel.SetActive(false);
        isActive = false;
    }
}
