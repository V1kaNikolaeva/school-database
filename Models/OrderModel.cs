using System;
using System.Collections.Generic;

namespace School.Models
{
    public class OrderModel
    {
        protected int _id;
        protected DateTime _dataCreate;
        //protected ClientModel _client;
        protected bool _removed;
        protected HashSet<SubjectModel> _subjects;

        public decimal price
        {
            get
            {
                decimal result = 0;
                foreach ( SubjectModel subject in _subjects )
                {
                    result += subject.price;
                }
                return result;
            }
        }
        public OrderModel(
                int id,
                DateTime dataCreate,
                //ClientModel client,
                bool removed
            ) 
        {
            _id = id;
            _dataCreate = dataCreate;
            //_client = client;
            _removed = removed;

            _subjects = new HashSet<SubjectModel>();
        }

        public void AddService(SubjectModel service)
        {
            _subjects.Add(service);
        }

        public void RemoveService(SubjectModel service)
        {
            _subjects.Remove(service);
        }
    }
}
