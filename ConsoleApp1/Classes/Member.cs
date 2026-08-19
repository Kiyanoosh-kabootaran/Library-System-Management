using System;
using System.Collections.Generic;

namespace ConsoleApp1.Classes
{
  public class Member
  {
    public int Id {get;private set;}
    public string FirstName {get; private set;}
    public string LastName {get; private set;}
    public string Phone {get; private set;}


    private List<Book> _borrowedBooks = new List<Book>();

    public IReadOnlyList<Book> BorrowedBooks => _borrowedBooks;

    public Member(int id, string firstName, string lastName, string phone)
    {
      this.Id = id;
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Phone = phone;
    }

    public bool BorrowBook(Book book)
    {
      throw new NotImplementedException("implement this method");
    }

    public bool ReturnBook(Book book)
    {
      throw new NotImplementedException("implement this method");
    }

    public bool HasBook(Book book)
    {
      throw new NotImplementedException("implement this method");
    }
  
  public string ShowInfo()
    {
      throw new NotImplementedException("implement this method");
    }
  }
}