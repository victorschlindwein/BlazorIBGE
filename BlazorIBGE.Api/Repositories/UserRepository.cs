﻿using DesafioBalta.Context;
using DesafioBalta.Models;
using DesafioBalta.Services;
using Microsoft.EntityFrameworkCore;

namespace DesafioBalta.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiContext _context;

        public UserRepository(ApiContext context)
        {
            _context = context;
        }

        public async Task<User> CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            var token = TokenService.GenerateToken(user);

            user.AcessToken = token;

            return user;
        }

        public async Task<User> LoginUserAsync(User user)
        {
            var databaseUser = await _context.Users.FirstOrDefaultAsync(x => x.Email.Equals(user.Email) && x.Password.Equals(user.Password));

            if (databaseUser == null)
            {
                user.Email = null;
                user.Password = null;
                user.AcessToken = null;
                return user;
            }

            var token = TokenService.GenerateToken(databaseUser);
            databaseUser.AcessToken = token;

            return databaseUser;
        }

        public async Task<List<User>> GetAllAsync()
        {
            var users = await _context.Users.ToListAsync();
            foreach (var user in users)
            {
                var token = TokenService.GenerateToken(user);
                user.AcessToken = token;
            }
            return users;
        }
    }
}