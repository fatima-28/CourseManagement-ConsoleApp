﻿using CourseManagamentApp.Domain.Entities;
using CourseManagamentApp.Repository.Repositories.Implementations;
using CourseManagamentApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagamentApp.Services.Implementations
{
    public class GroupService : IGroupService
    {
        private readonly GroupRepository _repo;
        

        public GroupService()
        {
            _repo = new GroupRepository();
        }
        public Group Create(Group group)
        {
            _repo.Add(group);
            return group;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll()
        {
            throw new NotImplementedException();
        }

        public Group GetById(int id)
        {
            if (id == null) throw new ArgumentNullException();
            return _repo.Get(m => m.Id == id);
        }

        public Group GetByName(string groupNo)
        {
            if (groupNo == null) throw new ArgumentNullException();
            return _repo.Get(m => m.GroupNum == groupNo);
        }   
    }
}
