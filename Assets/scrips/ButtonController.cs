using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _buttons;
    [SerializeField]
    private string _apperAnimationName;
    [SerializeField]
    private string _desapperAnimationName;
    [SerializeField]
    private float _buttonsAppearDelay;

    public void ShowButtons()
    {
        StartCoroutine(ShowButtonsWhithDelay());
    }
    private IEnumerator ShowButtonsWhithDelay()
    {
        foreach(GameObject button in _buttons)
        {
            button.GetComponent<Animator>().Play(_apperAnimationName);
        yield return new WaitForSeconds(_buttonsAppearDelay);
        }
       

    }
    public void HideButtons()
    {
        foreach (GameObject button in _buttons)
        {
            button.GetComponent<Animator>().Play(_desapperAnimationName);
        }
    }
}
