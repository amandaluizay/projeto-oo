using System.Collections.Generic;
using Balta.ContentContext.Enums;
namespace Balta.ContentContext{
    public class Course: Content{
        public Course(string title, string url) : base(title, url)
        {
        }

        public Course(string title, string url, string tag)
        : base(title,url)
        {
            Modules =  new List<Module>();
            Tag = tag;
        }
       
       public string Tag {get; set;}
       public IList<Module> Modules {get; set;}
       public int DurationInMinutes {get; set;}
       public EcontentLevel Level {get; set;}
    }

}