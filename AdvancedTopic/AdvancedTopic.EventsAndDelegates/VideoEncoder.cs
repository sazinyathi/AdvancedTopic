using AdvancedTopic.EventsAndDelegates.Services;
using System;

namespace AdvancedTopic.EventsAndDelegates
{
    public class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(Object obj,EventArgs args);
        public event VideoEncoderEventHandler VideoEncodered;
        private MailService mailService;
        public VideoEncoder()
        {
            mailService = new MailService();
        }
        public void SendEncoding()
        {
            Console.WriteLine("Sending Ecncoding");
            //mailService.SendEmail("Send Email");
            //mailService.SendEmail("Sms Message");
            OnVideoEncodered();
        }

        protected virtual void OnVideoEncodered()
        {
            if(VideoEncodered != null)
            {
                VideoEncodered(this, EventArgs.Empty);
            }
        }
    }
}
