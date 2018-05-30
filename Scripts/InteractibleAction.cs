using Academy.HoloToolkit.Unity;
using UnityEngine;

/// <summary>
/// InteractibleAction performs custom actions when you gaze at the holograms.
/// </summary>
public class InteractibleAction : MonoBehaviour
{
    [Tooltip("Drag the Tagalong prefab asset you want to display.")]
    public GameObject ObjectToTagAlong;

    [Tooltip("Drag the Popup prefab asset you want to display.")]
    public GameObject ObjectForPopup;

    void PerformTagAlong()
    {
        if (ObjectToTagAlong == null)
        {
            return;
        }

        // Recommend having only one tagalong.
        GameObject existingTagAlong = GameObject.FindGameObjectWithTag("TagAlong");
        if (existingTagAlong != null)
        {
            return;
        }

        GameObject instantiatedObjectToTagAlong = GameObject.Instantiate(ObjectToTagAlong);

        instantiatedObjectToTagAlong.SetActive(true);

        /* TODO: DEVELOPER CODING EXERCISE 6.b */

        // 6.b: AddComponent Billboard to instantiatedObjectToTagAlong.
        // So it's always facing the user as they move.
        instantiatedObjectToTagAlong.AddComponent<Billboard>();

        // 6.b: AddComponent SimpleTagalong to instantiatedObjectToTagAlong.
        // So it's always following the user as they move.
        instantiatedObjectToTagAlong.AddComponent<SimpleTagalong>();

        // 6.b: Set any public properties you wish to experiment with.
    }

    void PerformPopupPanel()
    {
        if(ObjectForPopup == null)
        {
            return;
        }

        GameObject existingPopup = GameObject.FindGameObjectWithTag("Popup");

        if (existingPopup != null)
        {
            return;
        }

        GameObject instantiatedObjectForPopup = GameObject.Instantiate(ObjectForPopup);

        instantiatedObjectForPopup.SetActive(true);

        instantiatedObjectForPopup.AddComponent<Billboard>();

        instantiatedObjectForPopup.AddComponent<SimpleTagalong>();
    }
}