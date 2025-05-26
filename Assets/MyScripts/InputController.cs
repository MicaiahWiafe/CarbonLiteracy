using UnityEngine;
using StarterAssets;

public class InputController : MonoBehaviour
{
    public StarterAssetsInputs inputScript;

    public void EnableInput()
    {
        inputScript.enabled = true;
    }

    public void DisableInput()
    {
        inputScript.enabled = false;
    }
}
