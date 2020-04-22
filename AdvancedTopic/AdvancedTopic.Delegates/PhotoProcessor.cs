using System;

namespace AdvancedTopic.Delegates
{
    public class PhotoProcessor
    {
        // Signature of Method
        //public delegate void PhotoFilterHandler(Photo photo);
        //use 
        public void Process(string path,Action<Photo> filterHandler)
        {
            var photo = Photo.LoadPhoto(path);
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            filterHandler(photo);
            photo.Save();
        }
    }
}
