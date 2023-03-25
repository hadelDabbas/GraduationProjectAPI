﻿using GraduationProjectAPI.Model;
namespace GraduationProjectAPI.Infrastructure
{
    public interface IBookLibrarycs
    {
        public BookLibrary GetBookLibrary(int id);
        public IQueryable<BookLibrary> GetBookLibraries { get; }
        public void Save(BookLibrary bookLibrary);
        public void Update(BookLibrary bookLibrary);
        public void Delete(int id);
    }
}
