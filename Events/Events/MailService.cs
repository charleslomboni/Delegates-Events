using System;

namespace Events {

    public class MailService {

        /// <summary>
        /// Called when fire the event
        /// </summary>
        /// <param name="video"></param>
        public void OnVideoEncoded(Video video) {
            Console.WriteLine($"MailService: Sending a mail message... {video.Name} Encoded");
        }
    }
}