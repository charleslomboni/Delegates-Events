# Delegates-Events
>Examples of how use delegates and events.
Above there are some tips of how create, call and use it.

__Steps to create a event__
* Define a delegate
* Define an event based on that delegate
* Raise the event


__Declare an event with parameter__
```csharp
public event Action<Video> VideoEncoded;
```

__Sign the event__

```csharp
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
```


__Event method__

```csharp
/// <summary>
/// Default protected virtual void Event method
/// Receives a video class and publish the message
/// </summary>
/// <param name="videoName"></param>
protected virtual void OnVideoEncoded(Video videoName) {
    // If VideoEncoded delegate is not null
    // Call the method who assign them
    VideoEncoded?.Invoke(videoName);
}
```