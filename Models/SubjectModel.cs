namespace School.Models
{
    public class SubjectModel
    {
        protected int _id;
        protected string _subjectName;
        protected int _price;

        public string subjectName
        {
            get { return _subjectName; }
        }

        public decimal price
        {
            get { return _price; }
        }

        public SubjectModel(
                int id,
                string subjectName,
                int price
            ) 
        {
            _id = id;
            _subjectName = subjectName;
            _price = price;
        }

        public override string ToString()
        {
            return _subjectName;
        }
    }
}
