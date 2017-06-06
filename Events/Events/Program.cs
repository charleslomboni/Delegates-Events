using System;

namespace Events {

    internal class Program {

        private static void Main(string[] args) {
            // Fill class video with a name value
            var video = new Video {
                Name = "DelegatesAndEvents.mp4"
            };

            // Publish
            var videoEncoder = new VideoEncoder();

            // Subscribers
            var messageService = new MessageService();
            var mailService = new MailService();

            // Sign the event
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            // Call to method that encode the video
            videoEncoder.Enconde(video);

            // Wait for some character in console application
            Console.Read();
        }
    }
}