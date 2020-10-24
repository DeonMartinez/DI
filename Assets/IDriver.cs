using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDriver
{
    void Control(Bike bike);
}

public class HumanDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("A human (player) will control the bike");
    }
}

public class AndroidDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by an AI");
    }
}

public class BingBotDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by a BingBot");
    }
}

public class HatsumeDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike will be controlled by Hatsume");
    }
}
