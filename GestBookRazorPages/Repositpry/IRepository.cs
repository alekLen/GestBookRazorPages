﻿namespace GestBookRazorPages.Repositpry
{
    public interface IRepository
    {
        Task<Salt> GetSalt(User user);
        Task<List<Message>> GetMessage();
        Task<User> GetUser(string name);
        Task AddUser(User user);
        Task AddSalt(Salt s);
        Task AddMessage(Message mess);
        Task Save();
    }
}
