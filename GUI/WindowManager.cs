﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBB_SE_2024_Team_42.Repository;
using UBB_SE_2024_Team_42.Service;
namespace UBB_SE_2024_Team_42.GUI
{
    public class WindowManager
    {
        private Repository.Repository repository;
        private Service.Service service;
        public WindowManager()
        {
            repository = new Repository.Repository("String");
            service = new Service.Service(repository);
        }
    }
}
