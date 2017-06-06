using System;

namespace Events {

    public class MessageService {

        /// <summary>
        /// Called when fire the event
        /// </summary>
        /// <param name="video"></param>
        public void OnVideoEncoded(Video video) {
            Console.WriteLine($"MessageService: Sending a text message... {video.Name} Encoded");
        }
    }
}