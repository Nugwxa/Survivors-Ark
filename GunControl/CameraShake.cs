using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // A coroutine to shake the camera for a specified duration and magnitude
    public IEnumerator Shake(float duration, float magnitude)
    {
        // Save the original position of the transform
        Vector3 originalPos = transform.localPosition;

        // Initialize the elapsed time to 0
        float elapsed = 0.0f;

        // Loop until the elapsed time is greater than or equal to the duration
        while (elapsed < duration)
        {
            // Generate random values for x and y within a specified range and multiply them by the magnitude
            float x = Random.Range(0.416f, 0.476f) * magnitude;
            float y = Random.Range(0.671f, 0.691f) * magnitude;

            // Update the local position of the transform using the new x and y values and the original z value
            transform.localPosition = new Vector3(x, y, originalPos.z);

            // Update the elapsed time by adding the time since the last frame
            elapsed += Time.deltaTime;

            // Pause the coroutine for one frame
            yield return null;
        }

        // When the loop finishes, reset the local position of the transform back to its original position
        transform.localPosition = originalPos;
    }
}
