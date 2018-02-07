using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Fisher.Bookstore.Models;
using System.Collections.Generic;

namespace Fisher.Bookstore.Pages
{
    public class Books : PageModel{
        public List<Book> books {get;set;}
        public void OnGet(){
            books.Add(new Book(){
                Title = "Continuous Delivery",
                Author = new Author() { Name = "Jez Humble" }
            });
            books.Add(new Book(){
                Title = "Lean Enterprise",
                Author = new Author() { Name = "Barry O'Reilly" }
            });
            books.Add(new Book(){
                Title = "The Goal",
                Author = new Author() { Name = "Eliyahu Goldratt" }
            });
        }
    }
}