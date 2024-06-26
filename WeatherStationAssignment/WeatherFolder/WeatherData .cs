﻿namespace WeatherStationAssignment.WeatherFolder;

using System.Collections;
using WeatherFolder.Interfaces;

/// <summary>
/// Here is a subject for all the Observer
/// </summary>
/// <typeparam name="T">Any</typeparam>


public class WeatherData<T>
{
    private T? _value;
    IList<IDisplay<T>> subscribers = new List<IDisplay<T>>();

    public T? Value{
        get{
            return _value;
        }

        set{
            _value = value;
            Notify(value);
        }
    }

    public void Subscribe(IDisplay<T> subscriber){
         if(!subscribers.Contains(subscriber))
             subscribers.Add(subscriber);
    }

    public void UnSubscribe(IDisplay<T> subscriber){
         if(subscribers.Contains(subscriber))
             subscribers.Remove(subscriber);
    }

    private void Notify(T? message){
        foreach(var sub in subscribers){
            sub.Display(message);
        }
    }

}