using System;
using System.Collections.Generic;

namespace ConsoleApp1.Classes
{
  public class Library
  {
    private List<Book> _books = new List<Book>();
    private List<Member> _members = new List<Member>();

    public IReadOnlyList<Book> Books => _books;
    public IReadOnlyList<Member> Members => _members;


  // Library Management Methods
    public bool AddBook(Book book)
    {
      throw new NotImplementedException("implement this method");
    }

    public bool RemoveBook(int id)
    {
      throw new NotImplementedException("implement this method");
    }

    public Book? FindBookById(int id)
    {
      throw new NotImplementedException("implement this method");
    }

    public List<Book> SearchBook(string title)
    {
      throw new NotImplementedException("implement this method");
    }

    // Members Management Methods
    public bool AddMember(Member member)
    {
      throw new NotImplementedException("implement this method");
    }

    public bool RemoveMember(int id)
    {
      throw new NotImplementedException("implement this method");
    }

    public Member? FindMemberById(int id)
    {
      throw new NotImplementedException("implement this method");
    }

    // Borrow Process mehtods
    public bool BorrowBook(int memberId, int bookId)
    {
      throw new NotImplementedException("implement this method");
    }

    public bool ReturnBook(int memberId, int bookId)
    {
      throw new NotImplementedException("implement this method");
    }

    //Helper Methods

    private bool BookExists(int id)
    {
      throw new NotImplementedException("implement this method");
    }

    private bool MemberExists(int id)
    {
      throw new NotImplementedException("implement this method");
    }

    private bool IsBookAvailable(Book book)
    {
      throw new NotImplementedException("implement this method");
    }
  }
}