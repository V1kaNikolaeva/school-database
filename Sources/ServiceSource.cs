using School.Models;

namespace School.Sources
{
    public class ServiceSource
    {
        private SubjectModel _subject;

        public bool selected;
        public string subjectName
        {
            get { return _subject.subjectName; }
        }

        public decimal price
        {
            get { return _subject.price; }
        }


        public ServiceSource(SubjectModel subject)
        {
            selected = false;
            _subject = subject;
        }
    }
}
