﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.BLL.DTO
{
    public class TestDTO
    {
        //Через этот класс мы будем передавать объекты тестов между DAL и PL
        public int Id { get; set; }
        public int Id_Owner { get; set; }
        public string Title { get; set; }
        public int TimeForTest { get; set; }
        public int Id_Category { get; set; }
    }
}