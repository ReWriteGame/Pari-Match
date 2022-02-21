using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private Roulette roulette1;
    [SerializeField] private ScoreCounter scoreCounter;

    public UnityEvent endSpinSlotsEvent;

    private void EndSlot()
    {

            endSpinSlotsEvent?.Invoke();

    }

    private void OnEnable()
    {
        roulette1.endRotateEvent?.AddListener(EndSlot);
    }

    private void OnDisable()
    {
        roulette1.endRotateEvent.RemoveListener(EndSlot);
    }

    public void GetResults()
    {
        if(arrow1.collidedObject.Value == 1)
            scoreCounter.Add(1);
        else  scoreCounter.TakeAway(1);
        
    
    }

}
