using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books_Management_using_MVC.Models;

namespace Books_Management_using_MVC.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> books;
        // GET: Book
        public ActionResult Index()
        {
            if (books == null)
            {
                books = new List<Book>();

                books.Add(new Book
                {
                    Id = 1,
                    Author = "Raed Ismail",
                    Title = "The Road To Success",
                    Price = 100.75m
                });

                books.Add(new Book
                {
                    Id = 2,
                    Author = "Najeeb Mahfouz",
                    Title = "Talking above the Neel River",
                    Price = 70m
                });

                books.Add(new Book
                {
                    Id = 3,
                    Author = "Nizar Kabany",
                    Title = "Love",
                    Price = 80
                });

                books.Add(new Book
                {
                    Id = 4,
                    Author = "Bassil Nazir",
                    Title = "Programmers are crazy",
                    Price = 60
                });


            }
            return View(books);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            Book book = books.Single(s => s.Id == id);

            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                // TODO: Add insert logic here

                books.Add(book);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            Book book = books.Single(a => a.Id == id);
            return View(book);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                // TODO: Add update logic here
                Book oldbook = books.Single(a => a.Id == id);

                oldbook.Author = book.Author;
                oldbook.Title = book.Title;
                oldbook.Price = book.Price;
                


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = books.Single(a => a.Id == id);

            
            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Book book = books.Single(a => a.Id == id);

                books.Remove(book);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
