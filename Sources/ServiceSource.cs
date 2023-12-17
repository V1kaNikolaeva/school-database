using School.Models;
using School;

namespace School.Sources
{
    public class ServiceSource
    {
        private SubjectModel _subject;
        private bool _selected;
        private NewOrderForm _form;
        public bool selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
                
                if (selected)
                {
                    _form.currentOrder.AddService(_subject);
                }
                else
                {
                    _form.currentOrder.RemoveService(_subject);
                }
                _form.UpdateOrderTotal();
            }
        }
        public string subjectName
        {
            get { return _subject.subjectName; }
        }

        public decimal price
        {
            get { return _subject.price; }
        }


        public ServiceSource(SubjectModel subject, NewOrderForm form)
        {
            _selected = false;
            _subject = subject;
            _form = form;
        }
    }
}


