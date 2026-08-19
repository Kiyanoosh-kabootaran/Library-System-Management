using System;
using System.Collections.Generic;

namespace ConsoleApp1.Classes
{
  public class Book
  {
    public int Id {get; private set;}
    public string Title {get; private set;}
    public string Author {get; private set;}
    public int PublishYear {get; private set;}
    public string Category {get; private set;}
    public bool IsBorrowed {get; private set;} = false;

    public Book(int id, string title, string author, int publishYear, string category)
    {
      this.Id = id;
      this.Title = title;
      this.Author = author;
      this.PublishYear = publishYear;
      this.Category = category;
    }

    public bool Borrow()
    {
      throw new NotImplementedException("implement this method");
    }

    public bool ReturnBook()
    {
      throw new NotImplementedException("implement this method");
    }

    public int BorrowedBooksCount()
    {
      throw new NotImplementedException("implement this method");
    }

    public override string ToString()
    {
      throw new NotImplementedException("implement this method");
    }
  }
}