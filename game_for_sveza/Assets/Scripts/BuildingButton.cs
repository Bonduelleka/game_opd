using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingButton : MonoBehaviour
{
    private TextMeshProUGUI titleText;
    private TextMeshProUGUI xpText;
    private Button Button;

    public void SetData(Building building, Button button)
    {
        Button = button;
        //titleText.text = building.GetName();
        //if (building.IsActive())
        //{
        //    xpText.text = "";
        //}
        //else
        //{
        //    if (building.EnoughXP())
        //    {
        //        button.
        //    }
        //}
    }
}
