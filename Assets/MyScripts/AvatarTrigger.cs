using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Triggers events when a specific GameObject (e.g., Player) enters or exits the trigger zone.
/// Attach this script to a GameObject with a Collider set as "Is Trigger".
/// </summary>
public class AvatarTrigger : MonoBehaviour
{
    [Header("Target Settings")]
    [Tooltip("The specific GameObject (e.g., Player) that will trigger this zone")]
    public GameObject targetObject; // Drag your player GameObject or prefab here

    [Header("Actions On Trigger")]
    [Tooltip("Events to invoke when the target enters the trigger")]
    public UnityEvent onTriggerEnter;

    [Header("Actions On Exit (Optional)")]
    [Tooltip("Events to invoke when the target exits the trigger")]
    public UnityEvent onTriggerExit;

    // Called when another collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log($"{targetObject.name} entered trigger: {gameObject.name}");
            onTriggerEnter?.Invoke();
        }
    }

    // Called when another collider exits the trigger zone
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log($"{targetObject.name} exited trigger: {gameObject.name}");
            onTriggerExit?.Invoke();
        }
    }
}
