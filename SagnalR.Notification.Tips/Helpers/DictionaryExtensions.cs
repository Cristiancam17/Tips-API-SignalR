﻿namespace SagnalR.Notification.Tips.Helpers;

public static class DictionaryExtensions
{
    public static void AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key, TValue value)
    {
        if (source.ContainsKey(key))
            source[key] = value;
        else
            source.Add(key, value);
    }
}