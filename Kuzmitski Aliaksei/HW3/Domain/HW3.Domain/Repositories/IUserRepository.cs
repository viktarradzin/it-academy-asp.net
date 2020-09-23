﻿using HW3.Domain.Models;
using System;
using System.Collections.Generic;

namespace HW3.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository
    {
        void CreateUser(User user);
        User ReadUser(Guid id);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
        List<User> AllUsers();

        Country ReadCountry(Guid id);
        List<Country> AllCountries();

        City ReadCity(Guid id);
        List<City> AllCities();

    }
}
