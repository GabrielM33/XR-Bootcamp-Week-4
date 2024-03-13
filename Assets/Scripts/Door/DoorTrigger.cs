using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject door;
    public Animator doorAnimator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DoorInteractor>())
        {
            //door.SetActive(false);
            doorAnimator.SetTrigger("OpenDoor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<DoorInteractor>())
        {
            door.SetActive(true);
        }
    }
}
