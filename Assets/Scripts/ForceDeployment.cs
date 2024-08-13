using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ForceDeployment : MonoBehaviour
{
    public ForceSelection fc;
    public float distanceFromCamera = 10;
    public LayerMask mask;

    public Transform rayStartPoint;

    public LineRenderer line;
    public GameObject reticle;

    public ActionBasedController actionBasedController;

    private void OnEnable()
    {
        if (actionBasedController != null)
        {
            actionBasedController.activateAction.action.performed += OnTriggerPressed;
            actionBasedController.activateAction.action.canceled += OnTriggerReleased;
        }
    }

    private void OnDisable()
    {
        if (actionBasedController != null)
        {
            actionBasedController.activateAction.action.performed -= OnTriggerPressed;
            actionBasedController.activateAction.action.canceled -= OnTriggerReleased;
        }
    }

    private void OnTriggerPressed(InputAction.CallbackContext context)
    {
        RaycastHit hit;

        line.SetPosition(0, rayStartPoint.position);

        if (Physics.Raycast(rayStartPoint.position, rayStartPoint.forward
            , out hit, Mathf.Infinity, mask))
        {
            reticle.SetActive(true);
            line.SetPosition(1, hit.point);
            reticle.transform.position = hit.point;
            var reticleRotation = reticle.transform.rotation;
            reticleRotation = Quaternion.Euler(new Vector3(90, 0, 0));
            reticle.transform.rotation = reticleRotation;
            //if the trigger is presseed deploy the force
            Instantiate(fc.selectedForce, hit.point, Quaternion.identity);

        }
    }

    private void OnTriggerReleased(InputAction.CallbackContext context)
    {
        line.SetPosition(0, Vector3.zero);
        line.SetPosition(1, Vector3.zero);
        reticle.SetActive(false);
    }

}
