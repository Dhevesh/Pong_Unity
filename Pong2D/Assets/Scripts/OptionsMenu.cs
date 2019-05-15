using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OptionsMenu : MonoBehaviour
{
    public void DifficultySelector()
    {
        string componentName;

        componentName = this.GetComponent<Toggle>().name;

        switch (componentName)
        {
            case "Toggle_Easy":
                break;
            case "Toggle_Medium":
                break;
            case "Toggle_Hard":
                break;

        }
    }

}
