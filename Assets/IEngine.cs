using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEngine
{
    void StartEngine();
}

public class JetEngine : IEngine
{
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Engine started");
    }
    private void ActivateJetStream()
    {
        Debug.Log("The jet stream is activated");
    }
}

public class NitroEngine : IEngine
{
    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine started");
    }
    private void OpenNitroValve()
    {
        Debug.Log("The nitro valve is open");
    }
}

public class TurboEngine : IEngine
{
    public void StartEngine()
    {
        HitTheTurbo();
        Debug.Log("Engine started");
    }
    private void HitTheTurbo()
    {
        Debug.Log("It's TurboTastic!!!");
    }
}

public class SearchEngine : IEngine
{
    public void StartEngine()
    {
        BeginSearching();
        Debug.Log("Engine started");
    }
    private void BeginSearching()
    {
        Debug.Log("knowledge is horsepower");
    }
}

public class TenyaEngine : IEngine
{
    public void StartEngine()
    {
        ActivateReciproBurst();
        Debug.Log("Engine started");
    }
    private void ActivateReciproBurst()
    {
        Debug.Log("RECIPRO BUUUURTS!!!!");
    }
}