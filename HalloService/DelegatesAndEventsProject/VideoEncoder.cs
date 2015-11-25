using System;
using System.Threading;

namespace DelegatesAndEventsProject
{
    public class VideoEncoder
    {

        public delegate void VideoEncodedEventHandler(object sourve, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;


        public VideoEncoder()
        {

        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }

    }
}