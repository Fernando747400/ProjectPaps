using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThePowerOfTheMoney : MonoBehaviour
{
    [Header("Money scriptable object")]
    public FloatVariable money;

    [Header("Minimun money")]
    public float MinMoney;

    [Header("Maximum money")]
    public float MaxMoney;

    [Header("Branch buttons")]
    public Button minBranchButton;
    public Button maxBranchButton;

    [Header("Optional")]
    public Button middleBranchButton;


    void Update()
    {
        if(money.Value < MinMoney)
        {
            minBranchButton.interactable = true;
            middleBranchButton.interactable = false;
            maxBranchButton.interactable = false;
        }
        //En caso de existir una tercera Ramificación de la historia
        if (money.Value >= MinMoney && money.Value < MaxMoney)
        {
            minBranchButton.interactable = true;
            middleBranchButton.interactable = true;
            maxBranchButton.interactable = false;
        }
        if (money.Value >= MaxMoney)
        {
            minBranchButton.interactable = true;
            middleBranchButton.interactable = true;
            maxBranchButton.interactable = true;
        }
    }
}
