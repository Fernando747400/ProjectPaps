using UnityEngine;
using UnityEngine.SceneManagement;

public class ThePowerOfTheMoney : MonoBehaviour
{
    public SequenceManager sequenceManager;
    public FloatVariable money;

    public float threshHold;

    public float MaxMoney, MinMoney;

    public string sceneToLoadBranchOne;
    public string sceneToLoadBranchTwo;
    public string sceneToLoadBranchThree;


    void Update()
    {
        if(money.Value < MinMoney)
        {
            sequenceManager.branchA = sceneToLoadBranchOne;
        }
        //En caso de existir una tercera Ramificación de la historia
        if (money.Value >= MinMoney && money.Value < MaxMoney)
        {
            sequenceManager.branchB = sceneToLoadBranchThree;
        }
        if (money.Value >= MaxMoney)
        {
            sequenceManager.branchC = sceneToLoadBranchTwo;
        }
    }
}
