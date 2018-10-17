using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterEvent : MonoBehaviour
{
	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
	}

}
