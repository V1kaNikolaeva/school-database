using System;

namespace School.Models
{
    public class OrderModel
    {
        protected int _id;
        protected DateTime _dataCreate;
        //protected ClientModel _client;
        protected bool _removed;

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
        }
    }
}
