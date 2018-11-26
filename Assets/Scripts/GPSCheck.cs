using System.Collections;
using UnityEngine;

public class GPSCheck : MonoBehaviour
{

    public double first_Lat;
    public double first_Long;
    public double current_Lat;
    public double current_Long;

    private static WaitForSeconds second;

    private static bool gpsStarted = false;

    private static LocationInfo location;

    private void Awake()
    {
        second = new WaitForSeconds(1.0f);
    }

    private void Start()
    {
        StartCoroutine(GSP());
    }

    private IEnumerator GSP()
    {
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("GPS is not enabled");
            yield break;
        }


        Input.location.Start(5f, 10f);
        Debug.Log("Awaiting initialization");


        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return second;
            maxWait -= 1;
        }

        if (maxWait < 1)
        {
            Debug.Log("Timed out");
            yield break;
        }


        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine device location");
            yield break;

        }
        else
        {

            location = Input.location.lastData;
            first_Lat = location.latitude * 1.0d;
            first_Long = location.longitude * 1.0d;
            gpsStarted = true;


            while (gpsStarted)
            {
                location = Input.location.lastData;
                current_Lat = location.latitude * 1.0d;
                current_Long = location.longitude * 1.0d;
                yield return second;
            }
        }
    }

    public static void StopGPS()
    {
        if (Input.location.isEnabledByUser)
        {
            gpsStarted = false;
            Input.location.Stop();
        }
    }
}



