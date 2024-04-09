using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBB_SE_2024_Team_42.Repository;

namespace UBB_SE_2024_Team_42.Service
{
    public class Service
    {
        private Repository.Repository repository;

        // no other fields required for now

        public Service(Repository.Repository repository)
        {
            this.repository = repository;
        }

    }
}
