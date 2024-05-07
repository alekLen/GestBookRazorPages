﻿using Microsoft.EntityFrameworkCore;
using GestBookRazorPages.Models;
namespace GestBookRazorPages.Repositpry
{
    public class GestBookRepository : IRepository
    {
        GestBookContext db;
        public GestBookRepository(GestBookContext context)
        {
            try
            {
                db = context;
            }
            catch(Exception ex) { throw ex; }
        }
        public async Task<Salt> GetSalt(User u)
        {
            return await db.Salts.FirstOrDefaultAsync(m => m.user == u);
        }
        public async Task<List<Message>> GetMessage()
        {
            return await db.Messages.Include(p => p.user).ToListAsync();
        }
        public async Task<User> GetUser(string name)
        {
            return await db.Users.FirstOrDefaultAsync(m => m.Name == name);
        }
        public async Task AddUser(User user)
        {
            await db.AddAsync(user);
        }
        public async Task AddSalt(Salt s)
        {
            await db.AddAsync(s);
        }
        public async Task AddMessage(Message mess)
        {
            await db.AddAsync(mess);
        }
        public async Task Save()
        {
            await db.SaveChangesAsync();
        }
    }
}
