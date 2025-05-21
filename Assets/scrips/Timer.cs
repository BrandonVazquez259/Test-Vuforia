using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Reflection;
using UnityEngine.Events;
public class Timer : MonoBehaviour
{
    [SerializeField]

    private UnityEvent _onTimerComplete;
    [SerializeField]

    private UnityEvent<string> _onSecondPassed;

    private Coroutine _timeCoroutine;
    public void StartTimer(float duration) {
        _timeCoroutine = StartCoroutine(RunTimer(duration));
    }
    private IEnumerator RunTimer(float duration)
    {
        _onSecondPassed?.Invoke(""+(int)duration);
        yield return new WaitForSeconds(duration);
        if (duration == 0)
        {
            _onTimerComplete?.Invoke();
            _timeCoroutine = null;

        }
        else
        {
            _timeCoroutine = StartCoroutine(RunTimer(duration - 1));
        }
    }
    public void StopTimer()
    {
        if (_timeCoroutine != null)
        {
            StopCoroutine(_timeCoroutine);
            _timeCoroutine = null;
        }

    }

}
