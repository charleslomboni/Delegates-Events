using System;
using System.Threading;

namespace Events {

    /// <summary>
    /// Publish class
    /// </summary>
    public class VideoEncoder {
        // Steps to create a event
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        // Declare an event with parameter
        public event Action<Video> VideoEncoded;

        /// <summary>
        /// Method that encode a video with a format
        /// </summary>
        /// <param name="video"></param>
        public void Encode(Video video) {
            Console.WriteLine("Enconding Video...");
            Thread.Sleep(3000);
            // Call the event that send message to the subscribers
            OnVideoEncoded(video);
        }

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
    }
}