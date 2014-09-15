using System;
using System.Collections.Generic;
using Spyer.Common;
using Spyer.Contracts;
using Spyer.Dal;

namespace Spyer.Domain
{
    public class CapturesManagement
    {
        private readonly CapturesRepository _repository;

        public CapturesManagement()
        {
            _repository = new CapturesRepository();
        }

        public void Add(string bytes)
        {
            Ensure.NotNullOrEmpty(bytes);

            var capture = new Capture { Bytes = bytes.GetBytes(), CreationDate = DateTime.Now };

            _repository.Add(capture);
        }

        public IList<Capture> Search()
        {
            return null;
        } 
    }
}